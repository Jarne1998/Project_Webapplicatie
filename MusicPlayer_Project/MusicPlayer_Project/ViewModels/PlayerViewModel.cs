using MusicPlayer_Project.Models;
using System.Collections.Generic;

namespace MusicPlayer_Project.ViewModels
{
    public class PlayerViewModel
    {
        public List<Song> Songs { get; set; }

        public int SongID { get; set; }
        public string Name { get; set; }

        public string URL { get; set; }

        public PlayerViewModel()
        {

        }
    }
}
