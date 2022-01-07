using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MusicPlayer_Project.Data;
using MusicPlayer_Project.Models;
using MusicPlayer_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MusicPlayer_ProjectContext _context;

        public HomeController(ILogger<HomeController> logger, MusicPlayer_ProjectContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel();
            viewModel.Playlists = _context.Playlists.ToList();
            viewModel.Songs = _context.Songs.ToList();
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Playlist()
        {
            return View();
        }

        public IActionResult Song()
        {
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            List<PlaylistCollection> playlistCollections = new List<PlaylistCollection>();

            playlistCollections = await _context.PlaylistCollections.Where(prod => prod.PlaylistID == id).Include(s => s.Song).Include(p => p.Playlist).ToListAsync();


            if (playlistCollections != null)
            {
                PlaylistDetailViewModel viewModel = new PlaylistDetailViewModel()
                {
                    PlaylistCollections = playlistCollections,
                };

                return View(viewModel);
            }
            else
            {
                PlaylistListViewModel vm = new PlaylistListViewModel();
                vm.Playlists = _context.Playlists.ToList();
                return View("Index", vm);
            }
        }

        public async Task<IActionResult> SongDetails(int id)
        {
            List<Song> songCollections = new List<Song>();

            songCollections = await _context.Songs.Where(prod => prod.SongID == id).ToListAsync();


            if (songCollections != null)
            {
                SongDetailViewModel vm = new SongDetailViewModel()
                {
                    Songs = songCollections,
                };

                return View(vm);
            }
            else
            {
                SongListViewModel vm = new SongListViewModel();
                vm.Songs = _context.Songs.ToList();
                return View("Index", vm);
            }
        }
    }
}
