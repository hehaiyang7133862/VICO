﻿#pragma checksum "..\..\..\..\..\..\ctrls\mainPanel\carriage\Carriage_AutoPurge.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "54EF28E121044167679A2EA044AFD655"
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
    /// Carriage_AutoPurge
    /// </summary>
    public partial class Carriage_AutoPurge : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\..\ctrls\mainPanel\carriage\Carriage_AutoPurge.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cvsMain;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\..\ctrls\mainPanel\carriage\Carriage_AutoPurge.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cvsHeadAutoPurge;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\..\ctrls\mainPanel\carriage\Carriage_AutoPurge.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbStart;
        
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
            System.Uri resourceLocater = new System.Uri("/Program;component/ctrls/mainpanel/carriage/carriage_autopurge.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ctrls\mainPanel\carriage\Carriage_AutoPurge.xaml"
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
            this.cvsMain = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.cvsHeadAutoPurge = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.lbStart = ((System.Windows.Controls.Label)(target));
            
            #line 17 "..\..\..\..\..\..\ctrls\mainPanel\carriage\Carriage_AutoPurge.xaml"
            this.lbStart.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lbStart_MouseDown);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\..\..\..\ctrls\mainPanel\carriage\Carriage_AutoPurge.xaml"
            this.lbStart.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.lbStart_MouseUp);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\..\..\..\ctrls\mainPanel\carriage\Carriage_AutoPurge.xaml"
            this.lbStart.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lbStart_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

