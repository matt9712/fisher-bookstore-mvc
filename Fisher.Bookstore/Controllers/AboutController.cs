using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return return View();
        }
        public IActionResult History()
        {
            return Content("This is the about controller’s history action.");
        }
        public IActionResult Location()
        {
            return Content("This is the about controller’s location action.");
        }
    }
}