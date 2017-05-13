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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MX2T_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DonatePage : Page
    {
        private MobileBarcodeScanner _scanner;
        public DonatePage()
        {
            this.InitializeComponent();
        }

        SmartCardReader m_cardReader;

        private async void QR_Search_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _scanner = new MobileBarcodeScanner(this.Dispatcher);
            _scanner.UseCustomOverlay = false;
            _scanner.TopText = "Hold camera up to QR code";
            _scanner.BottomText = "Camera will automatically scan QR code";

            var result = await _scanner.Scan();
            ProcessScanResult(result);
        }
        private void ProcessScanResult(Result result)
        {

            MessageDialog myMessage = new MessageDialog("Συγχρονιστήκατε με τον αποδοχέα " + result.Text, "Συγχρονισμός");
            myMessage.ShowAsync();
        }

        private async void NFC_Search_Tapped(object sender, TappedRoutedEventArgs e)
        {


            var result = await _scanner.Scan();
            ProcessScanResult(result);
        }
    }
}
