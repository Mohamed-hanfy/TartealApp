using LibVLCSharp.Shared;
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
        LibVLC _libvlc;
        public FakerMaster(Quran qaa)
        {
            BindingContext = qaa;
            InitializeComponent();
            Core.Initialize();
            _libvlc = new LibVLC();
            var media = new Media(_libvlc, qaa.URL,
            FromType.FromLocation);
            myVideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myVideo.MediaPlayer.Play();
        }
    }
}