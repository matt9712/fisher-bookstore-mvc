using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    [Route("books")]
    public class BooksController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return Content("This is the books controller’s index action.");
        }
        [Route("new")]
        public IActionResult New()
        {
            return Content("This is the books controller’s new action.");
        }
        [Route("best-sellers")]
        public IActionResult Best()
        {
            return Content("This is the books controller’s best action.");
        }
    }
}