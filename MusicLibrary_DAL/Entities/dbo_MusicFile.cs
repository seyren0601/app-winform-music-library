using Microsoft.EntityFrameworkCore;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_DAL.Entities
{
    [Table("dbo_MusicFile", Schema = "musiclibrary"), PrimaryKey("SongID")]
    public class dbo_MusicFile
    {
        [Column("SongID")]
        public string SongID { get; set; }
        [ForeignKey("dbo_Artist")]
        public string ArtistID { get; set; }
        public dbo_Artist Artist { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        [NotMapped]
        public int? Number { get; set; }
        public ICollection<dbo_AlbumInfo> Albums { get; set; }
        public ICollection<MusicList> Playlists { get; set; }
        public dbo_MusicFile() { }
    }
}
