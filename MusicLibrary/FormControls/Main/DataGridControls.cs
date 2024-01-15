using MusicLibrary_BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary_DAL.Entities;

namespace MusicLibrary
{
    public partial class Main
    {
        bool RemoveRows(DataGridViewSelectedRowCollection rows)
        {
            var currentPlayingFile = NowPlaying[mp.NowPlayingIndex];
            bool playing = false;
            foreach (DataGridViewRow row in rows)
            {
                MusicFile file = row.DataBoundItem as MusicFile;
                if (file == currentPlayingFile)
                {
                    playing = true;
                }
                NowPlaying.Remove(file);
                CurrentPlaylist.PlaylistInfo = NowPlaying;
                _database.RemovePlaylistSong(CurrentPlaylist, file);
            }
            mp.PlayList = NowPlaying;
            return playing;
        }
    }
}
