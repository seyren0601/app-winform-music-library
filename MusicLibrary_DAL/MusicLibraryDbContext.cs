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
        public DbSet<dbo_Artist> Artists { get; set; }
        public DbSet<dbo_Album> Albums { get; set; }
        public DbSet<dbo_MusicFile> MusicFiles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<dbo_Artist>()
                .Navigation(e => e.ALBUMS);
            modelBuilder.Entity<dbo_Album>()
                .Navigation(c => c.Artist);
        }
    }
}
