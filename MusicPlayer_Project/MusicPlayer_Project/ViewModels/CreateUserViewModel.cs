using System;
using System.ComponentModel.DataAnnotations;

namespace MusicPlayer_Project.ViewModels
{
    public class CreateUserViewModel
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
