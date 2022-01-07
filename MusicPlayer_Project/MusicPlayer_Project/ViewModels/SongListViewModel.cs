using MusicPlayer_Project.Models;
using System.Collections.Generic;

namespace MusicPlayer_Project.ViewModels
{
    public class SongListViewModel
    {
        public List<Song> Songs { get; set; }
        public string NameSearch { get; set; }
    }
}
