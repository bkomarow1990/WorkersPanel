#pragma checksum "..\..\..\Windows\EditRegisterWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ECCD8DE557702A7383D32FAABCE7F3FDFE9EE308462A85BD68F1965A7EB45F54"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WorkersPanel.Windows;


namespace WorkersPanel.Windows {
    
    
    /// <summary>
    /// EditRegisterWindow
    /// </summary>
    public partial class EditRegisterWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Windows\EditRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTxtBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\EditRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surnameTxtBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\EditRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ageTxtBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\EditRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox isActiveCheckBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Windows\EditRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image pictureImg;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Windows\EditRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button choosePictureBtn;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Windows\EditRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okBtn;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Windows\EditRegisterWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WorkersPanel;component/windows/editregisterwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\EditRegisterWindow.xaml"
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
            this.nameTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.surnameTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ageTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.isActiveCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.pictureImg = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.choosePictureBtn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Windows\EditRegisterWindow.xaml"
            this.choosePictureBtn.Click += new System.Windows.RoutedEventHandler(this.choosePictureBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.okBtn = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Windows\EditRegisterWindow.xaml"
            this.okBtn.Click += new System.Windows.RoutedEventHandler(this.okBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Windows\EditRegisterWindow.xaml"
            this.cancelBtn.Click += new System.Windows.RoutedEventHandler(this.cancelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

