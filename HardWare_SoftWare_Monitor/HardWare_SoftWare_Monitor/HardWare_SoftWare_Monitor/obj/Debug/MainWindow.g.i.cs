// Updated by XamlIntelliSenseFileGenerator 2021. 04. 22. 17:26:15
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "118A002C1F7BA215334D08681752407CE733B57CC0B8FD8E7DB92C1135E2454C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Pc_Monitoring_Software_Hardware;
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


namespace Pc_Monitoring_Software_Hardware
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Info;

#line default
#line hidden


#line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem CPU;

#line default
#line hidden


#line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Software;

#line default
#line hidden


#line 70 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;

#line default
#line hidden


#line 71 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;

#line default
#line hidden


#line 82 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Temp;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HardWare_SoftWare_Monitor;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 16 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.TabControl)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TabControl_SelectionChanged);

#line default
#line hidden
                    return;
                case 2:
                    this.Info = ((System.Windows.Controls.TabItem)(target));
                    return;
                case 3:
                    this.gomb_1 = ((System.Windows.Controls.Button)(target));

#line 35 "..\..\MainWindow.xaml"
                    this.gomb_1.Click += new System.Windows.RoutedEventHandler(this.gomb_1_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.gomb_2 = ((System.Windows.Controls.Button)(target));

#line 39 "..\..\MainWindow.xaml"
                    this.gomb_2.Click += new System.Windows.RoutedEventHandler(this.gomb_2_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.text_1 = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.text_2 = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.text_3 = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.text_5 = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 9:
                    this.text_6 = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 10:
                    this.text_7 = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 11:
                    this.text_8 = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 12:
                    this.text_9 = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 13:
                    this.CPU = ((System.Windows.Controls.TabItem)(target));
                    return;
                case 14:

#line 59 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
                case 15:
                    this.Software = ((System.Windows.Controls.TabItem)(target));
                    return;
                case 16:
                    this.listBox = ((System.Windows.Controls.ListBox)(target));
                    return;
                case 17:
                    this.label = ((System.Windows.Controls.Label)(target));
                    return;
                case 18:
                    this.Temp = ((System.Windows.Controls.TabItem)(target));
                    return;
                case 19:
                    this.gomb_excel = ((System.Windows.Controls.Button)(target));

#line 85 "..\..\MainWindow.xaml"
                    this.gomb_excel.Click += new System.Windows.RoutedEventHandler(this.gomb_excel_Click);

#line default
#line hidden
                    return;
                case 20:
                    this.gomb_3_Copy1 = ((System.Windows.Controls.Button)(target));

#line 99 "..\..\MainWindow.xaml"
                    this.gomb_3_Copy1.Click += new System.Windows.RoutedEventHandler(this.gomb_3_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button btn1;
        internal System.Windows.Controls.Button btn2;
        internal System.Windows.Controls.TextBox text1;
        internal System.Windows.Controls.TextBox text2;
        internal System.Windows.Controls.TextBox text3;
        internal System.Windows.Controls.TextBox text5;
        internal System.Windows.Controls.TextBox text6;
        internal System.Windows.Controls.TextBox text7;
        internal System.Windows.Controls.TextBox text8;
        internal System.Windows.Controls.TextBox text9;
        internal System.Windows.Controls.Button btn3;
        internal System.Windows.Controls.Button btn_save;
    }
}

