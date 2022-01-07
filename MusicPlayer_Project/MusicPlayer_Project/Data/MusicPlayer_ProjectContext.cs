using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicPlayer_Project.Models;

namespace MusicPlayer_Project.Data
{
    public class MusicPlayer_ProjectContext : IdentityDbContext<User>
    {
        public MusicPlayer_ProjectContext(DbContextOptions<MusicPlayer_ProjectContext> options)
            : base(options)
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
        public DbSet<SongGenre> SongGenres { get; set; }
        public DbSet<Models.User> MusicUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("webApp");

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Models.User>();
            modelBuilder.Entity<Album>();
            modelBuilder.Entity<Artist>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<AlbumGenre>();
            modelBuilder.Entity<ArtistSong>();
            modelBuilder.Entity<Playlist>();

            modelBuilder.Entity<PlaylistCollection>()
                .HasOne<Song>(pc => pc.Song)
                .WithMany(s => s.PlaylistCollections)
                .HasForeignKey(pc => pc.SongID);
            modelBuilder.Entity<PlaylistCollection>()
                .HasOne<Playlist>(pc => pc.Playlist)
                .WithMany(p => p.PlaylistCollection)
                .HasForeignKey(pc => pc.PlaylistID);
            modelBuilder.Entity<PlaylistUser>();
            modelBuilder.Entity<Song>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<SongGenre>();
            modelBuilder.Entity<Genre>().Property(p => p.Name).IsRequired();
        }
    }
}
