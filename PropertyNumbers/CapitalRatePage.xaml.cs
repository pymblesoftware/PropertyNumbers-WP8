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
    public partial class CapitalRatePage : PhoneApplicationPage
    {
        public CapitalRatePage()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();

            // NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));

            //MainPage mainPage = new MainPage();
            //this.Content = mainPage;
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double result = 0.0;
            float nettIn = 0.0f, cost = 0.0f;

            String IncomeString = IncomeTextBox.Text;
            String ValueString = ValueTextBox.Text;

            if( IncomeString.Length != 0 )
                nettIn = System.Convert.ToSingle( IncomeTextBox.Text ); 

            if( ValueString.Length != 0 )
                cost = System.Convert.ToSingle( ValueTextBox.Text ); 
        
            if( cost == 0 )
                result = 0;
            else
                result = Math.Round( (nettIn / cost) * 100, 2 );
        

            MessageBox.Show("Result:\n" + result + "%" );
        }
    }
}