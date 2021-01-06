using LibVLCSharp.Shared;
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
        LibVLC _libvlc;
        public MoataaMaster(Quran qaaaa)
        {
            BindingContext = qaaaa;
            InitializeComponent();
            Core.Initialize();
            _libvlc = new LibVLC();
            var media = new Media(_libvlc, qaaaa.URL,
            FromType.FromLocation);
            myVideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myVideo.MediaPlayer.Play();
        }
    }
}