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
        AudioFileReader FileReader;
        public IWavePlayer? waveOut = null;
        static MusicPlayer Instance;
        public static MusicPlayer GetInstance()
        {
            if(Instance == null) return Instance = new MusicPlayer();
            else return Instance;
        }

        #region Controls
        public void ChangeVolume(float volume)
        {
            if(waveOut != null)
            {
                waveOut.Volume = volume;
            }
            else
            {
                waveOut = new WaveOut();
                waveOut.Volume = volume;
            }
        }

        public TimeSpan GetMaxDuration()
        {
            return FileReader.TotalTime;
        }

        public TimeSpan GetPosition()
        {
            
            return FileReader.CurrentTime;
        }

        public void SetPosition(TimeSpan position)
        {
            
            FileReader.CurrentTime = position;
        }

        public void PlayFile(FileInfo file)
        {
            FileReader = new AudioFileReader(file.FullName);
            if(waveOut != null)
            {
                waveOut.Dispose();
            }
            waveOut = new WaveOut();
            waveOut.Init(FileReader);
            waveOut.Play();
            //waveOut.PlaybackStopped += OnPlaybackStopped;
        }

        public void Stop()
        {
            if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
                waveOut.Stop();
        }

        #endregion

        #region Delegates
        private void OnPlaybackStopped(object sender, EventArgs e)
        {
            Console.WriteLine("asdfa");
            waveOut.Dispose();
            FileReader.Dispose();
        }

        #endregion
    }
}
