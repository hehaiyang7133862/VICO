﻿#pragma checksum "..\..\..\..\..\..\..\ctrls\mainPanel\interpretor\iprUnitMenu\btnFunc1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5C59C50F54300184B7CCC7A7C81ACEC0"
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
    /// btnFunc1
    /// </summary>
    public partial class btnFunc1 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\..\..\ctrls\mainPanel\interpretor\iprUnitMenu\btnFunc1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgDown;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\..\..\ctrls\mainPanel\interpretor\iprUnitMenu\btnFunc1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgUp;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\..\..\ctrls\mainPanel\interpretor\iprUnitMenu\btnFunc1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgErr;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\..\ctrls\mainPanel\interpretor\iprUnitMenu\btnFunc1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbFocus;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\..\..\ctrls\mainPanel\interpretor\iprUnitMenu\btnFunc1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Dis;
        
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
            System.Uri resourceLocater = new System.Uri("/Program;component/ctrls/mainpanel/interpretor/iprunitmenu/btnfunc1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\ctrls\mainPanel\interpretor\iprUnitMenu\btnFunc1.xaml"
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
            this.imgUp = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.imgErr = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.lbFocus = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Dis = ((System.Windows.Controls.Label)(target));
            
            #line 13 "..\..\..\..\..\..\..\ctrls\mainPanel\interpretor\iprUnitMenu\btnFunc1.xaml"
            this.Dis.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Dis_MouseDown);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\..\..\..\ctrls\mainPanel\interpretor\iprUnitMenu\btnFunc1.xaml"
            this.Dis.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Dis_MouseUp);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\..\..\..\ctrls\mainPanel\interpretor\iprUnitMenu\btnFunc1.xaml"
            this.Dis.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Dis_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
