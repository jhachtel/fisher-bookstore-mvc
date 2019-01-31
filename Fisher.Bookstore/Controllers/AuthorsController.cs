using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View(); //Content("This is the Authors controller response for Index");
        }
        public IActionResult Featured()
        {
            return View(); //Content("This is the Authors controller response for Featured");
        }
    }
}