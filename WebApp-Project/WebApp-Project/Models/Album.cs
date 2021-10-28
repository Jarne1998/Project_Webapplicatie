using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Project.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }
        public string Naam { get; set; }
        [Display(Name = "Datum release")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public int SongID { get; set; }
        public int ArtistID { get; set; }

        public Song Song { get; set; }
        public Artist Artist { get; set; }
    }
}
