using Microsoft.AspNetCore.Identity;
using MusicPlayer_Project.Models;
using System.Collections.Generic;

namespace MusicPlayer_Project.ViewModels
{
    public class UserViewModel
    {
        public List<User> Users { get; set; }
    }
}
