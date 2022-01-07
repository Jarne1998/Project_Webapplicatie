using System;
using System.ComponentModel.DataAnnotations;

namespace MusicPlayer_Project.ViewModels
{
    public class EditSongViewModel
    {
        public int SongID { get; set; }
        public string Name { get; set; }

        public string URL { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
    }
}
