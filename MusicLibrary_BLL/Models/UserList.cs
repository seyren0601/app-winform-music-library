using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static MusicLibrary_BLL.Services.UserSerivce;

namespace MusicLibrary_BLL.Models
{
    public class UserList:IEnumerable
    {
        private List<User> _users = new List<User>();
        static UserList Instance;
        public static UserList GetInstance()
        {
            if ( Instance == null ) { 
                return Instance = new UserList(); 
            }
            else { return Instance; }
        }

        // Indexer and GetEnumerator
        IEnumerator IEnumerable.GetEnumerator() => _users.GetEnumerator();
        public User this[int index]
        {
            get => _users[index];
            set => _users[index] = value;
        }

        public void UpdateList()
        {
            _users = GetUsers();
        }
    }
}
