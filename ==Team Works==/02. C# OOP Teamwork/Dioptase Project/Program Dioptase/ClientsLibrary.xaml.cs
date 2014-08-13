namespace ProgramDioptase
{
    using System;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using ProgramDioptase.ClientDescription;
    using ProgramDioptase.Interfaces.ItemDescription;

    public partial class ClientsLibrary : Window
    {
        private static Panel clientInfoContainer;

        public ClientsLibrary()
        {
            this.InitializeComponent();

            ElementRenderer.VizualizeClientNamesToPanel(this.ClientsListBox, App.Resources.Clients);
            clientInfoContainer = this.InfoAboutClientGrid;

            this.HideClientDescriptionImages();
            this.ShowBasketItemsToGrid();
        }

        #region [Client Info Contaioner - operations]

        private void ClientInfoContainer_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.ShowClientDescriptionImages();

            Client selectedClient = this.InfoAboutClientGrid.DataContext as Client;

            var baseDirectory = App.FileManager.GetBaseDirectory("Client");

            ElementRenderer.VisualizeImageInPanel(this.PictureBoxContainer, selectedClient.Name, baseDirectory);

            this.NameText.Text = selectedClient.Name;
            this.AgeText.Text = selectedClient.Age.ToString();
            this.AddressText.Text = selectedClient.Address;
            this.PhoneText.Text = selectedClient.MobileNumber;
        }

        public static void ChangeDataContextOfClientInfoContainer(Client client)
        {
            clientInfoContainer.DataContext = client;
        }

        private void ShowClientDescriptionImages()
        {
            this.NameImage.Visibility = System.Windows.Visibility.Visible;
            this.AddressImage.Visibility = System.Windows.Visibility.Visible;
            this.AgeImage.Visibility = System.Windows.Visibility.Visible;
            this.PhoneImage.Visibility = System.Windows.Visibility.Visible;
        }

        private void HideClientDescriptionImages()
        {
            this.NameImage.Visibility = System.Windows.Visibility.Hidden;
            this.AddressImage.Visibility = System.Windows.Visibility.Hidden;
            this.AgeImage.Visibility = System.Windows.Visibility.Hidden;
            this.PhoneImage.Visibility = System.Windows.Visibility.Hidden;
        }

        #endregion

        #region [Basket Vizualization - Show/Add items]
        
        private void ShowBasketItemsToGrid()
        {
            if (Basket.PurchasedItems.Count > 0 || Basket.RentedItems.Count > 0)
            {
                this.BasketElementsScrollViewer.Visibility = System.Windows.Visibility.Visible;
                this.BasketElementsStackPanel.Visibility = System.Windows.Visibility.Visible;
                this.ClientsScrollViewer.Margin = new Thickness(10, 119, 650, 324);
                this.ClientsListBox.Height = 257;
                
                foreach (var item in Basket.RentedItems)
                {
                    this.AddItemToBasketGrid(item as IDescription);
                }
                
                foreach (var item in Basket.PurchasedItems)
                {
                    this.AddItemToBasketGrid(item as IDescription);
                }
                
                Grid resetButtonGrid = new Grid();
                resetButtonGrid.Margin = new Thickness(5, 0, 0, 0);
                
                Button resetButton = new Button();
                resetButton.Content = "Empty Basket";
                resetButton.Height = 20;
                
                resetButtonGrid.Children.Add(resetButton);
                
                resetButton.Click += (sender, args) =>
                {
                    Basket.EmptyBasket();              
                    this.ShowBasketItemsToGrid();
                };
                
                this.BasketElementsStackPanel.Children.Add(resetButtonGrid);
            }
            else
            {
                this.BasketElementsScrollViewer.Visibility = System.Windows.Visibility.Hidden;
                this.BasketElementsStackPanel.Visibility = System.Windows.Visibility.Hidden;
                this.ClientsScrollViewer.Margin = new Thickness(10, 119, 650, 10);
                this.ClientsListBox.Height = 571;
            }
        }
        
        private void AddItemToBasketGrid(IDescription itemDescription)
        {
            Grid newItemGrid = new Grid();
            newItemGrid.Margin = new Thickness(5, 0, 0, 10);
            newItemGrid.Height = 50;
            
            var imageColumn = new ColumnDefinition();
            imageColumn.Width = new GridLength(50);
            
            newItemGrid.ColumnDefinitions.Add(imageColumn);
            newItemGrid.ColumnDefinitions.Add(new ColumnDefinition());
            
            ElementRenderer.VisualizeImageInPanel(
                newItemGrid, itemDescription.Name, App.FileManager.GetBaseDirectory(itemDescription.GetType().Name));
            
            var textBlock = new TextBlock();
            textBlock.Text = itemDescription.Name;
            textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            textBlock.Margin = new Thickness(5, 0, 0, 0);
            textBlock.FontSize = 15;
            
            Grid.SetColumn(textBlock, 1);
            newItemGrid.Children.Add(textBlock);
            
            this.BasketElementsStackPanel.Children.Add(newItemGrid);
        }
        
        #endregion

        #region [WINDOW events - Close / Minimize / Moving / Closing / VisibleChanged]
        
        private void MoveTheWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Closing -= this.Window_Closing;
            e.Cancel = true;
            
            DoubleAnimation animation = ElementRenderer.WindowAnimation(this);
            
            this.BeginAnimation(Window.OpacityProperty, animation);
            
            animation.Completed += (s, _) => this.Close();
            this.BeginAnimation(UIElement.OpacityProperty, animation);
        }
        
        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }
        
        private void MinimazeButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }
        
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DoubleAnimation animation = ElementRenderer.WindowAnimation(this, 0, 1);
        
            this.BeginAnimation(Window.OpacityProperty, animation);
        }
        
        private void ToMainWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            this.Close();
            
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        
        #endregion
        
        #region [Set/Unset color of Labels and Boxes - using OnHover and OnLeave Events]
        
        static readonly Brush lineOnHoverColor = Brushes.GhostWhite;
        static readonly Brush lineOnLeaveColor = Brushes.CornflowerBlue;
        
        private void ToMainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            this.TopLeftRectangle.Fill = lineOnLeaveColor;
        }
        
        private void ToMainWindow_MouseLeave(object sender, MouseEventArgs e)
        {
            this.TopLeftRectangle.Fill = this.Background;
        }
        
        #endregion
        
        #region [Search box & Button Events]
        
        private void OnSearchButtonClick(object sender, RoutedEventArgs e)
        {
            ElementRenderer.VizualizeNewClientsSearchResult(
                this.ClientsListBox, this.InfoAboutClientGrid, this.SearchByNameBox, App.Resources.Clients);
        }
        
        private void OnSearchBoxGotFocus(object sender, RoutedEventArgs e)
        {
            ElementRenderer.SearchBoxRemoveContent(this.SearchByNameBox);
        }
        
        private void OnSearchBoxLostFocus(object sender, RoutedEventArgs e)
        {
            ElementRenderer.SearchBoxPutContent(this.SearchByNameBox);
        }
        
        #endregion
    }
}