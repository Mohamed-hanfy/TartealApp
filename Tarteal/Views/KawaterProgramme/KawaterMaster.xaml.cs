using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.KawaterProgramme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KawaterMaster : ContentPage
    {
        public KawaterMaster(Quran qaaa)
        {
            BindingContext = qaaa;
            InitializeComponent();
        }
    }
}