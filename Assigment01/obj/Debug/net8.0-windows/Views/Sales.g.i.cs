﻿#pragma checksum "..\..\..\..\Views\Sales.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EB2DA4CDA186120A3F4F32188F2D881998EC22B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Assigment01;
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


namespace Assigment01 {
    
    
    /// <summary>
    /// Sales
    /// </summary>
    public partial class Sales : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mainAppItem;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem adminAppItem;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox productsComboBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox amountTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addCartButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buyItems;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox cartListBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock amountTextBlock;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\Sales.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock priceTextBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Assigment01;component/views/sales.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Sales.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mainAppItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\..\..\Views\Sales.xaml"
            this.mainAppItem.Click += new System.Windows.RoutedEventHandler(this.mainAppItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.adminAppItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 25 "..\..\..\..\Views\Sales.xaml"
            this.adminAppItem.Click += new System.Windows.RoutedEventHandler(this.adminAppItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.productsComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\..\Views\Sales.xaml"
            this.productsComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.productsComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.amountTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\..\Views\Sales.xaml"
            this.amountTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.amountTextBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addCartButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Views\Sales.xaml"
            this.addCartButton.Click += new System.Windows.RoutedEventHandler(this.addCartButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buyItems = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Views\Sales.xaml"
            this.buyItems.Click += new System.Windows.RoutedEventHandler(this.buyItems_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.removeButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Views\Sales.xaml"
            this.removeButton.Click += new System.Windows.RoutedEventHandler(this.removeButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cartListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 36 "..\..\..\..\Views\Sales.xaml"
            this.cartListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cartListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.amountTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.priceTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

