using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Models
{
    [Table("User", Schema = "webApp")]
    public class User : IdentityUser
    {
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Joined { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public ICollection<PlaylistUser> PlaylistUsers { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
