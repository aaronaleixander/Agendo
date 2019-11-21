using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agendo.Data;
using Agendo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agendo.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Provides access to session data for the current user.
        /// </summary>
        private readonly IHttpContextAccessor _httpAccessor;


        /// <summary>
        /// Represents the Database context
        /// </summary>
        private readonly AgendoContext _context;

        public AccountController(AgendoContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _httpAccessor = accessor;
        }

        // REGISTER

        [HttpGet]
       public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserAccount user)
        {
            if (ModelState.IsValid)
            {
                await UserAccountDb.Add(_context, user);
                TempData["Message"] = "Registration Successful.";
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }

        // LOGIN

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserAccount user = await UserAccountDb.IsLoginValid(model, _context);
                if (user != null)
                {
                    TempData["Message"] = "Logged in sucessfully";

                    // Create current session for the user.
                    _httpAccessor.HttpContext.Session.SetInt32("UserID", user.UserID);
                    _httpAccessor.HttpContext.Session.SetString("UserName", user.UserName);


                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Credentials Invalid
                    ModelState.AddModelError(string.Empty, "Im sorry your login was invalid.");
                }
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            _httpAccessor.HttpContext.Session.Clear();
            TempData["Message"] = " You have been logged out";
            return RedirectToAction("Index", "Home");
        }
    }
}
