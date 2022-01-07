using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicPlayer_Project.Data;
using MusicPlayer_Project.Models;
using MusicPlayer_Project.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer_Project.Controllers
{
    //[Authorize(Roles = "User")]
    public class SongController : Controller
    {
        private readonly MusicPlayer_ProjectContext _context;

        public SongController(MusicPlayer_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            SongListViewModel viewModel = new SongListViewModel();
            viewModel.Songs = _context.Songs.ToList();
            return View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            List<Song> songCollections = new List<Song>();

            songCollections = await _context.Songs.Where(prod => prod.SongID == id).ToListAsync();


            if (songCollections != null)
            {
                SongDetailViewModel viewModel = new SongDetailViewModel()
                {
                    Songs = songCollections

                };

                return View(viewModel);
            }
            else
            {
                SongListViewModel vm = new SongListViewModel();
                vm.Songs = _context.Songs.ToList();
                return View("Index", vm);
            }
        }

        public async Task<IActionResult> Search(SongListViewModel viewModel)
        {
            IQueryable<Song> queryableKlanten = _context.Songs.AsQueryable();

            if (!string.IsNullOrEmpty(viewModel.NameSearch))
            {
                queryableKlanten = queryableKlanten.Where(k => k.Name.StartsWith(viewModel.NameSearch));
            }

            viewModel.Songs = await queryableKlanten.ToListAsync();

            return View("Index", viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddSongViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Song song = new Song()
                {
                    Name = viewModel.Name,
                    URL = viewModel.URL,
                    DurationSong = viewModel.DurationSong,
                };
                _context.Add(song);

                Artist artist = new Artist()
                {
                    Name = viewModel.Name
                };
                _context.Add(song);

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


            EditSongViewModel viewModel = new EditSongViewModel()
            {
                Name = song.Name
            };

            await _context.SaveChangesAsync();

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditSongViewModel viewModel)
        {
            if (id != viewModel.SongID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Song song = new Song()
                    {
                        SongID = viewModel.SongID,
                        Name = viewModel.Name,
                    };
                    _context.Update(song);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Songs.Any(e => e.SongID == viewModel.SongID))
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

            var song = await _context.Songs.FirstOrDefaultAsync(p => p.SongID == id);
            if (song == null)
            {
                return NotFound();
            }

            DeleteSongViewModel viewModel = new DeleteSongViewModel()
            {
                Name = song.Name,
                SongID = song.SongID
            };

            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var song = await _context.Songs.FindAsync(id);
            _context.Songs.Remove(song);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
