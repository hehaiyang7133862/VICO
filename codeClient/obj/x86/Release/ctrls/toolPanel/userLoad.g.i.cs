﻿#pragma checksum "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CD84EFE9A7AF3974E567670DD36CF898"
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
    /// userLoad
    /// </summary>
    public partial class userLoad : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cvsMain;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgUserLoaded;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgUserBeginToQuit;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgUserNull;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgUserNOAccess;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbAccessLevelBg;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbAccessLevel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse epMain;
        
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
            System.Uri resourceLocater = new System.Uri("/Program;component/ctrls/toolpanel/userload.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
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
            
            #line 8 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
            this.cvsMain.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.cvsMain_MouseUp);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
            this.cvsMain.MouseLeave += new System.Windows.Input.MouseEventHandler(this.cvsMain_MouseLeave);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
            this.cvsMain.MouseMove += new System.Windows.Input.MouseEventHandler(this.cvsMain_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imgUserLoaded = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.imgUserBeginToQuit = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.imgUserNull = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.imgUserNOAccess = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.lbAccessLevelBg = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lbAccessLevel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.epMain = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 18 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
            this.epMain.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Ellipse_MouseDown);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
            this.epMain.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Ellipse_MouseUp);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\..\..\ctrls\toolPanel\userLoad.xaml"
            this.epMain.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Ellipse_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

