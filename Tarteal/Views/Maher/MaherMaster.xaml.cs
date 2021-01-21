using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.Maher
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaherMaster : ContentPage
    {
        LibVLC _libvlc;
        public MaherMaster(Quran mah)
        {
            InitializeComponent();
            BindingContext = mah;
            Core.Initialize();
            _libvlc = new LibVLC();
            var media = new Media(_libvlc, mah.URL,
            FromType.FromLocation);
            myVideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myVideo.MediaPlayer.Play();
        }
    }
}