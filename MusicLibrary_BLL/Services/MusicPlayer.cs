using NAudio.Wave;
using NAudio.Flac;
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
        FlacReader flacReader;
        private IWavePlayer? waveOut = null;
        static MusicPlayer Instance;
        public static MusicPlayer GetInstance()
        {
            if(Instance == null) return Instance = new MusicPlayer();
            else return Instance;
        }

        public void PlayMusic(string path)
        {
            FileInfo fileinfo = new FileInfo(path);
            switch (fileinfo.Extension)
            {
                case ".mp3":
                    Mp3_Play(path);
                    break;
                case ".flac":
                    Flac_Play(path);
                    break;
            }
        }

        #region Mp3
        private void Mp3_Play(string path)
        {
            if(waveOut != null)
            {
                mp3FileReader.Dispose();
                mp3FileReader = new Mp3FileReader(path);
                waveOut.Init(mp3FileReader);
                waveOut.Play();
            }
            else
            {
                mp3FileReader = new Mp3FileReader(path);
                waveOut = new WaveOut();
                waveOut.Init(mp3FileReader);
                waveOut.Play();
            }
            waveOut.PlaybackStopped += Mp3_OnPlaybackStopped;
        }

        private void Mp3_Stop()
        {
            if(waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
                waveOut.Stop();
        }
        #endregion

        #region Flac
        private void Flac_Play(string path)
        {
            if (waveOut != null)
            {
                flacReader.Dispose();
                flacReader = new FlacReader(path);
                waveOut.Init(flacReader);
                waveOut.Play();
            }
            else
            {
                flacReader = new FlacReader(path);
                waveOut = new WaveOut();
                waveOut.Init(flacReader);
                waveOut.Play();
            }
            waveOut.PlaybackStopped += Flac_OnPlaybackStopped;
        }

        private void Flac_Stop()
        {
            if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Stop();
            }
        }

        #endregion

        #region Delegates
        private void Mp3_OnPlaybackStopped(object sender, EventArgs e)
        {
            waveOut.Dispose();
            waveOut = null;
            mp3FileReader.Dispose();
        }

        private void Flac_OnPlaybackStopped(object sender, EventArgs e)
        {
            waveOut.Dispose();
            waveOut = null;
            flacReader.Dispose();
        }

        #endregion
    }
}
