using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Project.Models
{
    public class PlaylistUser
    {
        [Key]
        public int PlaylistUserID { get; set; }
        public int UserID { get; set; }
        public int PlaylistID { get; set; }

        public User User { get; set; }
        public Playlist Playlist { get; set; }
    }
}
