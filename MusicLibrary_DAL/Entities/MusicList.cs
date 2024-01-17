using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MusicLibrary_DAL.Entities
{
    [Table("dbo_PlaylistInfo", Schema="musiclibrary"), PrimaryKey("PlaylistID", "SongID")]
    public class MusicList:IEnumerable
    {
        [ForeignKey("dbo_Playlist")]
        public int PlaylistID { get; set; }
        [ForeignKey("dbo_MusicFile")]
        public string SongID { get; set; }
        public dbo_MusicFile Song { get; set; }
        public Playlist Playlist { get; set; }
        [NotMapped]
        public BindingList<MusicFile> FileList = new BindingList<MusicFile>();
        [NotMapped]
        public int Count => FileList.Count;


        public MusicList() { }
        public MusicList(int playlistID)
        {
            PlaylistID = playlistID;
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
                PlayTime = playTime.Minutes.ToString("D2") + ":" + playTime.Seconds.ToString("D2")
            });
            AddEvent.Invoke(this, new EventArgs());
            return FileList.Last();
        }

        public void Add(MusicFile file)
        {
            FileList.Add(file);
        }
        public void Remove(MusicFile file)
        {
            FileList.Remove(file);
            RemoveEvent.Invoke(this, new EventArgs());
        }

        public delegate void MusicListEventhandler(MusicList list, EventArgs e);
        public event MusicListEventhandler AddEvent;
        public event MusicListEventhandler RemoveEvent;

        IEnumerator IEnumerable.GetEnumerator() { return FileList.GetEnumerator(); }
        [NotMapped]
        public MusicFile this[int index]
        {
            get { return FileList[index]; }
            set { FileList[index] = value; }
        }
    }
}
