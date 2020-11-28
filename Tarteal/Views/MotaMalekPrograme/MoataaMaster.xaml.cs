using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.MotaMalekPrograme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoataaMaster : ContentPage
    {
        public MoataaMaster(Quran qaaaa)
        {
            BindingContext = qaaaa;
            InitializeComponent();
        }
    }
}