﻿#pragma checksum "..\..\..\pages\RegisterPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5856FBCE53505E3725FA2C1CD8CB44E4F2870C4D722B95A18C1A1691C648FC0D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Diplom_V4;
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


namespace Diplom_V4 {
    
    
    /// <summary>
    /// RegisterPage
    /// </summary>
    public partial class RegisterPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\pages\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\pages\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\pages\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\pages\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\pages\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumGr;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\pages\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmKtSotr;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\pages\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button register;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\pages\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button @return;
        
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
            System.Uri resourceLocater = new System.Uri("/Система тестирования студентов;component/pages/registerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\RegisterPage.xaml"
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
            
            #line 9 "..\..\..\pages\RegisterPage.xaml"
            ((Diplom_V4.RegisterPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\pages\RegisterPage.xaml"
            this.Name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Name_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LastName = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\pages\RegisterPage.xaml"
            this.LastName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LastName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Email = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\pages\RegisterPage.xaml"
            this.Email.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Email_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 33 "..\..\..\pages\RegisterPage.xaml"
            this.Password.PasswordChanged += new System.Windows.RoutedEventHandler(this.Password_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.NumGr = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\pages\RegisterPage.xaml"
            this.NumGr.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NumGr_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmKtSotr = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\pages\RegisterPage.xaml"
            this.cmKtSotr.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmKtSotr_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.register = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\pages\RegisterPage.xaml"
            this.register.Click += new System.Windows.RoutedEventHandler(this.register_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.@return = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\pages\RegisterPage.xaml"
            this.@return.Click += new System.Windows.RoutedEventHandler(this.return_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

