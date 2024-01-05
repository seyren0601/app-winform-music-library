using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_DAL.Entities
{
    [Table("dbo_MusicFile", Schema = "musiclibrary")]
    public class dbo_MusicFile
    {
        [Key]
        public string SongID { get; set; }
        public string ArtistID { get; set; }
        public dbo_Artist Artist { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public ICollection<dbo_AlbumInfo> Albums { get; set; }
    }
}
