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
    public partial class DepreciationPage : PhoneApplicationPage
    {
        public DepreciationPage()
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                    // Calculate result
            // NSMutableString *msgStr = [[NSMutableString alloc] initWithString:@""];

            String AmountString = AmountTextBox.Text;
            float years = (float) YearsSlider.Value;
            float cost = 0.0f; // (float)System.Convert.ToSingle(AmountTextBox.Text);
            
            if( AmountString.Length != 0 )
                cost = (float)System.Convert.ToSingle(AmountString);

            float remaining = cost;
            String resultStr = "";

            //if( [type selectedSegmentIndex] == 0 )
            if( DeminishingValueRadioButton.IsChecked.HasValue && DeminishingValueRadioButton.IsChecked.Value )
            {
                float numerator;
                // Deminishing value
            
                // Get user preference
                //NSUserDefaults *defaults = 0.0f; // [NSUserDefaults standardUserDefaults];
                bool enabled = false; // [defaults boolForKey:@"pre_2006"];
                
            
                if( enabled)
                    numerator = 200.0f;
                else
                    numerator = 150.0f;
            
                for( int j = 0; j < years; j++ )
                {
                    float deprec = remaining * ((numerator /100.0f) / years);
                    remaining -= deprec;
                    // [msgStr appendFormat:@"%d ..... %.2f \n", j + 1, deprec ];
                    resultStr += (j + 1) + "....." + Math.Round( deprec, 2) + "\n";
                }
            }
            else
            {
                // Prime Cost
                for( int i = 0; (i< years); i++ )
                {
                    // [msgStr appendFormat:@"%d ..... %.2f \n", i + 1, (cost / years) ];
                    resultStr += (i + 1) + "....." + Math.Round( (cost / years) , 2) + "\n";
                }            
            }
        

            MessageBox.Show("Result: \n" + resultStr );
        }

        private void YearsSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (YearsSlider != null )
            {
                float years = (float)YearsSlider.Value;
                YearsText.Text = "" + Math.Floor(years);
            }
        }
    }
}