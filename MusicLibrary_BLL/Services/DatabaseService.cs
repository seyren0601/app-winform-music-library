using MusicLibrary_BLL.Models;
using MusicLibrary_DAL;
using MusicLibrary_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_BLL.Services
{
    public class DatabaseService
    {
        MusicLibraryDbContext dbContext = new MusicLibraryDbContext();
        static DatabaseService instance;
        public static DatabaseService GetInstance()
        {
            if (instance == null) return instance = new DatabaseService();
            return instance;
        }

        public dbo_Album FindAlbum(dbo_Album Album) => dbContext.Albums.FirstOrDefault(a=>a.Equals(Album));

        public dbo_Album FindAlbum(string AlbumName) => dbContext.Albums.FirstOrDefault(a => a.Title == AlbumName);

        public dbo_Artist FindArtist(dbo_Artist Artist) => dbContext.Artists.FirstOrDefault(a=>a.Equals(Artist));

        public void AddAlbum(dbo_Album Album)
        {
            dbContext.Albums.Add(Album);
            dbContext.SaveChanges();
        }

        public void AddArtist(dbo_Artist Artist)
        {
            dbContext.Artists.Add(Artist);
            dbContext.SaveChanges();
        }

        public async void AddFiles(List<dbo_MusicFile> files, dbo_Album album)
        {
            foreach(var file in files)
            {
                if(dbContext.MusicFiles.FirstOrDefault(x=>x.SongID == file.SongID) == null)
                    await dbContext.MusicFiles.AddAsync(file);
                await dbContext.AlbumInfos.AddAsync(new dbo_AlbumInfo()
                {
                    AlbumID = album.AlbumID,
                    SongID = file.SongID
                });
            }
            dbContext.SaveChanges();
        }
    }
}
