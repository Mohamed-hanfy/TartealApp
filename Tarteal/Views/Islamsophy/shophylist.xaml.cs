using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Helper;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.Islamsophy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class shophylist : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public shophylist()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allPersons = await firebaseHelper.Islam();
            IslamS.ItemsSource = allPersons;
        }
        private void IslamS_ItemSelected_1(object sender, SelectedItemChangedEventArgs e)
        {
            var islam = e.SelectedItem as Quran;
            App.Current.MainPage.Navigation.PushModalAsync(new IslamMaster(islam));
        }
    }
}