﻿#pragma checksum "..\..\AddVoprosikOkno.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7AF8BD0AFD32B727ABE2A9BCF444430065DCF415FE57C5EED31298446A187F47"
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
using Testiki;


namespace Testiki {
    
    
    /// <summary>
    /// AddVoprosikOkno
    /// </summary>
    public partial class AddVoprosikOkno : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\AddVoprosikOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VoprosTbox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddVoprosikOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OpisonieTBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AddVoprosikOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstTbox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\AddVoprosikOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SecondTBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\AddVoprosikOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ThirdTbox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\AddVoprosikOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CorrectCB;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\AddVoprosikOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ZaverchBtm;
        
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
            System.Uri resourceLocater = new System.Uri("/Testiki;component/addvoprosikokno.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddVoprosikOkno.xaml"
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
            this.VoprosTbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.OpisonieTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.FirstTbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SecondTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ThirdTbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CorrectCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.ZaverchBtm = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\AddVoprosikOkno.xaml"
            this.ZaverchBtm.Click += new System.Windows.RoutedEventHandler(this.ZaverchBtm_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

