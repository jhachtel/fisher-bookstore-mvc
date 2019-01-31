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
            return View(); //Content("This is the Books controller response for Index");
        }

        [Route("new")]
        public IActionResult New()
        {
            return View(); //Content("This is the Books controller response for New");
        }

        [Route("best-sellers")]
        public IActionResult Best()
        {
            return View(); //Content("This is the Books controller response for Best");
        }
    }
}