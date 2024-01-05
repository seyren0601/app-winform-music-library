using MetaBrainz.MusicBrainz.Interfaces.Entities;
using MusicLibrary_DAL.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_BLL.Models
{
    public class AlbumList:IEnumerable
    {
        public List<dbo_Album> Albums { get; set; } = new List<dbo_Album>();

        public dbo_Album FindAlbum(dbo_Album album)
        {
            return Albums.Find(a => a.Title == album.Title);
        }

        IEnumerator IEnumerable.GetEnumerator() { return Albums.GetEnumerator(); }
        public dbo_Album this[int index]
        {
            get { return Albums[index]; }
            set { Albums[index] = value; }
        }
    }
}
