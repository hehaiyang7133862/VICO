﻿#pragma checksum "..\..\..\MsgBox.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7EC8C682B7D6F89E2DE80CCAD792AC3D"
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


namespace upGrade {
    
    
    /// <summary>
    /// MsgBox
    /// </summary>
    public partial class MsgBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\MsgBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDis;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\MsgBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbConfirm;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\MsgBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbRecover;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\MsgBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbCancle;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\MsgBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox;
        
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
            System.Uri resourceLocater = new System.Uri("/upgrade;component/msgbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MsgBox.xaml"
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
            this.tbDis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.lbConfirm = ((System.Windows.Controls.Label)(target));
            
            #line 13 "..\..\..\MsgBox.xaml"
            this.lbConfirm.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lbConfirm_MouseDown);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\MsgBox.xaml"
            this.lbConfirm.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lbConfirm_MouseLeave);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\MsgBox.xaml"
            this.lbConfirm.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.lbConfirm_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbRecover = ((System.Windows.Controls.Label)(target));
            
            #line 14 "..\..\..\MsgBox.xaml"
            this.lbRecover.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lbRecover_MouseDown);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\MsgBox.xaml"
            this.lbRecover.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.lbRecover_MouseUp);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\MsgBox.xaml"
            this.lbRecover.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lbRecover_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lbCancle = ((System.Windows.Controls.Label)(target));
            
            #line 15 "..\..\..\MsgBox.xaml"
            this.lbCancle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lbCancle_MouseDown);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\MsgBox.xaml"
            this.lbCancle.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lbCancle_MouseLeave);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\MsgBox.xaml"
            this.lbCancle.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.lbCancle_MouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.checkBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

