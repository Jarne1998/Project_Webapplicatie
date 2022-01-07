using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Models
{
    [Table("Song", Schema = "webApp")]
    public class Song
    {
        [Key]
        public int SongID { get; set; }
        [Display(Name = "Name Song")]
        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please enter the title of the song")]
        public string Name { get; set; }
        public int DurationSong { get; set; }
        [Display(Name = "Name Song")]
        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please enter the title of the song")]
        public string URL { get; set; }
        public Nullable<int> FileSize { get; set; }

        public Album Album { get; set; }
        public User User { get; set; }
        public ICollection<SongGenre> SongGenres { get; set; }
        public ICollection<PlaylistCollection> PlaylistCollections { get; set; }
        public ICollection<ArtistSong> ArtistSongs { get; set; }
    }
}
