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
        [Key, StringLength(50), Required]
        public string SongID { get; set; }
        [ForeignKey("dbo_Artist")]
        public string ArtistID { get; set; }
        public dbo_Artist artist { get; set; }
        [StringLength(100)]
        public string FilePath { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
    }
}
