using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Helper;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.Maher
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaherList : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public MaherList()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allPersons = await firebaseHelper.Maherel();

            Maherelm.ItemsSource = allPersons;
        }
        
        private void Maherelm_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var mah=e.SelectedItem as Quran;
            App.Current.MainPage.Navigation.PushModalAsync(new MaherMaster(mah));
        }
    }
}