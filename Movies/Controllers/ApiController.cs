using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Collections.Generic;
using Movies.Models;
using Movies.Services;

namespace Movies.Controllers
{
    public class ApiController : Controller
    {
        private readonly IMovieService _movieService;

        public ApiController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: /Api/Fetch/
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

        public JsonResult FetchCat()
        {
            var catList = GetCategories();
            return Json(catList);
        }

        private List<Category> GetCategories()
        {
            var catList = _movieService.GetCategories();
            return catList;
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