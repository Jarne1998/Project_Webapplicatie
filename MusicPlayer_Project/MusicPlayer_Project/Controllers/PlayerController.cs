using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace MusicPlayer_Project.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile postedFile)
        {
            using (var ms = new MemoryStream())
            {
                postedFile.CopyTo(ms);
                var fileBytes = ms.ToArray();
                ViewBag.Data = Convert.ToBase64String(fileBytes);
            }
            return View();
        }
    }
}
