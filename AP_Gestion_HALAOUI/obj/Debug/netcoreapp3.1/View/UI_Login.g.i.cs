﻿#pragma checksum "..\..\..\..\View\UI_Login.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97C1CC5C9850B9244D8FB7D3DCD140269CC8C717"
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
    /// UI_Login
    /// </summary>
    public partial class UI_Login : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\View\UI_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Login;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\View\UI_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Username;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\UI_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox TB_Password;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\View\UI_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Connexion;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\View\UI_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Configuration;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\View\UI_Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Quitter;
        
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
            System.Uri resourceLocater = new System.Uri("/AP_Gestion_HALAOUI;component/view/ui_login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\UI_Login.xaml"
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
            this.TB_Username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TB_Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.BTN_Connexion = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\View\UI_Login.xaml"
            this.BTN_Connexion.Click += new System.Windows.RoutedEventHandler(this.BTN_Connexion_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_Configuration = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\View\UI_Login.xaml"
            this.BTN_Configuration.Click += new System.Windows.RoutedEventHandler(this.BTN_Configuration_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BTN_Quitter = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\View\UI_Login.xaml"
            this.BTN_Quitter.Click += new System.Windows.RoutedEventHandler(this.BTN_Quitter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

