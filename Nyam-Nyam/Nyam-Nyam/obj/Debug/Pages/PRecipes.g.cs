﻿#pragma checksum "..\..\..\Pages\PRecipes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C07D243B393865C3C0162C0CD12F9F524C311681F90402FF1EF2406E2A255F68"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Nyam_Nyam.Pages;
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


namespace Nyam_Nyam.Pages {
    
    
    /// <summary>
    /// PRecipes
    /// </summary>
    public partial class PRecipes : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\Pages\PRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BMinus;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\PRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBCount;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\PRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BPlus;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Pages\PRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBTotalCost;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Pages\PRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGIngredient;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Pages\PRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVRecipesStep;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\Pages\PRecipes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BBack;
        
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
            System.Uri resourceLocater = new System.Uri("/Nyam-Nyam;component/pages/precipes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PRecipes.xaml"
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
            
            #line 10 "..\..\..\Pages\PRecipes.xaml"
            ((Nyam_Nyam.Pages.PRecipes)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BMinus = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Pages\PRecipes.xaml"
            this.BMinus.Click += new System.Windows.RoutedEventHandler(this.BMinus_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TBCount = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\..\Pages\PRecipes.xaml"
            this.TBCount.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TBCount_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\Pages\PRecipes.xaml"
            this.TBCount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBCount_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BPlus = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Pages\PRecipes.xaml"
            this.BPlus.Click += new System.Windows.RoutedEventHandler(this.BPlus_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TBTotalCost = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.DGIngredient = ((System.Windows.Controls.DataGrid)(target));
            
            #line 80 "..\..\..\Pages\PRecipes.xaml"
            this.DGIngredient.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DGIngredient_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LVRecipesStep = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.BBack = ((System.Windows.Controls.Button)(target));
            
            #line 156 "..\..\..\Pages\PRecipes.xaml"
            this.BBack.Click += new System.Windows.RoutedEventHandler(this.BBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
