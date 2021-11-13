﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Models
{
    [Table("Playlist", Schema = "webApp")]
    public class Playlist
    {
        [Key]
        public int PlaylistID { get; set; }
        public DateTime DateAdded { get; set; }
        public string Name { get; set; }
        public int SongsInPlaylist { get; set; }

        public PlaylistCollection PlaylistCollections { get; set; }
        public PlaylistUser PlaylistUsers { get; set; }
    }
}
