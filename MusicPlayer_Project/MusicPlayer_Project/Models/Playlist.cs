using System;
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
        [Display(Name = "Date created")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        public string NamePlaylist { get; set; }
        public int SongsInPlaylist { get; set; }

        public ICollection<PlaylistCollection> PlaylistCollection { get; set; }
        public PlaylistUser PlaylistUser { get; set; }
    }
}
