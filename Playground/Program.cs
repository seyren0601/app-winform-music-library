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
using MySqlX.XDevAPI.Common;

namespace MusicLibrary_DAL
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*using (var db = new MusicLibraryDbContext())
            {
                var password_info = dbo_User.GetHashedPassword("bruh");
                db.Users.Add(new dbo_User()
                {
                    username = "seyren",
                    h_pass = password_info.Item1,
                    salt = Convert.ToBase64String(password_info.Item2),
                    administrator = true
                });

                db.SaveChanges();
            }*/

            using (var db = new MusicLibraryDbContext())
            {
                var playlist = db.Playlists.First();
                Console.WriteLine(playlist.PlaylistID);
                Console.WriteLine(playlist.PlaylistName);
                Console.WriteLine(playlist.username);
            }
        }
    }
}
