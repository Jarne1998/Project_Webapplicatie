using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.ViewModels
{
    public class CreatePlaylistViewModel
    {
        public string NamePlaylist { get; set; }

        public string Name { get; set; }

        public string URL { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        public IFormFile Image { get; set; }

        public IFormFile SongUpload { get; set; }
    }
}
