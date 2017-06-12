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
    public partial class ValuationPage : PhoneApplicationPage
    {
        public ValuationPage()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();

            // NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));

            // MainPage mainPage = new MainPage();
            //this.Content = mainPage;

        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            
            double result = 0.0f;
            String AmountString = AmountTextBox.Text;
            String RequiredRateString = RequiredRateTextBox.Text;
            float income = 0.0f; // System.Convert.ToSingle(AmountTextBox.Text); 
            float requireRate = 0.0f; // System.Convert.ToSingle(RequiredRateTextBox.Text);

            if( AmountString.Length != 0 )
                income = System.Convert.ToSingle(AmountString);

            if( RequiredRateString.Length != 0 )
                requireRate = System.Convert.ToSingle(RequiredRateString); 


            if( requireRate != 0.0f )
                result = Math.Round( income / (requireRate / 100.0f), 2);
        
            // NSString *msgStr = [[NSString alloc] initWithFormat:@"%.2f", result ];

            MessageBox.Show("Result:\n " + result );
        }
    }
}