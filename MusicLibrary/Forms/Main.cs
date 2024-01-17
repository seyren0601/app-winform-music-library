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
using System.Collections;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using MusicLibrary_GUI;
using MusicLibrary_DAL.Entities;
using Windows.System;
using System.Diagnostics.Eventing.Reader;
using MySqlX.XDevAPI.Common;

namespace MusicLibrary
{
    public enum Role
    {
        admin,
        user
    }
    public partial class Main : Form
    {

        public string RootDirectory = "..\\..\\..\\Music";
        string FormUsername;
        Role userRole;

        TreeViewService _treeViewSerivce = TreeViewService.GetInstance();
        DatabaseService _database = DatabaseService.GetInstance();
        MusicBrainz _musicBrainz = MusicBrainz.GetInstance();

        MusicPlayer mp = MusicPlayer.GetInstance();
        MediaTag mt = MediaTag.GetInstance();
        MusicList NowPlaying = new MusicList();
        Playlist CurrentPlaylist;
        BindingList<Playlist> Playlists;

        // Form constructors
        public Main(string username, Role role)
        {
            FormUsername = username;
            userRole = role;
            InitializeComponent();
        }

        public Main()
        {
            InitializeComponent();
        }

        // Forms
        AddFolder Form_AddFolder;


        // Properties for adding new album
        public string Add_FilePath { get; set; }
        public dbo_Artist Add_Artist { get; set; }
        public dbo_Album Add_Album { get; set; }

        private void Main_Load(object sender, EventArgs e)
        {
            CurrentPlaylist = new Playlist() { PlaylistName = "Current playing", username = FormUsername };
            _treeViewSerivce.BindDirectoryToTreeView(trvDirectories, RootDirectory);
            mp.ChangeVolume(volumeSlider1.Volume);

            mp.FilePlay += mp_OnFilePlay;

            rdDefault.Tag = RepeatMode.Default;
            rdRepeatList.Tag = RepeatMode.RepeatList;
            rdRepeatOne.Tag = RepeatMode.RepeatOne;

            List<Playlist> UserPlaylists = _database.FetchUserPlaylists(FormUsername);
            if (UserPlaylists != null)
            {
                Playlists = new BindingList<Playlist>();
                foreach (Playlist playlist in UserPlaylists)
                {
                    if (playlist.PlaylistName == "Current playing")
                    {
                        CurrentPlaylist = playlist;
                    }
                    Playlists.Add(playlist);
                }
                NowPlaying.FileList = _database.FetchPlaylistSongs(CurrentPlaylist.PlaylistID, FormUsername);
                mp.PlayList = NowPlaying;
            }
            else
            {
                Playlists = new BindingList<Playlist>();
                CurrentPlaylist.Add(NowPlaying);
                Playlists.Add(CurrentPlaylist);
                _database.AddPlaylist(CurrentPlaylist);
            }

            NowPlaying.AddEvent += CurrentPlaylist.UpdateList;
            NowPlaying.RemoveEvent += CurrentPlaylist.UpdateList;

            cmbPlaylist.DataSource = Playlists;
            cmbPlaylist.DisplayMember = "PlaylistName";

            grdNowPlaying.DataSource = NowPlaying.FileList;
            grdNowPlaying.Columns[0].Visible = false;
            grdNowPlaying.Columns[1].Visible = false;

            if (NowPlaying.Count > 0)
            {
                mp.NowPlayingIndex = 0;
                mp.PlayFile(NowPlaying[mp.NowPlayingIndex]);
                mp.waveOut.Pause();
                btnPlay.Enabled = true;
                btnStop.Enabled = true;
            }

            SongAddSuccessfulEvent += ProgressBarUpdate;

            Console.OutputEncoding = System.Text.Encoding.UTF8; // for testing unicode in console
        }

