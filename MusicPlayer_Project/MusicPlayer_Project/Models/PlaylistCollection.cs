using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Models
{
    [Table("PlaylistCollection", Schema = "webApp")]
    public class PlaylistCollection
    {
        [Key]
        public int PlaylistCollectionID { get; set; }
        public int PlaylistID { get; set; }
        public int SongID { get; set; }

        public Playlist Playlist { get; set; }
        public Song Song { get; set; }
    }
}
