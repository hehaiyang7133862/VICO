﻿#pragma checksum "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "46BF1EE939BC2E10AA200EAA83834319"
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
    /// btnAttentionCtrl
    /// </summary>
    public partial class btnAttentionCtrl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cvsBackground;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cvsMain;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbValueDis;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbConfirm;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbCancel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb2;
        
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
            System.Uri resourceLocater = new System.Uri("/Program;component/ctrls/mainpanel/btnattentionctrl.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
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
            this.cvsBackground = ((System.Windows.Controls.Canvas)(target));
            
            #line 9 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
            this.cvsBackground.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.cvsBackground_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cvsMain = ((System.Windows.Controls.Canvas)(target));
            
            #line 11 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
            this.cvsMain.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.cvsMain_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbValueDis = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lbConfirm = ((System.Windows.Controls.Label)(target));
            
            #line 19 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
            this.lbConfirm.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lbConfirm_MouseDown);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
            this.lbConfirm.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.lbConfirm_MouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lbCancel = ((System.Windows.Controls.Label)(target));
            
            #line 21 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
            this.lbCancel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lbCancel_MouseDown);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\..\..\ctrls\mainPanel\btnAttentionCtrl.xaml"
            this.lbCancel.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.lbCancel_MouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lb1 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lb2 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

