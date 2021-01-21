using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Helper;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.MotaMalekPrograme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mota : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public Mota()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allPersons = await firebaseHelper.motaa();
            mota.ItemsSource = allPersons;
        }
        private void mota_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var qaaaa = e.SelectedItem as Quran;
            App.Current.MainPage.Navigation.PushModalAsync(new MoataaMaster(qaaaa));
        }
    }
}