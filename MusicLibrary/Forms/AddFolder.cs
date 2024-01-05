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
using MusicLibrary_BLL.Models;
using MusicLibrary_DAL.Entities;
using MetaBrainz.MusicBrainz.Interfaces.Entities;
using System.Collections;
using MetaBrainz.MusicBrainz;
using System.Formats.Asn1;
using MusicLibrary;

namespace MusicLibrary_GUI
{
    public partial class AddFolder : Form
    {
        public string FolderPath { get; set; }
        public dbo_Artist Artist { get; set; }
        public dbo_Album Album { get; set; }
        MusicBrainz _musicBrainz = MusicBrainz.GetInstance();
        public AddFolder()
        {
            InitializeComponent();
        }

        private void AddFolder_Load(object sender, EventArgs e)
        {
            rdAlbum.Tag = ReleaseType.Album;
            rdEP.Tag = ReleaseType.EP;
            rdSingle.Tag = ReleaseType.Single;
        }

        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string FolderPath = folderBrowserDialog1.SelectedPath;
            txtFilePath.Text = FolderPath;
        }

        private async void btnFindArtist_Click(object sender, EventArgs e)
        {

            if (txtFindArtist.Text != null)
            {
                btnFindArtist.Enabled = false;
                txtFindArtist.Enabled = false;
                cmbArtist.Enabled = false;
                List<dbo_Artist> artistsFound = await _musicBrainz.FindArtists(txtFindArtist.Text);
                cmbArtist.Enabled = true;
                cmbArtist.DataSource = artistsFound;
                cmbArtist.DisplayMember = "ArtistName";
            }
        }

        private async void cmbArtist_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbArtist.Enabled = false;
            cmbAlbum.Enabled = false;
            List<dbo_Album> albumsFound = await _musicBrainz.FindAlbums(((dbo_Artist)cmbArtist.SelectedItem).ArtistID, GetReleaseType());
            cmbArtist.Enabled = true;
            cmbAlbum.Enabled = true;
            btnFindArtist.Enabled = true;
            txtFindArtist.Enabled = true;
            cmbAlbum.DataSource = albumsFound;
            cmbAlbum.DisplayMember = "Title";
        }

        private void RdioReleaseType_CheckChanged(object sender, EventArgs e)
        {
            if (cmbArtist.Items.Count > 0)
            {
                cmbArtist_SelectedValueChanged(sender, e);
            }
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text != "" && cmbAlbum.SelectedItem != null && cmbArtist.SelectedItem != null)
            {
                var result = MessageBox.Show($"Add album?", "Alert", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    FolderPath = txtFilePath.Text;
                    Artist = cmbArtist.SelectedItem as dbo_Artist;
                    Album = cmbAlbum.SelectedItem as dbo_Album;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
