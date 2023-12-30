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

        public void ChangeVolume(float volume)
        {
            if(waveOut != null)
            {
                waveOut.Volume = volume;
            }
        }

        public TimeSpan GetMaxDuration()
        {
            if (flacReader.CanRead)
            {
                return flacReader.TotalTime;
            }
            if (mp3FileReader.CanRead)
            {
                return mp3FileReader.TotalTime;
            }
            return TimeSpan.Zero;
        }

        public TimeSpan GetPosition()
        {
            if(flacReader.CanRead)
            {
                return flacReader.CurrentTime;
            }
            else if (mp3FileReader.CanRead)
            {
                return mp3FileReader.CurrentTime;
            }
            return TimeSpan.Zero;
        }

        public void SetPosition(TimeSpan position)
        {
            if (flacReader.CanRead)
            {
                flacReader.CurrentTime = position;
            }
            else if (mp3FileReader.CanRead)
            {
                mp3FileReader.CurrentTime = position;
            }
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
            if(mp3FileReader.CanRead)
                mp3FileReader.Dispose();
        }

        private void Flac_OnPlaybackStopped(object sender, EventArgs e)
        {
            waveOut.Dispose();
            if(flacReader.CanRead)
                flacReader.Dispose();
        }

        #endregion
    }
}
