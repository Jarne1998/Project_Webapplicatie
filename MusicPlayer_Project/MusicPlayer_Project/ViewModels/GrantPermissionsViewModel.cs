using Microsoft.AspNetCore.Mvc.Rendering;

namespace MusicPlayer_Project.ViewModels
{
    public class GrantPermissionsViewModel
    {
        public SelectList Users { get; set; }
        public SelectList Rolls { get; set; }
        public string userID { get; set; }
        public string RollID { get; set; }
    }
}
