using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllMyBooks.Controllers
{
    public class BookController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.title = "My Books";
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.title = "Add a Book";
            // TODO: Add functionality to Add a Book.
            return View();
        }
    }
}
