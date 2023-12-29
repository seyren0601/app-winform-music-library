using MusicLibrary_DAL;
using MusicLibrary_DAL.Entities;
using MusicLibrary_BLL.Models;
using System.Linq;

namespace MusicLibrary_BLL.Services
{
    public static class UserSerivce
    {
        public static List<User> GetUsers()
        {
            using (var db = new MusicLibraryDbContext())
            {
                IQueryable<dbo_User> QueryResult = db.Users;

                List<User> Users = new List<User>();
                foreach (var row in QueryResult)
                {
                    Users.Add(new User(
                        row.username,
                        row.h_pass,
                        Convert.FromBase64String(row.salt)));
                }
                return Users;
            }
        }

        public static User? FindUser(string username)
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
                    return new User(
                        user.username,
                        user.h_pass,
                        Convert.FromBase64String(user.salt));
                }
            }
        }

        public static bool AddUser(User user)
        {
            using (var db = new MusicLibraryDbContext())
            {
                db.Users.Add(new dbo_User()
                {
                    username = user.Username,
                    h_pass = user.GetHashedPassword(),
                    salt = user.GetSaltString()
                });

                int affected = db.SaveChanges();
                return affected == 1;
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
                    byte[] salt = Convert.FromBase64String(db_user.salt);
                    User loginUser = new User(username, password, salt);
                    bool authenticated =
                        loginUser.Username == db_user.username
                        && loginUser.GetHashedPassword() == db_user.h_pass;
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
