﻿#pragma checksum "..\..\TablePlayers.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "845F0AEF006EC432EED6B18B23D2BA3CA319535217325F83FC040C0A65696E9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using dbplayers;


namespace dbplayers {
    
    
    /// <summary>
    /// TablePlayers
    /// </summary>
    public partial class TablePlayers : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 151 "..\..\TablePlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox parfoun;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\TablePlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox valapr;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\TablePlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pargr;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\TablePlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button group;
        
        #line default
        #line hidden
        
        
        #line 252 "..\..\TablePlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tablepl;
        
        #line default
        #line hidden
        
        
        #line 271 "..\..\TablePlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
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
            System.Uri resourceLocater = new System.Uri("/dbplayers;component/tableplayers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TablePlayers.xaml"
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
            this.parfoun = ((System.Windows.Controls.ComboBox)(target));
            
            #line 162 "..\..\TablePlayers.xaml"
            this.parfoun.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.parfoun_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.valapr = ((System.Windows.Controls.TextBox)(target));
            
            #line 194 "..\..\TablePlayers.xaml"
            this.valapr.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.valapr_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pargr = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.group = ((System.Windows.Controls.Button)(target));
            
            #line 237 "..\..\TablePlayers.xaml"
            this.group.Click += new System.Windows.RoutedEventHandler(this.group_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tablepl = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 278 "..\..\TablePlayers.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 6:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 266 "..\..\TablePlayers.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.profileopen);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

