﻿#pragma checksum "..\..\..\..\GUI\CustomerScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09294825EB1B4A2272478B6A5B44556F0676D99A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace Assignment1.GUI {
    
    
    /// <summary>
    /// CustomerScreen
    /// </summary>
    public partial class CustomerScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\GUI\CustomerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBooking;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\GUI\CustomerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAccount;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\GUI\CustomerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuit;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\GUI\CustomerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbWelcome;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\GUI\CustomerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock hiddenField;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\GUI\CustomerScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTestID;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Assignment1;component/gui/customerscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUI\CustomerScreen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnBooking = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\..\GUI\CustomerScreen.xaml"
            this.btnBooking.Click += new System.Windows.RoutedEventHandler(this.btnBooking_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnAccount = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\..\GUI\CustomerScreen.xaml"
            this.btnAccount.Click += new System.Windows.RoutedEventHandler(this.btnAccount_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnQuit = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\GUI\CustomerScreen.xaml"
            this.btnQuit.Click += new System.Windows.RoutedEventHandler(this.btnQuit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txbWelcome = ((System.Windows.Controls.TextBlock)(target));
            
            #line 15 "..\..\..\..\GUI\CustomerScreen.xaml"
            this.txbWelcome.Loaded += new System.Windows.RoutedEventHandler(this.txbWelcome_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.hiddenField = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.btnTestID = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\GUI\CustomerScreen.xaml"
            this.btnTestID.Click += new System.Windows.RoutedEventHandler(this.btnTestID_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
