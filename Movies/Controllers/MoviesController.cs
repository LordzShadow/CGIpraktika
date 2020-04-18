using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Collections.Generic;
using Movies.Models;
using Movies.Services;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: /Movies/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Movies/Fetch/
        public JsonResult Fetch()
        {
            var movies = GetMovies();
            return Json(movies); 
        }

        public JsonResult FetchById(int id)
        {
            var movie = GetMovieById(id);
            return Json(movie);
        }

        public string Test(string name, int ID = 1) {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

        private List<Movie> GetMovies()
        {
            var items = _movieService.GetAllMovies();
            return items;
        }

        private Movie GetMovieById(int id) {
            var movie = _movieService.GetMovieById(id);

            return movie;
        }

    }
}