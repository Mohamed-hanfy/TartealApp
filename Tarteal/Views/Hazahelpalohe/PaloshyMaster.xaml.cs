using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.Hazahelpalohe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaloshyMaster : ContentPage
    {
        LibVLC _libvlc;
        public PaloshyMaster(Quran has)
        {
            InitializeComponent();
            BindingContext = has;
            Core.Initialize();
            _libvlc = new LibVLC();
            var media = new Media(_libvlc, has.URL,
            FromType.FromLocation);
            myVideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myVideo.MediaPlayer.Play();
        }
    }
}