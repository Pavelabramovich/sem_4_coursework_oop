﻿#pragma checksum "..\..\..\..\ChangeName\CreatingName.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F26B33401FFFD8C151FD9C9717E7264C4E2544A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseProjectOpp;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace CourseProjectOpp {
    
    
    /// <summary>
    /// CreatingOrder
    /// </summary>
    public partial class CreatingOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\..\ChangeName\CreatingName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cardNumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\ChangeName\CreatingName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label invalidCardNumberLabel;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\ChangeName\CreatingName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown countUpDown;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\ChangeName\CreatingName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\ChangeName\CreatingName.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CourseProjectOpp;V1.0.0.0;component/changename/creatingname.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ChangeName\CreatingName.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 15 "..\..\..\..\ChangeName\CreatingName.xaml"
            ((CourseProjectOpp.CreatingOrder)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cardNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\..\ChangeName\CreatingName.xaml"
            this.cardNumberTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.cardNumberTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.invalidCardNumberLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.countUpDown = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 5:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\..\ChangeName\CreatingName.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.BntCreate_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\..\..\ChangeName\CreatingName.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

