using Microsoft.AspNetCore.Mvc;

namespace MusicPlayer_Project.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
