using MusicPlayer_Project.Models;
using System.Collections.Generic;

namespace MusicPlayer_Project.ViewModels
{
    public class HomeViewModel
    {
        public List<Song> Songs { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<User> Users { get; internal set; }
    }
}
