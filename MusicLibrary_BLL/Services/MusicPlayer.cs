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
        public IWavePlayer? waveOut = null;
        static MusicPlayer Instance;
        public static MusicPlayer GetInstance()
        {
            if(Instance == null) return Instance = new MusicPlayer();
            else return Instance;
        }

        #region Controls
        public void PlayMusic(string path)
        {
            FileInfo fileinfo = new FileInfo(path);
            Mp3_Play(path);
        }

        public void ChangeVolume(float volume)
        {
            if(waveOut != null)
            {
                waveOut.Volume = volume;
            }
        }

        public TimeSpan GetMaxDuration()
        {
            return mp3FileReader.TotalTime;
        }

        public TimeSpan GetPosition()
        {
            
            return mp3FileReader.CurrentTime;
        }

        public void SetPosition(TimeSpan position)
        {
            
            mp3FileReader.CurrentTime = position;
        }

        #endregion

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

        #region Delegates
        private void Mp3_OnPlaybackStopped(object sender, EventArgs e)
        {
            waveOut.Dispose();
            mp3FileReader.Dispose();
        }

        private void Flac_OnPlaybackStopped(object sender, EventArgs e)
        {
            waveOut.Dispose();
        }

        #endregion
    }
}
