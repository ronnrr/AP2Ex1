﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A574191B6C378D00425E340013E53AEE00462F6725A3D03025FF24EDDE3562C4"
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
using WpfApp1;
using WpfApp1.Controls;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openFile;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider timeSlider;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider rudder;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider throttle;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pauseButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stopButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button increaseSpeed;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button decreaseSpeed;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Base;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Knob;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse KnobBase;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.TranslateTransform knobPosition;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox list;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.openFile = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\MainWindow.xaml"
            this.openFile.Click += new System.Windows.RoutedEventHandler(this.OpenFile);
            
            #line default
            #line hidden
            return;
            case 2:
            this.timeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.timeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rudder = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            this.throttle = ((System.Windows.Controls.Slider)(target));
            return;
            case 5:
            this.playButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.playButton.Click += new System.Windows.RoutedEventHandler(this.PlayClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.pauseButton = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\MainWindow.xaml"
            this.pauseButton.Click += new System.Windows.RoutedEventHandler(this.PauseClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.stopButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\MainWindow.xaml"
            this.stopButton.Click += new System.Windows.RoutedEventHandler(this.StopClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.increaseSpeed = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.increaseSpeed.Click += new System.Windows.RoutedEventHandler(this.IncreaseFrequency);
            
            #line default
            #line hidden
            return;
            case 9:
            this.decreaseSpeed = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\MainWindow.xaml"
            this.decreaseSpeed.Click += new System.Windows.RoutedEventHandler(this.DecreaseFrequency);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Base = ((System.Windows.Controls.Canvas)(target));
            return;
            case 11:
            this.Knob = ((System.Windows.Controls.Canvas)(target));
            return;
            case 12:
            this.KnobBase = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 13:
            this.knobPosition = ((System.Windows.Media.TranslateTransform)(target));
            return;
            case 14:
            this.list = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

