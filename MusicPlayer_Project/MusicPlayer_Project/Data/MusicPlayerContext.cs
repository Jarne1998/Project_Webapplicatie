using Microsoft.EntityFrameworkCore;
using MusicPlayer_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Data
{
    public class MusicPlayerContext : DbContext
    {
        //public MusicPlayerContext(DbContextOptions<MusicPlayerContext> options) : base(options)
        //{

        //}

        //public DbSet<Album> Albums { get; set; }
        //public DbSet<AlbumGenre> AlbumGenres { get; set; }
        //public DbSet<Artist> Artists { get; set; }
        //public DbSet<ArtistSong> ArtistSongs { get; set; }
        //public DbSet<Genre> Genres { get; set; }
        //public DbSet<Playlist> Playlists { get; set; }
        //public DbSet<PlaylistCollection> PlaylistCollections { get; set; }
        //public DbSet<PlaylistUser> PlaylistUsers { get; set; }
        //public DbSet<Song> Songs { get; set; }
        //public DbSet<SongGenre> songGenres { get; set; }
        //public DbSet<User> Users { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<User>().ToTable("User");
        //    modelBuilder.Entity<Album>().ToTable("Album");
        //    modelBuilder.Entity<Artist>().ToTable("Artist").Property(p => p.Name).IsRequired();
        //    modelBuilder.Entity<AlbumGenre>().ToTable("AlbumGenre");
        //    modelBuilder.Entity<ArtistSong>().ToTable("ArtistSong");
        //    modelBuilder.Entity<Playlist>().ToTable("Playlist");
        //    modelBuilder.Entity<PlaylistCollection>().ToTable("PlaylistCollection");
        //    modelBuilder.Entity<PlaylistUser>().ToTable("PlaylistUser");
        //    modelBuilder.Entity<Song>().ToTable("Song").Property(p => p.Name).IsRequired();
        //    modelBuilder.Entity<SongGenre>().ToTable("SongGenre");
        //    modelBuilder.Entity<Genre>().ToTable("Genre").Property(p => p.Name).IsRequired();
        //}
    }
}
