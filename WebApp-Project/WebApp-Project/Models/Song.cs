using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Project.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }
        public string Name { get; set; }
        public int DurationSong { get; set; }
        public string FileType { get; set; }
    }
}
