using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_DAL.Entities
{
    [Table("dbo_AlbumInfo", Schema="musiclibrary"), PrimaryKey("AlbumID", "SongID")]
    public class dbo_AlbumInfo
    {
        [ForeignKey("dbo_Album")]
        public string AlbumID { get; set; }
        [ForeignKey("dbo_MusicFile")]
        public string SongID { get; set; }
        public dbo_Album Album { get; set; }
        public dbo_MusicFile MusicFile { get; set; }
    }
}
