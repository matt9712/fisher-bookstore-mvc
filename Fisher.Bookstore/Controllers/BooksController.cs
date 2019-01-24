using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the books controller’s index action.");
        }
        public IActionResult New()
        {
            return Content("This is the books controller’s new action.");
        }
        public IActionResult Best()
        {
            return Content("This is the books controller’s best action.");
        }
    }
}