﻿#pragma checksum "C:\Users\Regan\documents\visual studio 2012\Projects\PropertyNumbers\PropertyNumbers\LoanCalcPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EB2ADA64AF37077B53703D0E3A2634FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PropertyNumbers {
    
    
    public partial class LoanCalcPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox AmountTextBox;
        
        internal System.Windows.Controls.TextBox InterestRateTextBox;
        
        internal System.Windows.Controls.TextBox TermTextBox;
        
        internal System.Windows.Controls.RadioButton WeeklyRadioButton;
        
        internal System.Windows.Controls.RadioButton MonthlyRadioButton;
        
        internal System.Windows.Controls.RadioButton InterestOnlyRadionButton;
        
        internal System.Windows.Controls.RadioButton PnIRadioButton;
        
        internal System.Windows.Controls.Button CalculateButton;
        
        internal System.Windows.Controls.Button DoneButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PropertyNumbers;component/LoanCalcPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.AmountTextBox = ((System.Windows.Controls.TextBox)(this.FindName("AmountTextBox")));
            this.InterestRateTextBox = ((System.Windows.Controls.TextBox)(this.FindName("InterestRateTextBox")));
            this.TermTextBox = ((System.Windows.Controls.TextBox)(this.FindName("TermTextBox")));
            this.WeeklyRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("WeeklyRadioButton")));
            this.MonthlyRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("MonthlyRadioButton")));
            this.InterestOnlyRadionButton = ((System.Windows.Controls.RadioButton)(this.FindName("InterestOnlyRadionButton")));
            this.PnIRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("PnIRadioButton")));
            this.CalculateButton = ((System.Windows.Controls.Button)(this.FindName("CalculateButton")));
            this.DoneButton = ((System.Windows.Controls.Button)(this.FindName("DoneButton")));
        }
    }
}

