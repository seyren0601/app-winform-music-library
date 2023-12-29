using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_BLL.Services
{
    public class MusicPlayer
    {
        Mp3FileReader mp3FileReader;
        private IWavePlayer? waveOut = null;
        public MusicPlayer() { }

        public void PlayMp3(string path)
        {
            mp3FileReader = new Mp3FileReader(path);
            waveOut = new WaveOut();
            waveOut.Init(mp3FileReader);
            waveOut.Play();
            waveOut.PlaybackStopped += OnPlaybackStopped;
        }

        public void StopMp3()
        {
            if(waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
                waveOut.Stop();
        }

        private void OnPlaybackStopped(object sender, EventArgs e)
        {
            waveOut.Dispose();
            mp3FileReader.Dispose();
        }
    }
}
