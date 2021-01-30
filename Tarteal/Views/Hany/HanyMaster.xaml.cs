using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.Hany
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HanyMaster : ContentPage
    {
        LibVLC _libvlc;
        public HanyMaster(Quran HHany)
        {
            InitializeComponent();
            BindingContext = HHany;
            Core.Initialize();
            _libvlc = new LibVLC();
            var media = new Media(_libvlc, HHany.URL,
            FromType.FromLocation);
            myVideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myVideo.MediaPlayer.Play();
        }
    }
}