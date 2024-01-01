using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicLibrary_BLL.Models;
using MusicLibrary_BLL.Services;
using NAudio.Gui;
using NAudio.Wave;
using static MusicLibrary_BLL.Services.MusicPlayer;
using Windows.Media.Playlists;

namespace MusicLibrary
{
    public partial class Main : Form
    {
        public string RootDirectory = "..\\..\\..\\Music";
        TreeViewService _treeViewSerivce = TreeViewService.GetInstance();
        MusicPlayer mp = MusicPlayer.GetInstance();
        MediaTag mt = MediaTag.GetInstance();
        MusicList NowPlaying = MusicList.GetInstance();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _treeViewSerivce.BindDirectoryToTreeView(trvDirectories, RootDirectory);
            mp.ChangeVolume(volumeSlider1.Volume);
            grdNowPlaying.DataSource = NowPlaying.FileList;
            grdNowPlaying.Columns[0].Visible = false;
            grdNowPlaying.Columns[1].Visible = false;
        }

        #region Events
        // Buttons click
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trvDirectories_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is MusicFile)
            {
                MusicFile file = e.Node.Tag as MusicFile;
                // Read and Play media (mp3/flac)
                mp.PlayFile(file);

                // Clear current playlist
                NowPlaying.FileList.Clear();

                // Add file to playlist
                NowPlaying.Add(file);
                mp.PlayList = NowPlaying;

                SetupPlayFile(file);
            }
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            mp.Stop();
            trbSeeker.Value = 0;
            lblSeekMin.Text = "0:00";
            mp.SetPosition(TimeSpan.Zero);
        }

        // Timer tick
        private void tmrSeekBar_Tick(object sender, EventArgs e)
        {
            if (mp.waveOut != null && mp.waveOut.PlaybackState == PlaybackState.Playing)
            {
                TimeSpan currentTime = mp.GetPosition();
                if(currentTime < mp.GetMaxDuration())
                {
                    trbSeeker.Value = (int)Math.Floor((double)currentTime.TotalSeconds);
                    lblSeekMin.Text = string.Format("{0:D2}:{1:D2}", currentTime.Minutes, currentTime.Seconds);
                }
            }

            // Placeholder for playback stopped event (can't implement normally)
            if (mp.FileReader.CurrentTime != TimeSpan.Zero && mp.waveOut.PlaybackState == PlaybackState.Stopped)
            {
                mp.OnPlaybackStopped();
                SetupPlayFile(NowPlaying[mp.NowPlayingIndex]);
            }
        }
        #endregion



        private void volumeSlider1_VolumeChanged(object sender, EventArgs e)
        {
            VolumeSlider slider = (VolumeSlider)sender;
            mp.ChangeVolume(slider.Volume);
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
            if (mp.waveOut != null)
            {
                TimeSpan value = new TimeSpan(0, 0, trbSeeker.Value);
                mp.SetPosition(value);
                mp.waveOut.Play();
            }
        }

        private void ctxTreeNode_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == ctxTreeNode.Items[0])
            {
                if (trvDirectories.SelectedNode.Tag is MusicFile)
                {
                    MusicFile file = trvDirectories.SelectedNode.Tag as MusicFile;
                    NowPlaying.Add(file);
                    mp.PlayList = NowPlaying;
                    if (mp.PlayList.Count == 1)
                    {
                        mp.PlayFile(file);
                        SetupPlayFile(file);
                    }
                }
                else
                {
                    TreeNode root = trvDirectories.SelectedNode;
                    _treeViewSerivce.AddFolderToPlaylist(root, NowPlaying);
                    MusicFile file = NowPlaying[0];
                    bool PlayListIsEmpty = mp.PlayList.Count == 0;
                    mp.PlayList = NowPlaying;
                    if (PlayListIsEmpty)
                    {
                        mp.PlayFile(file);
                        SetupPlayFile(file);
                    }
                }
            }
            Console.WriteLine("Current playlist: ");
            foreach(MusicFile file in mp.PlayList)
            {
                Console.WriteLine(file.Title);
            }
        }

        private void trvDirectories_MouseClick(object sender, MouseEventArgs e)
        {
            trvDirectories.SelectedNode = trvDirectories.GetNodeAt(new Point(e.X, e.Y));
            if (e.Clicks == 2) trvDirectories_NodeMouseDoubleClick(
                sender, 
                new TreeNodeMouseClickEventArgs(trvDirectories.SelectedNode, 
                                                e.Button, 
                                                e.Clicks, 
                                                e.X, e.Y)); ;
        }

        public void SetupPlayFile(MusicFile file)
        {
            // Get playtime of file, add file to playlist and update playlist to player
            TimeSpan maxSeconds = mp.GetMaxDuration();

            // Read tag and set in group box Details
            mt.SetMediaTag(grpDetails, file.FilePath);

            // Set seekbar max value 
            trbSeeker.Maximum = (int)(Math.Floor((double)maxSeconds.Minutes) * 60 + Math.Ceiling((double)maxSeconds.Seconds));
            lblSeekMax.Text = string.Format("{0:D2}:{1:D2}", maxSeconds.Minutes, maxSeconds.Seconds);

            // Highlight row in data grid view
            grdNowPlaying.ClearSelection();
            foreach(DataGridViewCell cell in grdNowPlaying.Rows[mp.NowPlayingIndex].Cells)
            {
                cell.Selected = true;
            }

            // Start timer to update seekbar along with media playback
            tmrSeekBar.Start();
        }
    }
}
