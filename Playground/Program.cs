using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary_DAL.Entities;

namespace MusicLibrary_DAL
{
    internal class Program
    {
        public static void Main()
        {
            using (var context = new MusicLibraryDbContext())
            {
                Console.WriteLine("Users: ");
                IQueryable<dbo_User> Users = context.Users;
                foreach (var user in Users)
                {
                    Console.WriteLine(user.username.ToString());
                }
            }
        }
    }
}
