﻿#pragma checksum "..\..\..\..\..\ctrls\ctrlPanel\ctrlEmStop.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "99AA8805D02937D34A6B1E3C2C790765"
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
    /// ctrlEmStop
    /// </summary>
    public partial class ctrlEmStop : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\ctrls\ctrlPanel\ctrlEmStop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cvsMain;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\..\ctrls\ctrlPanel\ctrlEmStop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgEmStop;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\ctrls\ctrlPanel\ctrlEmStop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cvsEmStopActive;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\ctrls\ctrlPanel\ctrlEmStop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgEmStopActive;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\ctrls\ctrlPanel\ctrlEmStop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
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
            System.Uri resourceLocater = new System.Uri("/Program;component/ctrls/ctrlpanel/ctrlemstop.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ctrls\ctrlPanel\ctrlEmStop.xaml"
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
            this.cvsMain = ((System.Windows.Controls.Canvas)(target));
            
            #line 8 "..\..\..\..\..\ctrls\ctrlPanel\ctrlEmStop.xaml"
            this.cvsMain.MouseMove += new System.Windows.Input.MouseEventHandler(this.cvsMain_MouseMove);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\..\ctrls\ctrlPanel\ctrlEmStop.xaml"
            this.cvsMain.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.cvsMain_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imgEmStop = ((System.Windows.Controls.Image)(target));
            
            #line 9 "..\..\..\..\..\ctrls\ctrlPanel\ctrlEmStop.xaml"
            this.imgEmStop.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgEmStop_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cvsEmStopActive = ((System.Windows.Controls.Canvas)(target));
            
            #line 10 "..\..\..\..\..\ctrls\ctrlPanel\ctrlEmStop.xaml"
            this.cvsEmStopActive.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgEmStopActive_MouseDown);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\..\ctrls\ctrlPanel\ctrlEmStop.xaml"
            this.cvsEmStopActive.MouseLeave += new System.Windows.Input.MouseEventHandler(this.cvsEmStopActive_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.imgEmStopActive = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
