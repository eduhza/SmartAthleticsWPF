﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A08FD7D74ADC90E82C8D443BC41AF6378C55EF35"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SmartAthleticsWPF;
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


namespace SmartAthleticsWPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 78 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid nav_pnl;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel st_pnl;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Tg_Btn;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard HideStackPanel;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard ShowStackPanel;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LV;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolTip tt_LiveGraph;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolTip tt_Calibration;
        
        #line default
        #line hidden
        
        
        #line 239 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolTip tt_Settings;
        
        #line default
        #line hidden
        
        
        #line 263 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolTip tt_Help;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SmartAthleticsWPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nav_pnl = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.st_pnl = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.Tg_Btn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 123 "..\..\..\MainWindow.xaml"
            this.Tg_Btn.Unchecked += new System.Windows.RoutedEventHandler(this.Tg_Btn_Unchecked);
            
            #line default
            #line hidden
            
            #line 124 "..\..\..\MainWindow.xaml"
            this.Tg_Btn.Checked += new System.Windows.RoutedEventHandler(this.Tg_Btn_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.HideStackPanel = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 5:
            this.ShowStackPanel = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 6:
            this.LV = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            
            #line 178 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ListViewItem_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tt_LiveGraph = ((System.Windows.Controls.ToolTip)(target));
            return;
            case 9:
            
            #line 201 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ListViewItem_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tt_Calibration = ((System.Windows.Controls.ToolTip)(target));
            return;
            case 11:
            
            #line 225 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ListViewItem_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 12:
            this.tt_Settings = ((System.Windows.Controls.ToolTip)(target));
            return;
            case 13:
            
            #line 249 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ListViewItem_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 14:
            this.tt_Help = ((System.Windows.Controls.ToolTip)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

