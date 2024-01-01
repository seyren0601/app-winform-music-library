using NAudio.Wave;
using NAudio.Flac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary_BLL.Models;
using System.Linq;
using WinRT;

namespace MusicLibrary_BLL.Services
{
    public class MusicPlayer
    {
        public enum RepeatMode
        {
            RepeatOne,
            RepeatList,
            Default
        }
        // Universal reader for audio files
        // CAUTION: this will cause wrong file duration reading if file is not .mp3 (only tested on .mp3 and .flac)
        public AudioFileReader FileReader;
        public IWavePlayer? waveOut = null;
        static MusicPlayer Instance;
        public MusicList PlayList { get; set; } = new MusicList();
        public int NowPlayingIndex{ get; set; }
        public RepeatMode Repeat { get; set; } = RepeatMode.RepeatList;
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

        public void PlayFile(MusicFile file)
        {
            FileReader = new AudioFileReader(file.FilePath);
            if(waveOut != null)
            {
                waveOut.Dispose();
            }
            waveOut = new WaveOut();
            waveOut.Init(FileReader);
            waveOut.Play();
        }

        public void PlayFile(FileInfo file)
        {
            FileReader = new AudioFileReader(file.FullName);
            if (waveOut != null)
            {
                waveOut.Dispose();
            }
            waveOut = new WaveOut();
            waveOut.Init(FileReader);
            waveOut.Play();
        }

        public void Stop()
        {
            if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
                waveOut.Stop();
        }
        #endregion

        public void OnPlaybackStopped()
        {
            switch (Repeat)
            {
                case RepeatMode.RepeatList:
                    if (NowPlayingIndex == PlayList.Count - 1)
                    {
                        NowPlayingIndex = 0;
                    }
                    else
                    {
                        NowPlayingIndex += 1;
                    }
                    PlayFile(PlayList[NowPlayingIndex]);
                    Console.WriteLine("In repeat list");
                    break;
                case RepeatMode.Default:
                    waveOut!.Stop();
                    Console.WriteLine("In no repeat");
                    break;
                default:
                    Console.WriteLine("In default");
                    break;
            }
            Console.WriteLine("out of switch");
        }
    }
}
