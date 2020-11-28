using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "MediaElement_Experimental" });
            InitializeComponent();
           
            MainPage = new TabbedPage1();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
