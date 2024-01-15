using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_DAL.Entities
{
    [Table("dbo_Playlist", Schema = "musiclibrary"), PrimaryKey("PlaylistID")]
    public class Playlist
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlaylistID { get; set; }
        public string PlaylistName { get; set; }
        [ForeignKey("dbo_user")]
        public string username { get; set; }
        public ICollection<MusicList> MusicLists { get; set; }
        [NotMapped]
        public int Count => PlaylistInfo.Count;
        [NotMapped]
        public MusicList PlaylistInfo { get; set; }
        public Playlist() { }

        public void Add(MusicList list) // method to response to MusicList AddEvent
        {
            PlaylistInfo = list;
        }

        public void UpdateList(MusicList list, EventArgs e = default(EventArgs))
        {
            PlaylistInfo = list;
        }

        public override string ToString()
        {
            return PlaylistName;
        }
    }
}
