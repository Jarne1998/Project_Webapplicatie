using System.ComponentModel.DataAnnotations;

namespace MusicPlayer_Project.ViewModels
{
    public class DeleteSongViewModel
    {
        public string Name { get; set; }
        [DataType(DataType.Date)]
        //public DateTime MyProperty { get; set; }
        public int SongID { get; set; }
    }
}
