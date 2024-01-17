using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_DAL.Entities
{
    public class MusicFile
    {
        public string? MusicBrainzID { get; set; }
        public string FilePath { get; set; }
        public int Number { get; set; }
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public string? Album { get; set; }
        public string PlayTime { get; set; }
        public MusicFile() { }
        public MusicFile(FileInfo fileInfo)
        {
            using (TagLib.File file = TagLib.File.Create(fileInfo.FullName))
            {
                MusicBrainzID = file.Tag.MusicBrainzTrackId;
                FilePath = fileInfo.FullName;
                Title = file.Tag.Title;
                if(file.Tag.Artists.Count() > 0)
                    Artist = file.Tag.Artists.First();
                else if(file.Tag.AlbumArtists.Count() > 0)
                    Artist = file.Tag.AlbumArtists.First();
                Album = file.Tag.Album;
                using(var playtime = new AudioFileReader(FilePath))
                {
                    PlayTime = playtime.TotalTime.Minutes.ToString("D2") + ":" + playtime.TotalTime.Seconds.ToString("D2");
                }
                Number = (int)file.Tag.Track;
            }
        }
    }
}
