﻿#pragma checksum "..\..\..\..\ctrls\NumericInput.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ED1275BBD9AECC171855D6BBC71E2CA4"
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
    /// NumericInput
    /// </summary>
    public partial class NumericInput : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\ctrls\NumericInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cvsBackGround;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\ctrls\NumericInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cvsMain;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\ctrls\NumericInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbDiscription;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\ctrls\NumericInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbMaxValue;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\ctrls\NumericInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbOriginalValue;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\ctrls\NumericInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbCurrentValue;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\ctrls\NumericInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbUnit;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\ctrls\NumericInput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbMinValue;
        
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
            System.Uri resourceLocater = new System.Uri("/Program;component/ctrls/numericinput.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ctrls\NumericInput.xaml"
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
            this.cvsBackGround = ((System.Windows.Controls.Canvas)(target));
            
            #line 9 "..\..\..\..\ctrls\NumericInput.xaml"
            this.cvsBackGround.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.cvsBackGround_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cvsMain = ((System.Windows.Controls.Canvas)(target));
            
            #line 10 "..\..\..\..\ctrls\NumericInput.xaml"
            this.cvsMain.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.cvsMain_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbDiscription = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lbMaxValue = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lbOriginalValue = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lbCurrentValue = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lbUnit = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lbMinValue = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            
            #line 21 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 22 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 23 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 24 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 25 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 26 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 27 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 28 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 29 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 30 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 31 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 32 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 33 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 34 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseDown);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btn_MouseUp);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\..\ctrls\NumericInput.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

