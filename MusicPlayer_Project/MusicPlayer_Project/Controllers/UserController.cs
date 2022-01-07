using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        public UserManager<User> _userManager;
        public RoleManager<IdentityRole> _roleManager;
        private readonly MusicPlayer_ProjectContext _context;

        public UserController( MusicPlayer_ProjectContext context, UserManager<User> userManger, RoleManager<IdentityRole> roleManger)
        {
            _context = context;
            _userManager = userManger;
            _roleManager = roleManger;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            UserViewModel viewModel = new UserViewModel()
            {
                Users = _userManager.Users.ToList()
            };
            return View(viewModel);
        }

        public async Task<IActionResult> Details(string id)
        {
            User user = _userManager.Users.Where(u => u.Id == id).FirstOrDefault();

            if (user != null)
            {
                UserDetailViewModel viewModel = new UserDetailViewModel()
                {
                    //UserID = user.Id,
                    Name = user.Name,
                    UserName = user.UserName,
                    Joined = user.Joined,
                };

                return View(viewModel);
            }
            else
            {
                UserViewModel vm = new UserViewModel();
                //vm.Users = _context.Users.ToList();
                return View("Index", vm);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CreateUserViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Name = viewModel.Name,
                    Birthday = viewModel.Birthday,
                    UserName = viewModel.Email,
                    Email = viewModel.Email,
                };

                IdentityResult result = await _userManager.CreateAsync(user, viewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            User user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User not found");
            }

            return View("Index", _userManager.Users.ToList());
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.MusicUser.FindAsync(id);
            _context.MusicUser.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult GrantPermissions()
        {
            GrantPermissionsViewModel viewModel = new GrantPermissionsViewModel()
            {
                Users = new SelectList(_userManager.Users.ToList(), "Id", "Username"),
                Rolls = new SelectList(_roleManager.Roles.ToList(), "Id", "Name")
            };

            return View(viewModel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ActionResult(GrantPermissionsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(viewModel.userID);
                IdentityRole role = await _roleManager.FindByIdAsync(viewModel.RollID);

                if (user != null && role != null)
                {
                    IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "User or role not found");
                }
            }

            return View(viewModel);
        }
    }
}
