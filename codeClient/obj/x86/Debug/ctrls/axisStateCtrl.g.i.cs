﻿#pragma checksum "..\..\..\..\ctrls\axisStateCtrl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "91C56298EBD95A6B61E2C5F958303140"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
using System.Windows.Forms.Integration;
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
using nsVicoClient.ctrls;


namespace nsVicoClient.ctrls {
    
    
    /// <summary>
    /// axisStateCtrl
    /// </summary>
    public partial class axisStateCtrl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\ctrls\axisStateCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal nsVicoClient.ctrls.axisStateItemCtrl MotoCtrl;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\ctrls\axisStateCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal nsVicoClient.ctrls.axisStateItemCtrl axisStateItemCtrl2;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\ctrls\axisStateCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal nsVicoClient.ctrls.axisStateItemCtrl ServoCtrl;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\ctrls\axisStateCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal nsVicoClient.ctrls.axisStateItemCtrl axisStateItemCtrl4;
        
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
            System.Uri resourceLocater = new System.Uri("/Program;component/ctrls/axisstatectrl.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ctrls\axisStateCtrl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.MotoCtrl = ((nsVicoClient.ctrls.axisStateItemCtrl)(target));
            return;
            case 2:
            this.axisStateItemCtrl2 = ((nsVicoClient.ctrls.axisStateItemCtrl)(target));
            return;
            case 3:
            this.ServoCtrl = ((nsVicoClient.ctrls.axisStateItemCtrl)(target));
            return;
            case 4:
            this.axisStateItemCtrl4 = ((nsVicoClient.ctrls.axisStateItemCtrl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

