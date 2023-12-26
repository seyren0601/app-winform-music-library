using System.Configuration;
using Microsoft.EntityFrameworkCore;
using MusicLibrary_DAL.Entities;
using MySql.EntityFrameworkCore.Extensions;
using MySqlConnector;

namespace MusicLibrary_DAL
{
    public class MusicLibraryDbContext:DbContext
    {
        string ConnectionString = "server=localhost;database=musiclibrary;user=root;password=porsche0601";
        public DbSet<dbo_User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
