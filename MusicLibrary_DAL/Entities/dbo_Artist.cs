using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_DAL.Entities
{
    [Table("dbo_Artist", Schema = "musiclibrary")]
    public class dbo_Artist
    {
        [Key]
        public string ArtistID { get; set; }
        public string ArtistName { get; set; }
        public int? DebutYear { get; set; }
        public virtual ICollection<dbo_Album>? ALBUMS { get; set; }
        public dbo_Artist() { }
        public dbo_Artist(string artistID, string artistName, int debutYear)
        {
            ArtistID = artistID;
            ArtistName = artistName;
            DebutYear = debutYear;
        }
    }
}
