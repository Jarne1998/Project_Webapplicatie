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

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        public PlaylistDetailViewModel()
        {

        }
    }
}
