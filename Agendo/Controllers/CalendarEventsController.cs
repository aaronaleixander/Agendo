using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Agendo.Controllers
{
    public class CalendarEventsController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

    }
}