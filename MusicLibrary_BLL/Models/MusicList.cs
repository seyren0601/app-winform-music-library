using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MusicLibrary_BLL.Models
{
    public class MusicList:IEnumerable
    {
        public BindingList<MusicFile> FileList = new BindingList<MusicFile>();
        public int Count => FileList.Count;
        static MusicList Instance;
        public static MusicList GetInstance()
        {
            if (Instance == null) return Instance = new MusicList();
            return Instance;
        }
        
        public MusicFile Add(FileInfo file, TimeSpan playTime)
        {
            TagLib.File f = TagLib.File.Create(file.FullName);
            FileList.Add(new MusicFile()
            {
                FilePath = file.FullName,
                MusicBrainzID = f.Tag.MusicBrainzTrackId,
                Title = f.Tag.Title,
                Artist = f.Tag.AlbumArtists.First(),
                Album = f.Tag.Album,
                PlayTime = playTime
            });
            return FileList.Last();
        }

        public void Add(MusicFile file)
        {
            FileList.Add(file);
        }
        public void Remove(MusicFile file) => FileList.Remove(file);



        IEnumerator IEnumerable.GetEnumerator() { return FileList.GetEnumerator(); }
        public MusicFile this[int index]
        {
            get { return FileList[index]; }
            set { FileList[index] = value; }
        }
    }
}
