using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Models
{
    [Table("SongGenre", Schema = "webApp")]
    public class SongGenre
    {
        [Key]
        public int SongGenreID { get; set; }
        public int GenreID { get; set; }
        public int SongID { get; set; }

        public Genre Genre { get; set; }
        public Song Song { get; set; }
    }
}
