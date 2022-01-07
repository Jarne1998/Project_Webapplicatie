using System;

namespace MusicPlayer_Project.ViewModels
{
    public class AddExtraSongToPlaylistViewModel
    {
        public int SongID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
