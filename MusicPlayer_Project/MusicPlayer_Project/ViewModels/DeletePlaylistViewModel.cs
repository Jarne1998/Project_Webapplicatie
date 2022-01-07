using System;
using System.ComponentModel.DataAnnotations;

namespace MusicPlayer_Project.ViewModels
{
    public class DeletePlaylistViewModel
    {
        public string PlaylistName { get; set; }
        [DataType(DataType.Date)]
        //public DateTime MyProperty { get; set; }
        public int PlaylistID { get; set; }
    }
}
