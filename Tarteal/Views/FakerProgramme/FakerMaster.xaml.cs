using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.FakerProgramme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FakerMaster : ContentPage
    {
        public FakerMaster(Quran qaa)
        {
            BindingContext = qaa;
            InitializeComponent();
        }
    }
}