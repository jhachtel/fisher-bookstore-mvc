using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the About controller response for Index");
        }
        public IActionResult History()
        {
            return Content("This is the About controller response for History");
        }
        public IActionResult Location()
        {
            return Content("This is the About controller response for Location");
        }
    }
}