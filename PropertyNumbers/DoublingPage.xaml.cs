using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PropertyNumbers
{
    public partial class DoublingPage : PhoneApplicationPage
    {
        public DoublingPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String RateString = AmountTextBox.Text;
            float rate = 0.0f; 
            
            if( RateString.Length != 0)
                rate = System.Convert.ToSingle(RateString);
            double result;
        
            if( rate != 0.0f )
                result = Math.Round(72.0f / rate, 2);
            else
                result = 0.0f;
        

            MessageBox.Show("Result:\n" + result + " years" );
        }
    }
}