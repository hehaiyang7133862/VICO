﻿#pragma checksum "..\..\..\..\..\ctrls\ctrlPanel\keyBoxesCtrl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D700B04F1DCE14452399979BC34694D"
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
    /// keyBoxesCtrl
    /// </summary>
    public partial class keyBoxesCtrl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\ctrls\ctrlPanel\keyBoxesCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cvsMain;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\..\ctrls\ctrlPanel\keyBoxesCtrl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cvsBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Program;component/ctrls/ctrlpanel/keyboxesctrl.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ctrls\ctrlPanel\keyBoxesCtrl.xaml"
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
            
            #line 8 "..\..\..\..\..\ctrls\ctrlPanel\keyBoxesCtrl.xaml"
            this.cvsMain.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.cvsMain_MouseUp);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\..\ctrls\ctrlPanel\keyBoxesCtrl.xaml"
            this.cvsMain.MouseLeave += new System.Windows.Input.MouseEventHandler(this.cvsMain_MouseLeave);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\..\ctrls\ctrlPanel\keyBoxesCtrl.xaml"
            this.cvsMain.MouseMove += new System.Windows.Input.MouseEventHandler(this.cvsMain_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cvsBox = ((System.Windows.Controls.Canvas)(target));
            
            #line 9 "..\..\..\..\..\ctrls\ctrlPanel\keyBoxesCtrl.xaml"
            this.cvsBox.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.cvsBox_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
