using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_DAL.Entities
{
    [Table("dbo_user", Schema = "musiclibrary")]
    public class dbo_User
    {
        [Key, StringLength(50), Required]
        public string username { get; set; }
        [StringLength(50)]
        public string h_pass { get; set; }
        [StringLength(50)]
        public string salt { get; set; }
    }
}
