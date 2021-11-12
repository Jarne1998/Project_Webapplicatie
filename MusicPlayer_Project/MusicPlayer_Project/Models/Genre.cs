using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Models
{
    [Table("Genre", Schema = "webApp")]
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        public string Name { get; set; }
    }
}
