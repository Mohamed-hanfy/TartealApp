using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarteal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarteal.Views.Islamsophy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IslamMaster : ContentPage
    {
        LibVLC _libvlc;
        public IslamMaster(Quran islam)
        {
            InitializeComponent();
            BindingContext = islam;
            Core.Initialize();
            _libvlc = new LibVLC();
            var media = new Media(_libvlc, islam.URL,
            FromType.FromLocation);
            myVideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myVideo.MediaPlayer.Play();
        }
    }
}