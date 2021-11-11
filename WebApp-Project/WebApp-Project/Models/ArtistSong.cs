using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Project.Models
{
    [Table("ArtistSong", Schema = "webApp")]
    public class ArtistSong
    {
        [Key]
        public int ArtistSongID { get; set; }
        public int ArtistID { get; set; }
        public int SongID { get; set; }

        public Artist Artist { get; set; }
        public Song Song { get; set; }
    }
}
