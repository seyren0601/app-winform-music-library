using MusicLibrary_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    public partial class Main
    {
        public void RefreshPlaylists()
        {
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
            }

            NowPlaying.FileList = _database.FetchPlaylistSongs(CurrentPlaylist.PlaylistID, FormUsername);
            mp.PlayList = NowPlaying;
            grdNowPlaying.DataSource = NowPlaying.FileList;
            ResetNowPlaying();
            if (NowPlaying.Count > 0)
            {
                mp.NowPlayingIndex = 0;
                mp.PlayFile(NowPlaying[mp.NowPlayingIndex]);
                mp.waveOut.Pause();
                btnPlay.Enabled = true;
                btnStop.Enabled = true;
            }
        }
    }
}
