using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_DAL.Entities
{
    public class Playlist
    {
        public MusicList MusicList = new MusicList();
        public int Count => MusicList.Count;
        public string username;
        public int PlaylistID;
        public string PlaylistName;

        public void Add(MusicList list) // method to response to MusicList AddEvent
        {
            MusicList = list;
        }

        public void UpdateList(MusicList list, EventArgs e = default(EventArgs))
        {;
            MusicList = list;
            Console.WriteLine($"Currently in playlist {PlaylistID} - {PlaylistName}:");
            foreach(MusicFile music in MusicList)
            {
                Console.WriteLine($"{music.Title}");
            }
        }

        public override string ToString()
        {
            return PlaylistName;
        }
    }
}
