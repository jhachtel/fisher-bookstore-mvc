using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    [Route("authors")]
    public class AuthorsController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View(); //Content("This is the Authors controller response for Index");
        }
        [Route("featured")]
        public IActionResult Featured()
        {
            return View(); //Content("This is the Authors controller response for Featured");
        }
    }
}