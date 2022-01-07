using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Models
{
    [Table("Artist", Schema = "webApp")]
    public class Artist
    {
        [Key]
        public int ArtistID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }

        public ICollection<Album> Albums { get; set; }
        public ICollection<ArtistSong> ArtistSongs { get; set; }
    }
}
