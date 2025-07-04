﻿#pragma checksum "..\..\..\MainMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1D49FF8EB9D2F313DDD0C825216DA1A8554B9D5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace LanguageApp {
    
    
    /// <summary>
    /// MainMenu
    /// </summary>
    public partial class MainMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TestsButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ThemesButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MistakesButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SettingsButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel TestButtonsPanel;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ThemePanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LanguageApp;component/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TestsButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\MainMenu.xaml"
            this.TestsButton.Click += new System.Windows.RoutedEventHandler(this.Tests_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ThemesButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\MainMenu.xaml"
            this.ThemesButton.Click += new System.Windows.RoutedEventHandler(this.Themes_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MistakesButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\MainMenu.xaml"
            this.MistakesButton.Click += new System.Windows.RoutedEventHandler(this.Mistakes_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SettingsButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\MainMenu.xaml"
            this.SettingsButton.Click += new System.Windows.RoutedEventHandler(this.Settings_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TestButtonsPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            
            #line 22 "..\..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EngToUkr_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 23 "..\..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UkrToEng_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 24 "..\..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToMain_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ThemePanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            
            #line 28 "..\..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Theme_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 29 "..\..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Theme_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 30 "..\..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Theme_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 31 "..\..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToMain_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

