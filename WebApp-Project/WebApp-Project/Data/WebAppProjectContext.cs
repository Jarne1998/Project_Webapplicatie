using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Project.Models;

namespace WebApp_Project.Data
{
    public class WebAppProjectContext : DbContext
    {
        public WebAppProjectContext(DbContextOptions<WebAppProjectContext> options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumGenre> AlbumGenres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistSong> ArtistSongs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<PlaylistCollection> PlaylistCollections { get; set; }
        public DbSet<PlaylistUser> PlaylistUsers { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongGenre> songGenres { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Album>().ToTable("Album");
            modelBuilder.Entity<Artist>().ToTable("Artist");
        }
    }
}
