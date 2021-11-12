using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Models
{
    [Table("AlbumGenre", Schema = "webApp")]
    public class AlbumGenre
    {
        [Key]
        public int AlbumGenreID { get; set; }
        public int AlbumID { get; set; }
        public int GenreID { get; set; }

        public Album Album { get; set; }
        public Genre Genre { get; set; }
    }
}
