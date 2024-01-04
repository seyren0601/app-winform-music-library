using MetaBrainz.MusicBrainz;
using MusicLibrary_DAL.Entities;
using MusicLibrary_BLL.Models;
using MetaBrainz.MusicBrainz.Interfaces.Searches;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaBrainz.MusicBrainz.Interfaces.Entities;
using MetaBrainz.MusicBrainz.Interfaces.Browses;

namespace MusicLibrary_BLL.Services
{
    public class MusicBrainz
    {
        static MusicBrainz Instance;
        public static MusicBrainz GetInstance()
        {
            if (Instance == null) return Instance = new MusicBrainz();
            else return Instance;
        }
        public async Task<List<dbo_Artist>> FindArtists(string artistName)
        {
            var q = new Query();
            var query = await q.FindArtistsAsync(artistName, limit:10);
            var result = query.Results
                            .OrderBy(x=>x.Score);
            List<dbo_Artist> artists = new List<dbo_Artist>();
            Parallel.ForEach(result, artist =>
            {
                artists.Add(new dbo_Artist()
                {
                    ArtistID = artist.Item.Id.ToString(),
                    ArtistName = string.Concat(artist.Item.Name!, "(", artist.Item.SortName, ")")
                });
            });
            return artists;
        }

        public async Task<List<dbo_Album>> FindAlbums(string artistID, ReleaseType releaseType)
        {
            var q = new Query();
            var query = await q.BrowseArtistReleasesAsync(new Guid(artistID), status:ReleaseStatus.Official, type:releaseType);
            var result = query.Results
                            .DistinctBy(x => x.Title)
                            .OrderBy(x => x.Title);
            List<dbo_Album> albums = new List<dbo_Album>();
            Parallel.ForEach(result, album =>
            {
                albums.Add(new dbo_Album()
                {
                    AlbumID = album.Id.ToString(),
                    Title = album.Title,
                    ArtistID = artistID,
                    //ReleaseYear = album.Date.Year.Value
                });
            });
            return albums;
        }
    }
}
