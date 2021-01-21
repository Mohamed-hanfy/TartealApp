using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Views.Hazahelpalohe;
using Tarteal.Views.Islamsophy;
using Tarteal.Views.Maher;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Qari : ContentPage
    {
        public Qari()
        {
            InitializeComponent();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {

            }
            else
            {
                DisplayAlert("خطأ", "يرجي الاتصال بالانترنت للوصول الي المحتوي", "موافق");
            }

        }

        private void islamsophy_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new shophylist());
        }

        private void Hasah_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new PhalohyList());
        }

        private void maher_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new MaherList());
        }

        private async void tawassl_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://m.me/tartealapp", BrowserLaunchMode.SystemPreferred);
        }
      
    }
}