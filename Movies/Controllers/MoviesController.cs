using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Collections.Generic;
using Movies.Models;
using Movies.Services;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        public MoviesController()
        {
        }

        // GET: /Movies/
        public IActionResult Index()
        {
            return View();
        }
    }
}