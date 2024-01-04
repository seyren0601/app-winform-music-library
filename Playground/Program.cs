using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary_DAL.Entities;
using MusicLibrary_BLL.Models;
using static MusicLibrary_BLL.Services.UserSerivce;
using WMPLib;
using System.Media;
using NAudio.Wave;
using MetaBrainz.MusicBrainz;
using MetaBrainz.MusicBrainz.Interfaces.Entities;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

namespace MusicLibrary_DAL
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var q = new Query();
            var result = q.FindArtists("YOASOBI");
            var artistID = result.Results[0].Item.Id;
            var artist = q.LookupArtist(artistID);


            /*var inp_artist = new dbo_Artist()
            {
                ArtistID = artist.Id.ToString(),
                ArtistName = artist.Name,
                DebutYear = artist.LifeSpan.Begin.Year.Value
            };
            using (var Context = new MusicLibraryDbContext())
            {
                if (Context.Artists.Count(x => x.ArtistID == inp_artist.ArtistID) == 0)
                {
                    Context.Artists.Add(inp_artist);
                    int affected = Context.SaveChanges();
                    Console.WriteLine("Affected = " + affected);
                }
            }*/

            var album = q.LookupRelease(new Guid("e4ac4709-e6df-4438-b411-9ab6c96d94fe"), Include.Recordings);
            using(var Context = new MusicLibraryDbContext())
            {
                var inp_album = new dbo_Album()
                {
                    AlbumID = album.Id.ToString(),
                    ArtistID = artist.Id.ToString(),
                    Title = album.Title,
                    ReleaseYear = album.Date.Year.Value
                };
                if(Context.Albums.Count(x=>x.AlbumID == inp_album.AlbumID) == 0)
                {
                    Context.Albums.Add(inp_album);
                    Console.WriteLine("Affected = " + Context.SaveChanges());
                }
            }

            using (var Context = new MusicLibraryDbContext())
            {
                var artists = Context.Artists.Include(artist => artist.ALBUMS).ToList();
                foreach(dbo_Artist at in artists)
                {
                    Console.WriteLine($"Artist name: {at.ArtistName}");
                    Console.WriteLine($"No of albums: {at.ALBUMS.Count}\n");
                    foreach(dbo_Album alb in at.ALBUMS)
                    {
                        Console.WriteLine($"AlbumID: {alb.AlbumID}");
                        Console.WriteLine($"Album: {alb.Title}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
