﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Models
{
    [Table("PlaylistUser", Schema = "webApp")]
    public class PlaylistUser
    {
        [Key]
        public int PlaylistUserID { get; set; }
        public int UserID { get; set; }
        public int PlaylistID { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }
}
