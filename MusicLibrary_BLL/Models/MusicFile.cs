using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_BLL.Models
{
    public class MusicFile
    {
        public string? MusicBrainzID { get; set; }
        public string FilePath { get; set; }
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public string? Album { get; set; }
        public TimeSpan PlayTime { get; set; }
        public MusicFile() { }
        public MusicFile(FileInfo fileInfo)
        {
            using (TagLib.File file = TagLib.File.Create(fileInfo.FullName))
            {
                MusicBrainzID = file.Tag.MusicBrainzTrackId;
                FilePath = fileInfo.FullName;
                Title = file.Tag.Title;
                if(file.Tag.Artists != null)
                    Artist = file.Tag.Artists.First();
                Album = file.Tag.Album;
                PlayTime = new AudioFileReader(FilePath).TotalTime;
            }
        }
    }
}
