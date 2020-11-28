﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Helper;
using Tarteal.Model;
using Tarteal.Views.Azhurfatwa;
using Tarteal.Views.FakerProgramme;
using Tarteal.Views.KawaterProgramme;
using Tarteal.Views.MotaMalekPrograme;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public HomePage()
        {
            InitializeComponent();
        }

        

        private void Azhur_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new Fatwa());
        }

        private void Faker_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new Faker());
        }

        private void Kawater_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new Kawater());
        }

        private void malek_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new Mota());
        }
    }
}