﻿#pragma checksum "..\..\VLDataChecker.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8D9A530F6BA22D7CC4F54787CF51C4B1A74B7912"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GID_Client;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace GID_Client {
    
    
    /// <summary>
    /// VLDataChecker
    /// </summary>
    public partial class VLDataChecker : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\VLDataChecker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.MaskedTextBox txbDocNum;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\VLDataChecker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.MaskedTextBox DpBirthDate;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\VLDataChecker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.MaskedTextBox txbGuvohnoma;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\VLDataChecker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\VLDataChecker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/GID_Client;component/vldatachecker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VLDataChecker.xaml"
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
            this.txbDocNum = ((Xceed.Wpf.Toolkit.MaskedTextBox)(target));
            
            #line 36 "..\..\VLDataChecker.xaml"
            this.txbDocNum.KeyDown += new System.Windows.Input.KeyEventHandler(this.txbDocNum_KeyDown);
            
            #line default
            #line hidden
            
            #line 37 "..\..\VLDataChecker.xaml"
            this.txbDocNum.KeyUp += new System.Windows.Input.KeyEventHandler(this.txbDocNum_KeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DpBirthDate = ((Xceed.Wpf.Toolkit.MaskedTextBox)(target));
            
            #line 53 "..\..\VLDataChecker.xaml"
            this.DpBirthDate.KeyUp += new System.Windows.Input.KeyEventHandler(this.DpBirthDate_KeyUp);
            
            #line default
            #line hidden
            
            #line 54 "..\..\VLDataChecker.xaml"
            this.DpBirthDate.KeyDown += new System.Windows.Input.KeyEventHandler(this.DpBirthDate_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbGuvohnoma = ((Xceed.Wpf.Toolkit.MaskedTextBox)(target));
            
            #line 71 "..\..\VLDataChecker.xaml"
            this.txbGuvohnoma.KeyDown += new System.Windows.Input.KeyEventHandler(this.txbGuvohnoma_KeyDown);
            
            #line default
            #line hidden
            
            #line 72 "..\..\VLDataChecker.xaml"
            this.txbGuvohnoma.KeyUp += new System.Windows.Input.KeyEventHandler(this.txbGuvohnoma_KeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\VLDataChecker.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\VLDataChecker.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

