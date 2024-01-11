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
            var q = new Query();
            string artistID = "df6c619f-4334-43e2-8b6a-4a32af1e4f85";
            string albumID = "1489b651-808d-465b-b92e-15fee371a158";
            var query = q.LookupRelease(new Guid("1489b651-808d-465b-b92e-15fee371a158"), Include.Recordings).Media[0];
            foreach(var track in query.Tracks)
            {
                Console.WriteLine(track.Title + $" ({track.Number})");
            }
        }
    }
}
