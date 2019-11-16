using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agendo.Data;
using Agendo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agendo.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Represents the Database context
        /// </summary>
        private readonly AgendoContext _context;

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

    }
}