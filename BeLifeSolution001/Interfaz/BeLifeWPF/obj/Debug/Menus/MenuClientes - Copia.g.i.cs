﻿#pragma checksum "..\..\..\Menus\MenuClientes - Copia.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79D574367A8E17D3FD71B0192509036774F9EB38"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using BeLifeWPF;
using MahApps.Metro.Controls;
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


namespace BeLifeWPF {
    
    
    /// <summary>
    /// MenuClientes
    /// </summary>
    public partial class MenuClientes : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Menus\MenuClientes - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid FondoPrincipal;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Menus\MenuClientes - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile BtnInicio;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Menus\MenuClientes - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile BtnMenuCliente;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Menus\MenuClientes - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile BtnMenuContratos;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Menus\MenuClientes - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnContraste;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Menus\MenuClientes - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile BtnAgregarCliente;
        
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
            System.Uri resourceLocater = new System.Uri("/BeLifeWPF;component/menus/menuclientes%20-%20copia.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Menus\MenuClientes - Copia.xaml"
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
            this.FondoPrincipal = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.BtnInicio = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 14 "..\..\..\Menus\MenuClientes - Copia.xaml"
            this.BtnInicio.Click += new System.Windows.RoutedEventHandler(this.BtnInicio_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnMenuCliente = ((MahApps.Metro.Controls.Tile)(target));
            return;
            case 4:
            this.BtnMenuContratos = ((MahApps.Metro.Controls.Tile)(target));
            return;
            case 5:
            this.BtnContraste = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Menus\MenuClientes - Copia.xaml"
            this.BtnContraste.Click += new System.Windows.RoutedEventHandler(this.BtnContraste_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnAgregarCliente = ((MahApps.Metro.Controls.Tile)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
