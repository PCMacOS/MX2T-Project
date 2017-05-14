using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI;//For titlebar
using Windows.UI.ViewManagement;//For titlebar


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MX2T_Project
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }


        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            SetTitleBarBackground();
            if (Data.moneypick!=0) MyFrame.Navigate(typeof(HistoryPage));
            else MyFrame.Navigate(typeof(DonatePage));

        }
  

        private void SetTitleBarBackground()
        {
            // Get the instance of the Title Bar
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;

            // Set the color of the Title Bar content
            titleBar.BackgroundColor = Color.FromArgb(1,74,20,140);
            titleBar.ForegroundColor = Colors.White;

            // Set the color of the Title Bar buttons
            titleBar.ButtonBackgroundColor = Color.FromArgb(1, 74, 20, 140);
            titleBar.ButtonForegroundColor = Colors.White;
        }

        private void GoToDonate(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(DonatePage));
        }

        private void GoToHistory(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(HistoryPage));
        }

        private void GoToDashboard(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(DashboardPage));
        }
    }
}
