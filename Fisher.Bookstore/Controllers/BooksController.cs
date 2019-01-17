using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Books controller response for Index");
        }
        public IActionResult New()
        {
            return Content("This is the Books controller response for New");
        }
        public IActionResult Best()
        {
            return Content("This is the Books controller response for Best");
        }
    }
}