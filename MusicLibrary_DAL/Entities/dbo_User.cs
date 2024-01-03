using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_DAL.Entities
{
    [Table("dbo_user", Schema = "musiclibrary")]
    public class dbo_User
    {
        [Key, StringLength(50), Required]
        public string username { get; set; }
        [StringLength(50)]
        public string h_pass { get; set; }
        [StringLength(50)]
        public string salt { get; set; }
        [Required]
        public bool administrator { get; set; }
        [NotMapped]
        public byte[] salt_byte
        {
            get => Convert.FromBase64String(salt);
            set
            {
                salt_byte = value;
            }
        }

        public dbo_User() { }
        public dbo_User(string username, string h_pass, string salt, bool administrator)
        {
            this.username = username;
            this.h_pass = h_pass;
            this.salt = salt;
            this.administrator = administrator;
        }
        public static (string, byte[]) GetHashedPassword(string password)
        {
            byte[] salt_generated = RandomNumberGenerator.GetBytes(16);
            return (Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password!,
                    salt: salt_generated,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 100000,
                    numBytesRequested: 256 / 8)
                ), salt_generated);
        }

        public static string GetHashedPassword(string password, byte[] salt_byte)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password!,
                    salt: salt_byte,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 100000,
                    numBytesRequested: 256 / 8)
                );
        }
    }
}
