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
            var query = await q.FindArtistsAsync(artistName, limit:25);
            var result = query.Results;
            List<dbo_Artist> artists = new List<dbo_Artist>();
            Parallel.ForEach(result, artist =>
            {
                artists.Add(new dbo_Artist()
                {
                    ArtistID = artist.Item.Id.ToString(),
                    ArtistName = artist.Item.Name!,
                    DebutYear = artist.Item.LifeSpan.Begin != null?
                                artist.Item.LifeSpan.Begin.Year.Value:null
                });
            });
            return artists;
        }

        public async Task<List<dbo_Album>> FindAlbums(string artistID, ReleaseType releaseType)
        {
            var q = new Query();
            var query = await q.BrowseArtistReleasesAsync(new Guid(artistID), type:releaseType);
            var result = query.Results
                            .DistinctBy(x => x.Title);
            List<dbo_Album> albums = new List<dbo_Album>();
            Parallel.ForEach(result, album =>
            {
                albums.Add(new dbo_Album()
                {
                    AlbumID = album.Id.ToString(),
                    Title = album.Title,
                    ArtistID = artistID,
                    ReleaseYear = album.Date != null?
                                    album.Date.Year.Value:null
                });
            });
            return albums;
        }

        public async Task<dbo_MusicFile> FindRecording(dbo_Artist artist, dbo_Album album, string songName)
        {
            var q = new Query();
            var result = await q.FindRecordingsAsync($"recording:{songName} AND arid:{artist.ArtistID} AND release={album.Title}");
            if (result.Results == null || result.Results.Count == 0)
                result = await q.FindRecordingsAsync($"recordingaccent:{songName} AND arid:{artist.ArtistID} AND release={album.Title}");
            if (result.Results == null || result.Results.Count == 0)
                result = await q.FindRecordingsAsync($"recording={songName} AND release={album.Title} AND artistname={artist.ArtistName}");
            if (result.Results == null || result.Results.Count == 0)
                result = await q.FindRecordingsAsync($"recording={songName} AND artistname={artist.ArtistName}");
            if (result.Results == null || result.Results.Count == 0)
                result = await q.FindRecordingsAsync($"recording={songName} AND release={album.Title}");
            if (result.Results == null || result.Results.Count == 0)
                return null;
            var found = result.Results[0].Item;
                return new dbo_MusicFile()
                {
                    SongID = found.Id.ToString(),
                    ArtistID = artist.ArtistID,
                    Title = found.Title!,
                    Artist = artist,
                    Number = found.Releases[0].Media[0].TrackOffset
                };
        }
    }
}
