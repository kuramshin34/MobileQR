using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace MobileQR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();         
        }

        

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var scan = new ZXingScannerPage();
            await Navigation.PushModalAsync(scan);

            scan.OnScanResult += (result) =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopModalAsync();
                    //await DisplayAlert("QRCODE", $" {result.Text}", "Ok");
                    await Navigation.PushModalAsync(new NextPage(result.Text));
                });

                
            };

        }

        private async void GenerateQR_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GeneratePage());
        }
    }
}
