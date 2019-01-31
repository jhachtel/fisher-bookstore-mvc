using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); //Content("Hello World");
        }
    }
}