using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World");
        }
    }

    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the About controller response");
        }
    }
}