﻿#pragma checksum "..\..\..\..\..\View\Windows\PrimaryWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ED819C090110FEB3DBFE89E7F38F2064D559B989"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SunCloud.View.Windows;
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


namespace SunCloud.View.Windows {
    
    
    /// <summary>
    /// PrimaryWindow
    /// </summary>
    public partial class PrimaryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\View\Windows\PrimaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeWindowBtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\View\Windows\PrimaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MaximizeWindowBtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\View\Windows\PrimaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseWindowBtn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\View\Windows\PrimaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CurrentCityTb;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\View\Windows\PrimaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WeatherPageBtn;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\View\Windows\PrimaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SettingsPageBtn;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\..\View\Windows\PrimaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame WeatherSettingsPageFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SunCloud;V1.0.0.0;component/view/windows/primarywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Windows\PrimaryWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\..\View\Windows\PrimaryWindow.xaml"
            ((SunCloud.View.Windows.PrimaryWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DragWindow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MinimizeWindowBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            
            #line 25 "..\..\..\..\..\View\Windows\PrimaryWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MinimizeWindow);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MaximizeWindowBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            
            #line 28 "..\..\..\..\..\View\Windows\PrimaryWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MaximizeWindow);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CloseWindowBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            
            #line 31 "..\..\..\..\..\View\Windows\PrimaryWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseWindow);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CurrentCityTb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.WeatherPageBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.SettingsPageBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.WeatherSettingsPageFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

