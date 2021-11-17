using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            viewModel.Playlists = _context.Playlists.ToList();
            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            Playlist playlist = _context.Playlists.Where(prod => prod.PlaylistID == id).FirstOrDefault();

            if (playlist != null)
            {
                PlaylistDetailViewModel viewModel = new PlaylistDetailViewModel() { Name = playlist.Name };
                return View(viewModel);
            }
            else
            {
                PlaylistListViewModel vm = new PlaylistListViewModel();
                vm.Playlists = _context.Playlists.ToList();
                return View("Index", vm);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreatePlaylistViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(new Playlist()
                {
                    Name = viewModel.Name,
                    DateAdded = viewModel.DateCreated,
                });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlist = await _context.Playlists.FindAsync(id);
            if (playlist == null)
            {
                return NotFound();
            }

            EditPlaylistViewModel viewModel = new EditPlaylistViewModel()
            {
                PlaylistID = playlist.PlaylistID,
                DateAdded = playlist.DateAdded,
                Name = playlist.Name
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditPlaylistViewModel viewModel)
        {
            if (id != viewModel.PlaylistID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Playlist klant = new Playlist()
                    {
                        PlaylistID = viewModel.PlaylistID,
                        Name = viewModel.Name,
                        DateAdded = viewModel.DateAdded
                    };
                    _context.Update(klant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Playlists.Any(e => e.PlaylistID == viewModel.PlaylistID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }
    }
}
