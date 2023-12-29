using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary_DAL.Entities;
using MusicLibrary_BLL.Models;
using static MusicLibrary_BLL.Services.UserSerivce;

namespace MusicLibrary_DAL
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User? user = FindUser("seyren");
            if (user != null)
                Console.WriteLine($"{user.Username} {user.GetHashedPassword()} {user.GetSaltString()}");
        }
    }
}
