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
                    if (textbox.Name == "txtTitle") textbox.Text = f.Tag.Title;
                    if (textbox.Name == "txtArtist") textbox.Text = f.Tag.AlbumArtists.First();
                    if (textbox.Name == "txtAlbum") textbox.Text = f.Tag.Album;
                }
                
            }
            f.Dispose();
        }
    }
}