        #region Events
        // Buttons click
        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn sẽ logout khỏi ứng dụng", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                tmrSeekBar.Stop();
                Close();
            }
        }

        private void trvDirectories_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is MusicFile)
            {
                MusicFile file = e.Node.Tag as MusicFile;
                // Read and Play media (mp3/flac)
                mp.NowPlayingIndex = 0;
                // Clear current playlist
                NowPlaying.FileList.Clear();

                // Add file to playlist
                NowPlaying.Add(file);
                mp.PlayList = NowPlaying;
                CurrentPlaylist.PlaylistInfo = NowPlaying;
                _database.UpdatePlaylist(CurrentPlaylist, NowPlaying);

                mp.PlayFile(file);

                // Enable stop button (now waveOut is not null)
                btnPlay.Enabled = true;
                btnStop.Enabled = true;
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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (NowPlaying.Count > 0)
            {
                if (mp.NowPlayingIndex > 0)
                {
                    mp.NowPlayingIndex -= 1;
                }
                else
                {
                    mp.NowPlayingIndex = NowPlaying.Count - 1;
                }
                mp.PlayFile(NowPlaying[mp.NowPlayingIndex]);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (NowPlaying.Count > 0)
            {
                if (mp.NowPlayingIndex < NowPlaying.Count - 1)
                {
                    mp.NowPlayingIndex += 1;
                }
                else
                {
                    mp.NowPlayingIndex = 0;
                }
                mp.PlayFile(NowPlaying[mp.NowPlayingIndex]);
            }
        }

        private async void btnAddFolder_Click(object sender, EventArgs e)
        {
            Form_AddFolder = new AddFolder();
            var result = Form_AddFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                Add_FilePath = Form_AddFolder.FolderPath;
                Add_Artist = Form_AddFolder.Artist;
                Add_Album = Form_AddFolder.Album;
                Add_Album.ArtistID = Add_Artist.ArtistID;
            }
            else
            {
                return;
            }
            if (_database.FindAlbum(Add_Album.Title) == null)
            {
                prgAddAlbum.Show();
                Cursor.Current = Cursors.WaitCursor;
                if (_database.FindArtist(Add_Artist) == null) _database.AddArtist(Add_Artist);
                _database.AddAlbum(Add_Album);
                List<dbo_MusicFile> Added_Files = await AddAlbum(Add_FilePath, RootDirectory, Add_Artist, Add_Album);
                _database.AddFiles(Added_Files, Add_Album);
                MessageBox.Show("Album added successfully");
                prgAddAlbum.Hide();
                Cursor.Current = Cursors.Default;
                trvDirectories.Nodes.Clear();
                _treeViewSerivce.BindDirectoryToTreeView(trvDirectories, RootDirectory);
            }
            else
            {
                MessageBox.Show("Album already exists.");
            }
        }

        // Timer tick
        private void tmrSeekBar_Tick(object sender, EventArgs e)
        {
            if (mp.waveOut != null && mp.waveOut.PlaybackState == PlaybackState.Playing)
            {
                TimeSpan currentTime = mp.GetPosition();
                if (currentTime < mp.GetMaxDuration())
                {
                    trbSeeker.Value = (int)Math.Floor((double)currentTime.TotalSeconds);
                    lblSeekMin.Text = string.Format("{0:D2}:{1:D2}", currentTime.Minutes, currentTime.Seconds);
                }
            }

            // Placeholder for playback stopped event (can't implement normally)
            if (mp.waveOut != null && mp.FileReader.CurrentTime != TimeSpan.Zero && mp.waveOut.PlaybackState == PlaybackState.Stopped)
            {
                mp.OnPlaybackStopped();
                mp_OnFilePlay(mp, new MusicPlayerEventArgs(NowPlaying[mp.NowPlayingIndex]));
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
            if (e.ClickedItem == ctxTreeNode.Items["menuAddToPlayList"])
            {
                if (trvDirectories.SelectedNode.Tag is MusicFile)
                {
                    MusicFile file = trvDirectories.SelectedNode.Tag as MusicFile;
                    NowPlaying.Add(file);
                    mp.PlayList = NowPlaying;
                    _database.UpdatePlaylist(CurrentPlaylist, NowPlaying);
                    if (mp.PlayList.Count == 1)
                    {
                        mp.NowPlayingIndex = 0;
                        mp.PlayFile(file);
                    }
                }
                else
                {
                    bool PlayListIsEmpty = NowPlaying.Count == 0;
                    TreeNode root = trvDirectories.SelectedNode;
                    _treeViewSerivce.AddFolderToPlaylist(root, NowPlaying);
                    MusicFile file = NowPlaying[0];
                    mp.PlayList = NowPlaying;
                    _database.UpdatePlaylist(CurrentPlaylist, NowPlaying);
                    if (PlayListIsEmpty)
                    {
                        mp.PlayFile(file);
                        mp.NowPlayingIndex = 0;
                    }
                }
                // Enable stop button (now waveOut is not null)
                btnStop.Enabled = true;
                btnPlay.Enabled = true;
            }
            Console.WriteLine("Current playlist: ");
            for (int i = 0; i < NowPlaying.Count; i++)
            {
                Console.WriteLine(i + ". " + NowPlaying[i].Title);
            }
        }

        private void ctxDataGrid_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == ctxDataGrid.Items["menuRemove"])
            {
                var currentPlayingFile = NowPlaying[mp.NowPlayingIndex];
                bool deletePlayingFile = RemoveRows(grdNowPlaying.SelectedRows);
                if (deletePlayingFile && NowPlaying.Count > 0)
                {
                    mp.NowPlayingIndex = 0;
                    mp.PlayFile(NowPlaying[mp.NowPlayingIndex]);
                    mp.waveOut.Pause();
                }
                else if (NowPlaying.Count > 0)
                {
                    mp.NowPlayingIndex = NowPlaying.FileList.IndexOf(currentPlayingFile);
                }

                if (NowPlaying.Count > 0)
                {
                    mp.waveOut.Play();
                }
                else
                {
                    mp.Stop();
                    mp.waveOut = null;
                    mp.FileReader = null;
                    // Disable button because waveOut is now null
                    btnStop.Enabled = false;
                    btnPlay.Enabled = false;

                    // Reset seekbar
                    trbSeeker.Value = 0;
                    lblSeekMin.Text = "0:00";
                    lblSeekMax.Text = "0:00";

                    // Reset details' textboxes
                    foreach (Control control in grpDetails.Controls)
                    {
                        if (control is TextBox)
                        {
                            ((TextBox)control).Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void grdNowPlaying_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
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

        public void mp_OnFilePlay(MusicPlayer mp, MusicPlayerEventArgs e)
        {
            var file = e.FiledPlayed;
            // Get playtime of file, add file to playlist and update playlist to player
            TimeSpan maxSeconds = mp.GetMaxDuration();

            // Read tag and set in group box Details
            mt.SetMediaTag(grpDetails, file.FilePath);

            // Set seekbar max value 
            trbSeeker.Maximum = (int)(Math.Floor((double)maxSeconds.Minutes) * 60 + Math.Ceiling((double)maxSeconds.Seconds));
            lblSeekMax.Text = string.Format("{0:D2}:{1:D2}", maxSeconds.Minutes, maxSeconds.Seconds);

            // Highlight row in data grid view
            grdNowPlaying.ClearSelection();
            foreach (DataGridViewCell cell in grdNowPlaying.Rows[mp.NowPlayingIndex].Cells)
            {
                cell.Selected = true;
            }

            // Start timer to update seekbar along with media playback
            tmrSeekBar.Start();
        }

        private void grdNowPlaying_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mp.NowPlayingIndex = e.RowIndex;
            mp.PlayFile(NowPlaying[mp.NowPlayingIndex]);
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            if (Playlists.Count(e => e.PlaylistName == cmbPlaylist.Text) == 0)
            {
                Playlist playlist = new Playlist() { PlaylistName = cmbPlaylist.Text, username = FormUsername };
                Playlists.Add(playlist);
                _database.AddPlaylist(playlist);
            }
            else
            {
                MessageBox.Show("Tên playlist trùng!");
            }
        }

        private void cmbPlaylist_SelectedValueChanged(object sender, EventArgs e)
        {
            CurrentPlaylist = cmbPlaylist.SelectedItem as Playlist;
            NowPlaying.FileList = _database.FetchPlaylistSongs(CurrentPlaylist.PlaylistID, FormUsername);
            grdNowPlaying.DataSource = CurrentPlaylist.PlaylistInfo;
            mp.PlayList = NowPlaying;
            grdNowPlaying.DataSource = NowPlaying.FileList;
            grdNowPlaying.Columns[0].Visible = false;
            grdNowPlaying.Columns[1].Visible = false;
            if (NowPlaying.Count > 0)
            {
                mp.NowPlayingIndex = 0;
                trbSeeker.Value = 0;
                lblSeekMin.Text = "0:00";
                mp.PlayFile(NowPlaying[mp.NowPlayingIndex]);
                mp.waveOut.Pause();
                btnPlay.Enabled = true;
                btnStop.Enabled = true;
            }
            else
            {
                mp.Stop();
                mp.waveOut = null;
                mp.FileReader = null;
                // Disable button because waveOut is now null
                btnStop.Enabled = false;
                btnPlay.Enabled = false;

                // Reset seekbar
                trbSeeker.Value = 0;
                lblSeekMin.Text = "0:00";
                lblSeekMax.Text = "0:00";

                // Reset details' textboxes
                foreach (Control control in grpDetails.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Text = string.Empty;
                    }
                }
            }
        }

        private void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            var playlist = cmbPlaylist.SelectedItem as Playlist;
            if (playlist != null)
            {
                if (playlist.PlaylistName == "Current playing")
                {
                    MessageBox.Show("Không thể xóa playlist [Current playing]\n(Playlist mặc định).");
                }
                else
                {
                    var result = MessageBox.Show($"Bạn có muốn xóa playlist [{playlist.PlaylistName}] không?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Playlists.Remove(playlist);
                        _database.RemovePlaylist(playlist, FormUsername);

                        CurrentPlaylist = cmbPlaylist.Items[0] as Playlist;
                        cmbPlaylist.SelectedIndex = 0;
                        cmbPlaylist.DataSource = Playlists;
                        NowPlaying.FileList = _database.FetchPlaylistSongs(CurrentPlaylist.PlaylistID, FormUsername);
                        grdNowPlaying.DataSource = CurrentPlaylist.PlaylistInfo;
                        mp.PlayList = NowPlaying;
                        grdNowPlaying.DataSource = NowPlaying.FileList;
                        grdNowPlaying.Columns[0].Visible = false;
                        grdNowPlaying.Columns[1].Visible = false;
                        if (NowPlaying.Count > 0)
                        {
                            mp.NowPlayingIndex = 0;
                            trbSeeker.Value = 0;
                            lblSeekMin.Text = "0:00";
                            mp.PlayFile(NowPlaying[mp.NowPlayingIndex]);
                            mp.waveOut.Pause();
                            btnPlay.Enabled = true;
                            btnStop.Enabled = true;
                        }
                        else
                        {
                            ResetNowPlaying();
                        }
                    }
                }
            }
        }

        private void ProgressBarUpdate(object sender, FileOperationEventArgs e)
        {
            prgAddAlbum.Value = e.progress;
        }

        private void btnDeleteFolder_Click(object sender, EventArgs e)
        {
            if(trvDirectories.SelectedNode == null || trvDirectories.SelectedNode.Level == 3 || trvDirectories.SelectedNode.Level == 0)
            {
                MessageBox.Show("Vui lòng chọn một album hoặc artist");
            }
            else
            {
                DirectoryInfo folder = Directory.CreateDirectory(trvDirectories.SelectedNode.Tag.ToString());
                var result = MessageBox.Show("Bạn có muốn xóa " + (trvDirectories.SelectedNode.Level == 1 ? "Artist" : "Album") + $" {trvDirectories.SelectedNode.Text}?", "", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    if(trvDirectories.SelectedNode.Level == 2)
                    {
                        if (_database.RemoveAlbum(trvDirectories.SelectedNode.Text))
                        {
                            trvDirectories.SelectedNode.Remove();
                            MessageBox.Show("Xóa thành công.");
                            RefreshPlaylists();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại.");
                        }
                    }
                    else
                    {
                        if (_database.RemoveArtist(trvDirectories.SelectedNode.Text))
                        {
                            trvDirectories.SelectedNode.Remove();
                            MessageBox.Show("Xóa thành công.");
                            RefreshPlaylists();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại.");
                        }
                    }
                    folder.Delete(true);
                }
            }
        }
    }
}
