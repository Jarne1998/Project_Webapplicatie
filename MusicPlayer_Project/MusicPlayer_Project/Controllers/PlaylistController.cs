using Microsoft.AspNetCore.Mvc;
using MusicPlayer_Project.Data;
using MusicPlayer_Project.Models;
using MusicPlayer_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Controllers
{
    public class PlaylistController : Controller
    {
        private readonly MusicPlayer_ProjectContext _context;

        public PlaylistController(MusicPlayer_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            PlaylistListViewModel viewModel = new PlaylistListViewModel();
            //viewModel.Playlists = _context.Playlists
            return View(viewModel);
        }
    }
}
