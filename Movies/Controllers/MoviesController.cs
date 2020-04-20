using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Collections.Generic;
using Movies.Models;
using Movies.Services;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {

        // GET: /Movies/, returns Index view.
        public IActionResult Index()
        {
            return View();
        }
    }
}