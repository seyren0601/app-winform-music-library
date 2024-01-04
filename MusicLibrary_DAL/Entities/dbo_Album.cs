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
        [Key, StringLength(50), Required]
        public string AlbumID { get; set; }
        [Required,  StringLength(50)]
        public string ArtistID { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        //[ForeignKey(nameof(AlbumID))]
        //[InverseProperty(nameof(Artist.Albums))]
        public virtual dbo_Artist Artist { get; set; }
    }
}
