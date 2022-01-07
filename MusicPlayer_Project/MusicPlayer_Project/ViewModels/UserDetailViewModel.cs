using MusicPlayer_Project.Models;
using System;
using System.Collections.Generic;

namespace MusicPlayer_Project.ViewModels
{    public class UserDetailViewModel
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime Joined { get; set; }
        public List<User> Users { get; set; }

        public UserDetailViewModel()
        {

        }
    }
}
