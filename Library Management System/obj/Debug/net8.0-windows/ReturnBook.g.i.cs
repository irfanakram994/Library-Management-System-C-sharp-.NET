﻿#pragma checksum "..\..\..\ReturnBook.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A0C6D2CFBA55C0C48B78193D388DC8CC42A9AF95"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library_Management_System;
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


namespace Library_Management_System {
    
    
    /// <summary>
    /// ReturnBook
    /// </summary>
    public partial class ReturnBook : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox memberIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchMemberButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bookIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchBookButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button returnBookButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox memberNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bookTitleTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library Management System;component/returnbook.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ReturnBook.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.memberIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.searchMemberButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\ReturnBook.xaml"
            this.searchMemberButton.Click += new System.Windows.RoutedEventHandler(this.SearchMemberButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bookIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.searchBookButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\ReturnBook.xaml"
            this.searchBookButton.Click += new System.Windows.RoutedEventHandler(this.SearchBookButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.returnBookButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\ReturnBook.xaml"
            this.returnBookButton.Click += new System.Windows.RoutedEventHandler(this.ReturnBookButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.memberNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.bookTitleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

