using MusicLibrary_DAL.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_BLL.Models
{
    public class ArtistList:IEnumerable
    {
        public List<dbo_Artist> Artists { get; set; } = new List<dbo_Artist>();

        IEnumerator IEnumerable.GetEnumerator() { return Artists.GetEnumerator(); }
        public dbo_Artist this[int index]
        {
            get { return Artists[index]; }
            set { Artists[index] = value; }
        }
    }
}
