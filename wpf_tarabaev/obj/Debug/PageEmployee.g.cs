#pragma checksum "..\..\PageEmployee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E431302E6389CB1A89E10463DFA21F90F7D7AA938B08537368A0D232010FA55A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using wpf_tarabaev;
using wpf_tarabaev.Commands;
using wpf_tarabaev.Model;
using wpf_tarabaev.ValidationRules;


namespace wpf_tarabaev {
    
    
    /// <summary>
    /// PageEmployee
    /// </summary>
    public partial class PageEmployee : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 55 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar ToolBar1;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button undo;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button find;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit_remove;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refresh;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridEmployee;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderFind;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridFind;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Find;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockSurname;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockTitle;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSurname;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxTitle;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonFindSurname;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\PageEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonFindTitle;
        
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
            System.Uri resourceLocater = new System.Uri("/wpf_tarabaev;component/pageemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageEmployee.xaml"
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
            
            #line 13 "..\..\PageEmployee.xaml"
            ((wpf_tarabaev.PageEmployee)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ToolBar1 = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 3:
            this.undo = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.add = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.edit = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.find = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.save = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.edit_remove = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.refresh = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.DataGridEmployee = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            this.BorderFind = ((System.Windows.Controls.Border)(target));
            return;
            case 12:
            this.GridFind = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            this.Find = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.TextBlockSurname = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.TextBlockTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 16:
            this.TextBoxSurname = ((System.Windows.Controls.TextBox)(target));
            
            #line 146 "..\..\PageEmployee.xaml"
            this.TextBoxSurname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxSurname_TextChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.ComboBoxTitle = ((System.Windows.Controls.ComboBox)(target));
            
            #line 148 "..\..\PageEmployee.xaml"
            this.ComboBoxTitle.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxTitle_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.ButtonFindSurname = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\PageEmployee.xaml"
            this.ButtonFindSurname.Click += new System.Windows.RoutedEventHandler(this.ButtonFindSurname_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.ButtonFindTitle = ((System.Windows.Controls.Button)(target));
            
            #line 153 "..\..\PageEmployee.xaml"
            this.ButtonFindTitle.Click += new System.Windows.RoutedEventHandler(this.ButtonFindTitle_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 160 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.DeleteCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 160 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.DeleteCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 161 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.UndoCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 161 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.UndoCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 162 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.NewCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 162 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.NewCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 163 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 163 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.SaveCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 164 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.FindCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 164 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.FindCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 165 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.EditCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 165 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.EditCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 166 "..\..\PageEmployee.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.RefreshCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

