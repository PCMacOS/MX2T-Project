using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MX2T_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SetAmountPage : Page
    {
        
        public SetAmountPage()
        {
            this.InitializeComponent();
            Money.Text = "0,00"+ "€";
        }

        private void Tap05(object sender, TappedRoutedEventArgs e)
        {
            Money.Text = "0,50" + "€";
            Data.moneypick = 0.5;
        }

        private void Tap1(object sender, TappedRoutedEventArgs e)
        {
            Money.Text = "1,00" + "€";
            Data.moneypick = 1;
        }

        private void Tap2(object sender, TappedRoutedEventArgs e)
        {
            Money.Text = "2,00" + "€";
            Data.moneypick = 2;
        }

        private void Tap3(object sender, TappedRoutedEventArgs e)
        {
            Money.Text = "3,00" + "€";
            Data.moneypick = 3;
        }

        private void Tap5(object sender, TappedRoutedEventArgs e)
        {
            Money.Text = "5,00" + "€";
            Data.moneypick = 5;
        }

        private void Tap10(object sender, TappedRoutedEventArgs e)
        {
            Money.Text = "10,00" + "€";
            Data.moneypick = 10;
        }

        private void OKMoney(object sender, TappedRoutedEventArgs e)
        {

            string amount = Data.moneypick.ToString("####0.00");
            MessageDialog myMessage = new MessageDialog("Δωρίσατε επιτυχώς " + amount + " ευρώ!", "Επιτυχία");
            myMessage.ShowAsync();
            Data.History = true;
            Frame.Navigate(typeof(MainPage));
            //Frame.Navigate(typeof(HistoryPage));
        }

        private void CancelMoney(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
