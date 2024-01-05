using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_DAL.Entities
{
    [Table("dbo_Album", Schema = "musiclibrary")]
    public class dbo_Album
    {
        [Key]
        public string AlbumID { get; set; }
        public string ArtistID { get; set; }
        public string Title { get; set; }
        public int? ReleaseYear { get; set; }
        public virtual dbo_Artist Artist { get; set; }
        public virtual ICollection<dbo_AlbumInfo> Recordings { get; set; }
    }
}
