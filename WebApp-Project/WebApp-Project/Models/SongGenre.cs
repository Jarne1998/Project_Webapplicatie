using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Project.Models
{
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
