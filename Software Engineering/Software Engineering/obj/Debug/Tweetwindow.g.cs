﻿#pragma checksum "..\..\Tweetwindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4884E8AC68E73C7F9958A82A78FE326B3AC0E533"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Software_Engineering;
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


namespace Software_Engineering {
    
    
    /// <summary>
    /// Tweetwindow
    /// </summary>
    public partial class Tweetwindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Tweetwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tweetsender;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Tweetwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tweetmsg;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Tweetwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tweetsubmit;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Tweetwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tweetgrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Tweetwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox tweetlstbox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Tweetwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tweetsubmit_Copy;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Tweetwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Finish;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Tweetwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Finish_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/Software Engineering;component/tweetwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Tweetwindow.xaml"
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
            this.tweetsender = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tweetmsg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tweetsubmit = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Tweetwindow.xaml"
            this.tweetsubmit.Click += new System.Windows.RoutedEventHandler(this.tweetsubmit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tweetgrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.tweetlstbox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.tweetsubmit_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Tweetwindow.xaml"
            this.tweetsubmit_Copy.Click += new System.Windows.RoutedEventHandler(this.tweetsubmit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Finish = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Tweetwindow.xaml"
            this.Finish.Click += new System.Windows.RoutedEventHandler(this.Finish_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Finish_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Tweetwindow.xaml"
            this.Finish_Copy.Click += new System.Windows.RoutedEventHandler(this.Finish_Copy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

