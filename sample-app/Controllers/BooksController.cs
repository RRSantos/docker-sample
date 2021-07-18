using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sample_app.Models;

namespace sample_app.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Book> allBooks = new List<Book>();
            allBooks.Add(new Book() {Id = 1, Name = "First Book"});
            allBooks.Add(new Book() {Id = 2, Name = "Second Book"});
            allBooks.Add(new Book() {Id = 3, Name = "Third Book"});

            return View(allBooks);
            

        }
    }
}
