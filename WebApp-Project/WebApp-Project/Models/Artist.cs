using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Project.Models
{
    public class Artist
    {
        [Key]
        public int ArtistID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
    }
}
