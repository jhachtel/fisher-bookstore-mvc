using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    [Route("about")]
    public class AboutController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View(); //Content("This is the About controller response for Index");
        }
        [Route("history")]
        public IActionResult History()
        {
            return View(); //Content("This is the About controller response for History");
        }
        [Route("location")]
        public IActionResult Location()
        {
            return View(); //Content("This is the About controller response for Location");
        }
    }
}