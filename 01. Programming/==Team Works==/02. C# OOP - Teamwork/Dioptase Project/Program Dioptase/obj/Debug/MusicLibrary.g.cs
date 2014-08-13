﻿#pragma checksum "..\..\MusicLibrary.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9F9C4A0DDFBFE7482291DC2FC58C1618"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ProgramDioptase {
    
    
    /// <summary>
    /// MusicLibrary
    /// </summary>
    public partial class MusicLibrary : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\MusicLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander GenreExpander;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MusicLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel GenrePanel;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MusicLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResetCheckBoxexButton;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MusicLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle TopLeftRectangle;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\MusicLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ToMainWindow;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\MusicLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle TopRightRectangle;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\MusicLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MusicIcon;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\MusicLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel AllMusicPanel;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\MusicLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas SearchFieldCanvas;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\MusicLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\MusicLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProgramDioptase;component/musiclibrary.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MusicLibrary.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\MusicLibrary.xaml"
            ((ProgramDioptase.MusicLibrary)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MoveTheWindow);
            
            #line default
            #line hidden
            
            #line 14 "..\..\MusicLibrary.xaml"
            ((ProgramDioptase.MusicLibrary)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 16 "..\..\MusicLibrary.xaml"
            ((ProgramDioptase.MusicLibrary)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GenreExpander = ((System.Windows.Controls.Expander)(target));
            return;
            case 3:
            this.GenrePanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            
            #line 29 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 29 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 30 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 30 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 31 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 31 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 32 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 33 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 33 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 34 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 35 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 35 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 36 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 36 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 37 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 37 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 38 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 38 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 39 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 39 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 40 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 40 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 41 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 41 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 42 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 42 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 43 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 43 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 44 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 44 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 45 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 45 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 46 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 46 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 47 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MusicLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 23:
            this.ResetCheckBoxexButton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\MusicLibrary.xaml"
            this.ResetCheckBoxexButton.Click += new System.Windows.RoutedEventHandler(this.OnResetCheckBoxedGenresButtonClick);
            
            #line default
            #line hidden
            return;
            case 24:
            this.TopLeftRectangle = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 65 "..\..\MusicLibrary.xaml"
            this.TopLeftRectangle.MouseMove += new System.Windows.Input.MouseEventHandler(this.ToMainWindow_MouseMove);
            
            #line default
            #line hidden
            
            #line 66 "..\..\MusicLibrary.xaml"
            this.TopLeftRectangle.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ToMainWindow_MouseLeave);
            
            #line default
            #line hidden
            
            #line 67 "..\..\MusicLibrary.xaml"
            this.TopLeftRectangle.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ToMainWindow_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 25:
            this.ToMainWindow = ((System.Windows.Controls.Image)(target));
            
            #line 72 "..\..\MusicLibrary.xaml"
            this.ToMainWindow.MouseMove += new System.Windows.Input.MouseEventHandler(this.ToMainWindow_MouseMove);
            
            #line default
            #line hidden
            
            #line 73 "..\..\MusicLibrary.xaml"
            this.ToMainWindow.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ToMainWindow_MouseLeave);
            
            #line default
            #line hidden
            
            #line 74 "..\..\MusicLibrary.xaml"
            this.ToMainWindow.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ToMainWindow_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 26:
            this.TopRightRectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 27:
            this.MusicIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 28:
            this.AllMusicPanel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 29:
            this.SearchFieldCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 30:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 122 "..\..\MusicLibrary.xaml"
            this.SearchBox.GotFocus += new System.Windows.RoutedEventHandler(this.OnSearchBoxGotFocus);
            
            #line default
            #line hidden
            
            #line 123 "..\..\MusicLibrary.xaml"
            this.SearchBox.LostFocus += new System.Windows.RoutedEventHandler(this.OnSearchBoxLostFocus);
            
            #line default
            #line hidden
            return;
            case 31:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\MusicLibrary.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.OnSearchButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
