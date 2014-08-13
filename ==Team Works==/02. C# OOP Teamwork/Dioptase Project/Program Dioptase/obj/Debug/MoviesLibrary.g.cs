﻿#pragma checksum "..\..\MoviesLibrary.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "99E59EE20F8A4E581160D8DAAA61293D"
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
    /// MoviesLibrary
    /// </summary>
    public partial class MoviesLibrary : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\MoviesLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander GenreExpander;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MoviesLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel GenrePanel;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MoviesLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResetCheckBoxexButton;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MoviesLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle TopLeftRectangle;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\MoviesLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ToMainWindow;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MoviesLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle TopRightRectangle;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\MoviesLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MovieIcon;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\MoviesLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel AllMoviesPanel;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\MoviesLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas SearchFieldCanvas;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\MoviesLibrary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchByNameBox;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\MoviesLibrary.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ProgramDioptase;component/movieslibrary.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MoviesLibrary.xaml"
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
            
            #line 16 "..\..\MoviesLibrary.xaml"
            ((ProgramDioptase.MoviesLibrary)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MoveTheWindow);
            
            #line default
            #line hidden
            
            #line 17 "..\..\MoviesLibrary.xaml"
            ((ProgramDioptase.MoviesLibrary)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 19 "..\..\MoviesLibrary.xaml"
            ((ProgramDioptase.MoviesLibrary)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
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
            
            #line 31 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 31 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 32 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 33 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 33 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 34 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 35 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 35 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 36 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 36 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 37 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 37 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 38 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 38 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 39 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 39 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 40 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 40 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 41 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 41 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 42 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 42 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 43 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 43 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 44 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 44 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 45 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 45 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 46 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 46 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 47 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 48 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            
            #line 48 "..\..\MoviesLibrary.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.OnCheckBoxSelection);
            
            #line default
            #line hidden
            return;
            case 22:
            this.ResetCheckBoxexButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\MoviesLibrary.xaml"
            this.ResetCheckBoxexButton.Click += new System.Windows.RoutedEventHandler(this.OnResetCheckBoxedGenresButtonClick);
            
            #line default
            #line hidden
            return;
            case 23:
            this.TopLeftRectangle = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 67 "..\..\MoviesLibrary.xaml"
            this.TopLeftRectangle.MouseMove += new System.Windows.Input.MouseEventHandler(this.ToMainWindow_MouseMove);
            
            #line default
            #line hidden
            
            #line 68 "..\..\MoviesLibrary.xaml"
            this.TopLeftRectangle.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ToMainWindow_MouseLeave);
            
            #line default
            #line hidden
            
            #line 69 "..\..\MoviesLibrary.xaml"
            this.TopLeftRectangle.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ToMainWindow_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 24:
            this.ToMainWindow = ((System.Windows.Controls.Image)(target));
            
            #line 74 "..\..\MoviesLibrary.xaml"
            this.ToMainWindow.MouseMove += new System.Windows.Input.MouseEventHandler(this.ToMainWindow_MouseMove);
            
            #line default
            #line hidden
            
            #line 75 "..\..\MoviesLibrary.xaml"
            this.ToMainWindow.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ToMainWindow_MouseLeave);
            
            #line default
            #line hidden
            
            #line 76 "..\..\MoviesLibrary.xaml"
            this.ToMainWindow.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ToMainWindow_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 25:
            this.TopRightRectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 26:
            this.MovieIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 27:
            this.AllMoviesPanel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 28:
            this.SearchFieldCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 29:
            this.SearchByNameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 115 "..\..\MoviesLibrary.xaml"
            this.SearchByNameBox.GotFocus += new System.Windows.RoutedEventHandler(this.OnSearchBoxGotFocus);
            
            #line default
            #line hidden
            
            #line 116 "..\..\MoviesLibrary.xaml"
            this.SearchByNameBox.LostFocus += new System.Windows.RoutedEventHandler(this.OnSearchBoxLostFocus);
            
            #line default
            #line hidden
            return;
            case 30:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\MoviesLibrary.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.OnSearchButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

