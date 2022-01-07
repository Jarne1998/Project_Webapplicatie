using MusicPlayer_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicPlayer_Project.ViewModels
{
    public class SongDetailViewModel
    {
        public string Name { get; set; }

        public string NamePlaylist { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        public List<Song> Songs { get; set; }

        public SongDetailViewModel()
        {

        }
    }
}
