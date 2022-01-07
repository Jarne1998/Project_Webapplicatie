using MusicPlayer_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.ViewModels
{
    public class PlaylistDetailViewModel
    {
        public string Name { get; set; }

        public string NamePlaylist { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        public List<PlaylistCollection> PlaylistCollections { get; set; }

        public List<Song> Songs { get; set; }

        public PlaylistDetailViewModel()
        {

        }
    }
}
