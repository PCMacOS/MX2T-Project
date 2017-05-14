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
using Windows.UI.Popups;
using ZXing;
using ZXing.Mobile;
using Pcsc;
using Windows.Devices.SmartCards;
using System.Threading.Tasks;
using Pcsc.Common;
using System.Diagnostics;
using System.Threading;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MX2T_Project
{
    public sealed partial class DonatePage : Page
    {
        bool ScanOK = false;
        private MobileBarcodeScanner _scanner;
        public DonatePage()

        {
            this.InitializeComponent();
        }
        public static bool IsSelected { get; internal set; }

        SmartCardReader m_cardReader;

        private async void QR_Search_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
            _scanner = new MobileBarcodeScanner(this.Dispatcher);
            _scanner.UseCustomOverlay = false;
            _scanner.TopText = "Hold camera up to QR code";
            _scanner.BottomText = "Camera will automatically scan QR code";

            var result = await _scanner.Scan();
            ProcessScanResult(sender,result);
        }

        private void ProcessScanResult(object sender, Result result)
        {
            MessageDialog myMessage = new MessageDialog("Συνδεθήκατε με τον αποδοχέα " + result.Text + ".", "Σύνδεση επιτυχής!");
            myMessage.Commands.Add(new UICommand(
        "OK",
        new UICommandInvokedHandler(this.CommandInvokedHandler)));

            myMessage.ShowAsync();
            
            //ScanOK = true;
        }

        private void CommandInvokedHandler(IUICommand command)
        {
            var rootFrame = new Frame();

            rootFrame.Navigate(typeof(SetAmountPage));

            Window.Current.Content = rootFrame;

            Window.Current.Activate();
        }

        private async void NFC_Search_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var result = await _scanner.Scan();
            ProcessScanResult(sender, result);
        }


    }
}
