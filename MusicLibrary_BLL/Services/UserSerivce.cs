using MusicLibrary_DAL;
using MusicLibrary_DAL.Entities;
using MusicLibrary_BLL.Models;
using System.Linq;

namespace MusicLibrary_BLL.Services
{
    public static class UserSerivce
    {
        public static List<dbo_User> GetUsers()
        {
            using (var db = new MusicLibraryDbContext())
            {
                IQueryable<dbo_User> QueryResult = db.Users;

                List<dbo_User> Users = new List<dbo_User>();
                foreach (var row in QueryResult)
                {
                    Users.Add(new dbo_User(
                        row.username,
                        row.h_pass,
                        row.salt,
                        row.administrator));
                }
                return Users;
            }
        }

        public static dbo_User? FindUser(string username)
        {
            using (var db = new MusicLibraryDbContext())
            {
                IQueryable<dbo_User> Users = db.Users
                    .Where(x => x.username == username);

                if (Users.Count() == 0)
                {
                    return null;
                }
                else
                {
                    dbo_User user = Users.First();
                    return new dbo_User(
                        user.username,
                        user.h_pass,
                        user.salt,
                        user.administrator);
                }
            }
        }

        public static bool AddUser(string username, string password)
        {
            using (var db = new MusicLibraryDbContext())
            {
                var password_info = dbo_User.GetHashedPassword(password);
                db.Users.Add(new dbo_User()
                {
                    username = username,
                    h_pass = password_info.Item1,
                    salt = Convert.ToBase64String(password_info.Item2),
                    administrator = false
                });

                int affected = db.SaveChanges();
                return affected == 1;
            }
        }

        public static void AddAdmin()
        {
            using (var db = new MusicLibraryDbContext())
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
            }
        }

        public static bool LoginUser(string username, string password)
        {
            
            using(var db = new MusicLibraryDbContext())
            {
                IQueryable<dbo_User> Users = db.Users
                    .Where(x=>x.username == username);
                if(Users.Count() == 0)
                {
                    return false;
                }
                else
                {
                    dbo_User db_user = Users.First();
                    byte[] salt = db_user.salt_byte;
                    bool authenticated =
                        username == db_user.username
                        && dbo_User.GetHashedPassword(password, salt) == db_user.h_pass;
                    if (authenticated)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
