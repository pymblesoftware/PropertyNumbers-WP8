﻿#pragma checksum "C:\Users\Regan\documents\visual studio 2012\Projects\PropertyNumbers\PropertyNumbers\CashOnCashPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "887E83B9B9529B8B02D792F0A88EC4D4"
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
    
    
    public partial class CashOnCashPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image DoneButton1;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button CalculateButton;
        
        internal System.Windows.Controls.TextBox CashflowTextBox;
        
        internal System.Windows.Controls.TextBox AmountTextBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PropertyNumbers;component/CashOnCashPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.DoneButton1 = ((System.Windows.Controls.Image)(this.FindName("DoneButton1")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.CalculateButton = ((System.Windows.Controls.Button)(this.FindName("CalculateButton")));
            this.CashflowTextBox = ((System.Windows.Controls.TextBox)(this.FindName("CashflowTextBox")));
            this.AmountTextBox = ((System.Windows.Controls.TextBox)(this.FindName("AmountTextBox")));
        }
    }
}

