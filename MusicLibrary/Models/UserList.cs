using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MusicLibrary_GUI.Models
{
    internal class UserList:IEnumerable
    {
        private readonly List<User> _users = new List<User>();
        static UserList Instance;
        public static UserList GetInstance()
        {
            if ( Instance == null ) { return Instance = new UserList(); }
            else { return Instance; }
        }

        // Indexer and GetEnumerator
        IEnumerator IEnumerable.GetEnumerator() => _users.GetEnumerator();
        public User this[int index]
        {
            get => _users[index];
            set => _users[index] = value;
        }
    }
}
