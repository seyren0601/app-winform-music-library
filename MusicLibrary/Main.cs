using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicLibrary_BLL.Services;
using NAudio.Gui;
using NAudio.Wave;

namespace MusicLibrary
{
    public partial class Main : Form
    {
        public string RootDirectory = @"D:\OneDrive - nhg.vn\CNTT_HongBang\HK5\.NET\Project\Source\Music";
        TreeViewService _treeViewSerivce = TreeViewService.GetInstance();
        MusicPlayer mp = MusicPlayer.GetInstance();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _treeViewSerivce.BindDirectoryToTreeView(trvDirectories, RootDirectory);
            mp.ChangeVolume(volumeSlider1.Volume);
        }

        #region Events
        // Buttons click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void trvDirectories_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Read and Play media (mp3/flac)
            mp.PlayMusic(e.Node.Tag.ToString());

            // Set seekbar max value
            TimeSpan maxSeconds = mp.GetMaxDuration();
            trbSeeker.Maximum = maxSeconds.Minutes * 60 + maxSeconds.Seconds;
            lblSeekMax.Text = string.Format("{0:D2}:{1:D2}", maxSeconds.Minutes, maxSeconds.Seconds);

            // Start timer to update seekbar along with media playback
            tmrSeekBar.Start();
        }

        private void volumeSlider1_VolumeChanged(object sender, EventArgs e)
        {
            VolumeSlider slider = (VolumeSlider)sender;
            mp.ChangeVolume(slider.Volume);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (mp.waveOut != null)
            {
                mp.waveOut.Play();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (mp.waveOut != null && mp.waveOut.PlaybackState == PlaybackState.Playing)
            {
                mp.waveOut.Pause();
            }
        }

        private void tmrSeekBar_Tick(object sender, EventArgs e)
        {

            if (mp.waveOut != null && mp.waveOut.PlaybackState == PlaybackState.Playing)
            {
                TimeSpan currentTime = mp.GetPosition();
                trbSeeker.Value = (int)currentTime.TotalSeconds;
                lblSeekMin.Text = string.Format("{0:D2}:{1:D2}", currentTime.Minutes, currentTime.Seconds);
            }
        }

        private void trbSeeker_MouseDown(object sender, MouseEventArgs e)
        {
            if (mp.waveOut != null)
            {
                mp.waveOut.Pause();
            }
        }

        private void trbSeeker_MouseUp(object sender, MouseEventArgs e)
        {
            if(mp.waveOut != null)
            {
                TimeSpan value = new TimeSpan(0, 0, trbSeeker.Value);
                mp.SetPosition(value);
                mp.waveOut.Play();
            }
        }
    }
}
