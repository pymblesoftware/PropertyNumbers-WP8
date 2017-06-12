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
    public partial class CashOnCashPage : PhoneApplicationPage
    {
        public CashOnCashPage()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();

            // NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));

            // MainPage mainPage = new MainPage();
            // this.Content = mainPage;
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            String CashflowString = CashflowTextBox.Text;
            String AmountString = AmountTextBox.Text;
            // Calculate
            double result = 0.0f;
            if( CashflowString.Length != 0 && AmountString.Length != 0 )
                result = System.Convert.ToSingle(CashflowTextBox.Text) / System.Convert.ToSingle(AmountTextBox.Text); 
            result *= Math.Round( 100.0, 2 );
        
            MessageBox.Show("Result:\n" + result + "%" );
        }
    }
}