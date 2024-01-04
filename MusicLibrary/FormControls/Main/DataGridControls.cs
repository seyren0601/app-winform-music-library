using MusicLibrary_BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    public partial class Main
    {
        bool RemoveRows(DataGridViewSelectedRowCollection rows)
        {
            bool playing = false;
            foreach (DataGridViewRow row in rows)
            {
                MusicFile file = row.DataBoundItem as MusicFile;
                if (file == NowPlaying[mp.NowPlayingIndex])
                {
                    playing = true;
                }
                NowPlaying.Remove(file);
            }
            mp.PlayList = NowPlaying;
            return playing;
        }
    }
}
