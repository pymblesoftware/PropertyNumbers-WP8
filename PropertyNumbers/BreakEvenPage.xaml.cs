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
    public partial class BreakEvenPage : PhoneApplicationPage
    {
        public BreakEvenPage()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if( NavigationService.CanGoBack )
                NavigationService.GoBack();
            // NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
            //MainPage mainPage = new MainPage();
            //this.Content = mainPage;
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {

            
            // Calculate

            double debtServ = 0.0f, OpEx = 0.0f, income = 0.0f, result = 0.0f;

            String AmountString = AmountTextBox.Text;
            String ExpensesString = ExpensesTextBox.Text;
            String IncomeString = IncomeTextBox.Text;

            if( AmountString.Length != 0 )
                debtServ = System.Convert.ToSingle( AmountTextBox.Text );    // [[debtServiceTextField text] floatValue];
            if( ExpensesString.Length != 0 )
                OpEx = System.Convert.ToSingle(ExpensesTextBox.Text );        // [[expensesTextField text] floatValue];

            if( IncomeString.Length != 0 )
                income = System.Convert.ToSingle( IncomeTextBox.Text );      // [[incomeTextField text] floatValue];
        
            if( income == 0.0f )
                result = 0.0f;
            else
                result = Math.Round( ((debtServ + OpEx) / income) * 100.0f, 2);
        
            // Display
            //NSString *msgStr = [[NSString alloc] initWithFormat:@"%.2f%%",result ];
        
            //UIAlertView * alert = [[UIAlertView alloc] initWithTitle:titleStr message:msgStr delegate:nil cancelButtonTitle:dismissStr otherButtonTitles:nil, nil];
            //[alert show];


            MessageBox.Show("Result: \n" + result);
        }
    }
}