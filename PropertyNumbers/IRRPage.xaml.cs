using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Input;

namespace PropertyNumbers
{
    public partial class IRRPage : PhoneApplicationPage
    {
        float[] values;
        int currIndex;

        public IRRPage()
        {
            InitializeComponent();
            //AmountTextBox.KeyUp += new KeyEventHandler(AmountTextBox_KeyUp); 
            AmountTextBox.KeyUp += AmountTextBox_KeyUp;
            currIndex = 0;
            values = new float[1000];
        }

        void AmountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int val = System.Convert.ToInt16( YearNum.Text );
                val++;
                YearNum.Text = "" + val;
            }
            // throw new NotImplementedException();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            // NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();

        }



        private float calcIRR()
        {              
            float result = 0.0f;
            bool done = false;

            int arrayCount = currIndex + 1; // [npvValues count];
    
            for( float f = 0.0f; f < 100.0f && !done; f += 0.01f  )
            {
                double test;
                test = 0.0f;
                for( int yr = 0; yr < arrayCount; yr++ )
                {
                    // NSNumber *entered = [npvValues objectAtIndex:yr];
                    double entered = values[yr];

                    double amount = (1.0f + (f / 100.0f));
                    double power = -yr;
                    test += entered *  Math.Pow( amount, power );
                    
                }
                if( test < 1.0 )
                {
                    done = true;
                    result = f;
                }
            }
    
            return result;
        }


        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Reult:\n" + Math.Round( calcIRR() , 2) + "%" );
           
        }

        private void AmountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        // Next button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int val = System.Convert.ToInt16(YearNum.Text);


            String AmountString = AmountTextBox.Text;

            if (AmountString.Length != 0)
            {
                val++;
                YearNum.Text = "" + val;
                values[currIndex] = System.Convert.ToSingle(AmountString);
                currIndex++;
            }
        }

  
    }
}