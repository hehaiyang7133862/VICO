﻿#pragma checksum "..\..\..\..\..\ctrls\mainPanel\cancelBtn.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F39C38DBC74938A9EE8FF449AAF7D8AA"
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


namespace nsVicoClient.ctrls {
    
    
    /// <summary>
    /// cancelBtn
    /// </summary>
    public partial class cancelBtn : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\ctrls\mainPanel\cancelBtn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgDown;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\ctrls\mainPanel\cancelBtn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\ctrls\mainPanel\cancelBtn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbDis;
        
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
            System.Uri resourceLocater = new System.Uri("/Program;component/ctrls/mainpanel/cancelbtn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ctrls\mainPanel\cancelBtn.xaml"
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
            this.imgDown = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.img = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.lbDis = ((System.Windows.Controls.Label)(target));
            
            #line 11 "..\..\..\..\..\ctrls\mainPanel\cancelBtn.xaml"
            this.lbDis.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.img_MouseDown);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\..\..\ctrls\mainPanel\cancelBtn.xaml"
            this.lbDis.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.img_MouseUp);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\..\..\ctrls\mainPanel\cancelBtn.xaml"
            this.lbDis.MouseLeave += new System.Windows.Input.MouseEventHandler(this.img_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

