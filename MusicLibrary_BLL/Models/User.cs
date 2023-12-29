using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_BLL.Models
{
    public class User
    {
        public string Username { get; set; }
        string? Password { get; set; }
        byte[] Salt { get; set; }
        public User(string username, string passWord, byte[] salt)
        {
            Username = username;
            Password = passWord;
            Salt = salt;
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Salt = RandomNumberGenerator.GetBytes(16);
        }

        public string GetHashedPassword()
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: Password!,
                    salt: Salt,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 100000,
                    numBytesRequested: 256 / 8)
                );
        }

        public string GetSaltString()
        {
            return Convert.ToBase64String(Salt, 0, 16);
        }
    }
}
