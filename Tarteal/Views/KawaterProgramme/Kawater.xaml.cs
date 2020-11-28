using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Helper;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.KawaterProgramme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kawater : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public Kawater()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allPersons = await firebaseHelper.Kawaterr();
            kawater.ItemsSource = allPersons;
        }
        private void Fakee_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var qaaa = e.SelectedItem as Quran;
            App.Current.MainPage.Navigation.PushAsync(new KawaterMaster(qaaa));
        }
    }
}