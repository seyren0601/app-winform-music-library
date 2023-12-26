using MusicLibrary_DAL;
using MusicLibrary_DAL.Entities;
using MusicLibrary_BLL.Models;
using System.Linq;

namespace MusicLibrary_BLL
{
    public static class UserSerivce
    {
        public static List<User> GetUsers()
        {
            using (var db = new MusicLibraryDbContext())
            {
                IQueryable<dbo_User> QueryResult = db.Users;
                List<User> Users = new List<User>();
                foreach(var user in QueryResult)
                {
                    Users.Add(new User(
                        user.username,
                        user.h_pass,
                        Convert.FromBase64String(user.salt)));
                }
                return Users;
            }
        }

        public static User? FindUser(string username)
        {
            using(var db = new MusicLibraryDbContext())
            {
                IQueryable<dbo_User> Users = db.Users
                    .Where(x => x.username == username);
                if(Users.Count() == 0)
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
    }
}
