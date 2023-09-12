using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;

namespace MobileQR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NextPage : ContentPage
    {
        public NextPage(string qrCodeText)
        {
            InitializeComponent();
            qrCodeId.Text = qrCodeText;
            var realText = Encoding.UTF8.GetString(Convert.FromBase64String(qrCodeText)).Trim();
            qrCodeName.Text = realText;
            Match match = Regex.Match(realText, @"^(.*?)(?:\s+(\d+))?$");
            qrMatch.Text = match.Success.ToString();
            if (match.Success)
            {
                qrCodeName.Text = match.Groups[1].Value.Trim();
                qrCodeId.Text = match.Groups[2].Value.Trim();
            }

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Add_Model(object sender, EventArgs e)
        {
            DisplayAlert("Command Add", $"Model :{qrCodeName.Text} Add!", "Ok");
        }

        private void Remove_Model(object sender, EventArgs e)
        {
            DisplayAlert("Command Remove", $"Model :{qrCodeName.Text} Remove from DataBase!", "Ok");
        }
    }
}