using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary_DAL.Entities;
using MusicLibrary_BLL.Models;
using static MusicLibrary_BLL.Services.UserSerivce;
using WMPLib;
using System.Media;
using NAudio.Wave;

namespace MusicLibrary_DAL
{
    internal class Program
    {
        static IWavePlayer waveOut;
        static Mp3FileReader mp3FileReader;
        public static void Main(string[] args)
        {
            
            waveOut = new WaveOut();
            mp3FileReader = new Mp3FileReader("D:\\OneDrive - nhg.vn\\CNTT_HongBang\\HK5\\.NET\\Project\\Source\\Playground\\Music\\13_Imaginaerum.mp3");
            waveOut.Init(mp3FileReader);
            waveOut.Play();
            waveOut.PlaybackStopped += OnPlaybackStopped;
        }

        private static void OnPlaybackStopped(object sender, EventArgs e)
        {
            waveOut.Dispose();
            mp3FileReader.Dispose();
        }
    }
}
