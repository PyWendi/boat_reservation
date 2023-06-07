﻿#pragma checksum "..\..\Boat.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DEAAAED78B026A79EC88E1E15B77923F2E5C740B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using BoatReservation;
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


namespace BoatReservation {
    
    
    /// <summary>
    /// Boat
    /// </summary>
    public partial class Boat : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NavigationLabel;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeSection;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BoatSection;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PassengerSection;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReservationSection;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoutSection;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ValidFiltre;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FiltreBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Boat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
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
            System.Uri resourceLocater = new System.Uri("/BoatReservation;component/boat.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Boat.xaml"
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
            this.NavigationLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.HomeSection = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Boat.xaml"
            this.HomeSection.Click += new System.Windows.RoutedEventHandler(this.HomeSection_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BoatSection = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.PassengerSection = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Boat.xaml"
            this.PassengerSection.Click += new System.Windows.RoutedEventHandler(this.PassengerSection_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ReservationSection = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Boat.xaml"
            this.ReservationSection.Click += new System.Windows.RoutedEventHandler(this.ReservationSection_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LogoutSection = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Boat.xaml"
            this.LogoutSection.Click += new System.Windows.RoutedEventHandler(this.LogoutSection_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ValidFiltre = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Boat.xaml"
            this.ValidFiltre.Click += new System.Windows.RoutedEventHandler(this.ValidFiltre_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.FiltreBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\Boat.xaml"
            this.FiltreBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FiltreBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 31 "..\..\Boat.xaml"
            this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGrid_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 31 "..\..\Boat.xaml"
            this.dataGrid.Initialized += new System.EventHandler(this.dataGrid_Initialized);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Boat.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Boat.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.AddClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

