using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_BLL.Services
{
    public class MediaTag
    {
        static MediaTag Instance;
        public static MediaTag GetInstance()
        {
            if (Instance == null) return Instance = new MediaTag();
            return Instance;
        }

        public void SetMediaTag(GroupBox Details, string filePath)
        {
            TagLib.File f = TagLib.File.Create(filePath);
            foreach(Control control in Details.Controls)
            {
                if(control is TextBox)
                {
                    TextBox textbox = (TextBox)control;
                    if (textbox.Name == "txtTitle" && f.Tag.Title != null) textbox.Text = f.Tag.Title;
                    if (textbox.Name == "txtArtist" && f.Tag.AlbumArtists.Count() > 0) textbox.Text = f.Tag.AlbumArtists.First();
                    else if (textbox.Name == "txtArtist" && f.Tag.Artists.Count() > 0) textbox.Text = f.Tag.Artists.First();
                    if (textbox.Name == "txtAlbum" && f.Tag.Album != null) textbox.Text = f.Tag.Album;
                }
                
            }
            f.Dispose();
        }
    }
}
