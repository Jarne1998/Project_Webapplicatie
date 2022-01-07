using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using MusicPlayer_Project.Data;
using MusicPlayer_Project.Models;
using MusicPlayer_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Controllers
{
    public class PlaylistController : Controller
    {
        private readonly MusicPlayer_ProjectContext _context;

        public PlaylistController( MusicPlayer_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            PlaylistListViewModel viewModel = new PlaylistListViewModel();
            viewModel.Playlists = _context.Playlists.ToList();
            return View(viewModel);
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
                Playlist playlist = new Playlist()
                {
                    NamePlaylist = viewModel.NamePlaylist,
                    DateAdded = viewModel.DateCreated,
                };
                _context.Add(playlist);

                Song song = new Song()
                {
                    URL = viewModel.URL,
                    Name = viewModel.Name
                };
                _context.Add(song);

                await _context.SaveChangesAsync();

                _context.Add(new PlaylistCollection()
                {
                    PlaylistID = playlist.PlaylistID,
                    SongID = song.SongID
                });

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            Song song = new Song();

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
                NamePlaylist = playlist.NamePlaylist,
                Name = song.Name,
            };

            return View(viewModel);
        }

        public IActionResult AddSongToPlaylist()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddSongToPlaylist(int id)
        {
            var song = await _context.Songs.FirstOrDefaultAsync(s => s.SongID == id);
            if (song == null)
            {
                return NotFound();
            }

            AddExtraSongToPlaylistViewModel viewModel = new AddExtraSongToPlaylistViewModel()
            {
                Name = song.Name,
                URL = song.URL
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
                    Playlist playlist = new Playlist()
                    {
                        PlaylistID = viewModel.PlaylistID,
                        NamePlaylist = viewModel.NamePlaylist,
                        DateAdded = viewModel.DateAdded
                    };
                    _context.Update(playlist);
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

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlist = await _context.Playlists.FirstOrDefaultAsync(p => p.PlaylistID == id);
            if (playlist == null)
            {
                return NotFound();
            }

            DeletePlaylistViewModel viewModel = new DeletePlaylistViewModel()
            {
                PlaylistName = playlist.NamePlaylist,
                PlaylistID = playlist.PlaylistID
            };

            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var playlist = await _context.Playlists.FindAsync(id);
            _context.Playlists.Remove(playlist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
