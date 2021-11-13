﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Models
{
    [Table("Song", Schema = "webApp")]
    public class Song
    {
        [Key]
        public int SongID { get; set; }
        public string Name { get; set; }
        public int DurationSong { get; set; }
        public string FileType { get; set; }

        public ICollection<Album> Albums { get; set; }
        public ICollection<User> Users { get; set; }
        public SongGenre SongGenres { get; set; }
        public PlaylistCollection PlaylistCollections { get; set; }
        public ArtistSong ArtistSongs { get; set; }
    }
}
