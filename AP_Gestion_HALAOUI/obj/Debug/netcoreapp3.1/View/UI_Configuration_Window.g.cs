﻿#pragma checksum "..\..\..\..\View\UI_Configuration_Window.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13837549AEAE24C0DA4F23521772A3A075DA8FD5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using AP_Gestion_HALAOUI.View;
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


namespace AP_Gestion_HALAOUI.View {
    
    
    /// <summary>
    /// UI_Configuration_Window
    /// </summary>
    public partial class UI_Configuration_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\View\UI_Configuration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Login;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\UI_Configuration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_bdd_host;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\UI_Configuration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_bdd_port;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\View\UI_Configuration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_bdd_username;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\View\UI_Configuration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_bdd_password;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\View\UI_Configuration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Test;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\View\UI_Configuration_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Valider;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AP_Gestion_HALAOUI;component/view/ui_configuration_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\UI_Configuration_Window.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Login = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TB_bdd_host = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TB_bdd_port = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TB_bdd_username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TB_bdd_password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BTN_Test = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\..\View\UI_Configuration_Window.xaml"
            this.BTN_Test.Click += new System.Windows.RoutedEventHandler(this.BTN_Test_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BTN_Valider = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\..\View\UI_Configuration_Window.xaml"
            this.BTN_Valider.Click += new System.Windows.RoutedEventHandler(this.BTN_Valider_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

