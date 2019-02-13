using System;
using Microsoft.AspNetCore.Mvc;

using Fisher.Bookstore.Models;

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
            var featuredAuthor = new Author()
            {
                AuthorId = 1,
                Name = "J.K. Rowling"
            };
            return View(featuredAuthor); //Content("This is the Authors controller response for Featured");
        }
    }
}