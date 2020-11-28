using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Helper;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.FakerProgramme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Faker : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public Faker()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allPersons = await firebaseHelper.Fakerr();
            Fakeer.ItemsSource = allPersons;
        }
        private void Fakeer_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           var qaa = e.SelectedItem as Quran;
            App.Current.MainPage.Navigation.PushAsync(new FakerMaster(qaa));
        }
    }
}