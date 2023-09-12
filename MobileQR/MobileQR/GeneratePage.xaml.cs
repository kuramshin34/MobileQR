using Android.Graphics;
using System.Drawing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using ZXing;
using ZXing.QrCode;
using ZXing.Net.Mobile.Forms;
using ZXing.Common;
using ZXing.QrCode.Internal;
using Android.Views;
using Android.Media;
using Android;
using static Android.Resource;
using Android.Content;

namespace MobileQR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneratePage : ContentPage
    {
        public GeneratePage()
        {
            InitializeComponent();
            
        }
        
        private void Generate_Clicked(object sender, EventArgs e)
        {
           
        }

        private void Generate_Changed(object sender, TextChangedEventArgs e)
        {
            if ((sender as Editor).Text  == "")
            {
                return;
            }
            QRCodeView.BarcodeValue = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(GenerateName.Text));
        }
    }
  
}

