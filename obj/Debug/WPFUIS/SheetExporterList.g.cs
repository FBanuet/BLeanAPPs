﻿#pragma checksum "..\..\..\WPFUIS\SheetExporterList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "959A647A721F73FC930E44B6247DFC91C5670C31A68E37B4B36A1E0B0380946F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using DATools.WPFUIS;
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


namespace DATools.WPFUIS {
    
    
    /// <summary>
    /// SheetExporterList
    /// </summary>
    public partial class SheetExporterList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\WPFUIS\SheetExporterList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGet;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\WPFUIS\SheetExporterList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SheetList;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\WPFUIS\SheetExporterList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRun;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\WPFUIS\SheetExporterList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\WPFUIS\SheetExporterList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAll;
        
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
            System.Uri resourceLocater = new System.Uri("/DATools;component/wpfuis/sheetexporterlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WPFUIS\SheetExporterList.xaml"
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
            this.btnGet = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\WPFUIS\SheetExporterList.xaml"
            this.btnGet.Click += new System.Windows.RoutedEventHandler(this.btnGet_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SheetList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.btnRun = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\WPFUIS\SheetExporterList.xaml"
            this.btnRun.Click += new System.Windows.RoutedEventHandler(this.btnRun_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\WPFUIS\SheetExporterList.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAll = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\WPFUIS\SheetExporterList.xaml"
            this.btnAll.Click += new System.Windows.RoutedEventHandler(this.btnSelect_All);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
