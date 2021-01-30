using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Helper;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.Hany
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hanyyy : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public Hanyyy()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allPersons = await firebaseHelper.Hanyel();
            Hanylist.ItemsSource = allPersons;
        }
        private void Hanylist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var HHany = e.SelectedItem as Quran;
            App.Current.MainPage.Navigation.PushModalAsync(new HanyMaster(HHany));
        }
    }
}