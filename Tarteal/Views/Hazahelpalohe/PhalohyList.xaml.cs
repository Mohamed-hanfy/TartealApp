using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Helper;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.Hazahelpalohe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhalohyList : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public PhalohyList()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allPersons = await firebaseHelper.Palohy();
            Hasah.ItemsSource = allPersons;
        }
        private void Hasah_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var has = e.SelectedItem as Quran;
            App.Current.MainPage.Navigation.PushAsync(new PaloshyMaster(has));
        }
    }
}