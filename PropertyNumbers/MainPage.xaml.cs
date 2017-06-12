using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PropertyNumbers.Resources;

using Microsoft.Phone.Tasks;

namespace PropertyNumbers
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void LoanCalcButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/LoanCalcPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void DepreciationButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DepreciationPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ValuationButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ValuationPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void DoublingButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DoublingPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void CapRateButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CapitalRatePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void CashOnCashRateButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CashOnCashPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BreakEvenButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BreakEvenPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void InternalRateofReturnButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/IRRPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Feedback_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask task = new EmailComposeTask
            {
                To = "info@pymblesoftware.com",
                Subject = "Feedback on property numbers"
            };

            task.Show();
        }

        private void TellSomeoneButton_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask task = new EmailComposeTask
            {
               
                Subject = "Feedback on property numbers",
                Body = "Hi there, \n     I found an app you might be interested in called Property Numbers"
            };

            task.Show();
        }


        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}