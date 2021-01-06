using LibVLCSharp.Shared;
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
        LibVLC _libvlc;
        public KawaterMaster(Quran qaaa)
        {
            BindingContext = qaaa;
            InitializeComponent();
            Core.Initialize();
            _libvlc = new LibVLC();
            var media = new Media(_libvlc, qaaa.URL,
            FromType.FromLocation);
            myVideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myVideo.MediaPlayer.Play();
        }
    }
}