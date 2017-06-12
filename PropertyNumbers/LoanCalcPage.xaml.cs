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
    public partial class LoanCalcPage : PhoneApplicationPage
    {
        public LoanCalcPage()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            // NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();

//            MainPage mainpage = new MainPage();
//            this.Content = mainpage;
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            String InterestRateString = InterestRateTextBox.Text;
            String AmountString = AmountTextBox.Text;
            String TermString = TermTextBox.Text;

            float ratef = 0.0f;     //= (float)System.Convert.ToSingle(InterestRateTextBox.Text); 
            float valf = 0.0f;      //= (float)System.Convert.ToSingle( AmountTextBox.Text ); 
            float termf = 0.0f;     //= (float)System.Convert.ToSingle(TermTextBox.Text ); 

            if( InterestRateString.Length != 0 )
                ratef = (float)System.Convert.ToSingle(InterestRateString); 
            if( AmountString.Length != 0 )
                valf = (float)System.Convert.ToSingle(AmountString); 
            if( TermString.Length != 0)
                termf = (float)System.Convert.ToSingle(TermString); 

            double repayf = 0.0f;
        
            // Magic formula from the net somewhere..
        
            float divisor = 12.0f;
            int weekMonthSel = 0; //  RepaymentsSegmentControl.selectedSegmentIndex;
            
            if( WeeklyRadioButton.IsChecked.HasValue && (bool) WeeklyRadioButton.IsChecked )
                divisor = 12.0f;
            else
                divisor = 52.0f;
        
            //if( TypeSegmentControl.selectedSegmentIndex == 1 )
            if( PnIRadioButton.IsChecked.HasValue &&  PnIRadioButton.IsChecked.Value ) 
            {
    //            repayf = (ratef / divisor) * valf /  (1 - pow((1 +ratef), -(divisor * termf)) );
                double j = ratef / (divisor * 100.0f);
  //              float k = 1.0f - (powf( 1 + j, -(divisor * termf)) );
                double k = 1.0f -( Math.Pow(1 + j, -(divisor * termf)));
                repayf =  ( j  /  k ) * valf;
                // repayf /= 100.0f;
            }
            else
            {
                repayf = (ratef / divisor) * valf;
                repayf /= 100.0f;
            }

            repayf = Math.Round(repayf, 2);
        
            // msgStr = [NSString stringWithFormat:@"%.2f", repayf];
        

            MessageBox.Show("Result: " + repayf );
        }

        private void WeeklyRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // WeeklyRadioButton.
        }
    }
}