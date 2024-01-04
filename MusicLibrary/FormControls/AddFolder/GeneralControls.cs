using MetaBrainz.MusicBrainz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_GUI
{
    public partial class AddFolder
    {
        ReleaseType GetReleaseType()
        {
            foreach (RadioButton rd in grpReleaseType.Controls)
            {
                if (rd.Checked) return (ReleaseType)rd.Tag!;
            }
            return ReleaseType.Other;
        }
    }
}
