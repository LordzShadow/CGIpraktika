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

        // GET: /Api/Fetch/, saadab filmid
        public JsonResult Fetch()
        {
            var movies = GetMovies();
            return Json(movies); 
        }
        
        // GET: /Api/FetchById, ei ole hetkel kasutuses, saadab ühe filmi id järgi
        public JsonResult FetchById(int id)
        {
            var movie = GetMovieById(id);
            return Json(movie);
        }
        // GET: /Api/FetchCat, saadab kategooriad
        public JsonResult FetchCat()
        {
            var catList = GetCategories();
            return Json(catList);
        }
        // Funktsioon, mis kasutab service-it, et saada kategooriad
        private List<Category> GetCategories()
        {
            var catList = _movieService.GetCategories();
            return catList;
        }

        // Funktsioon, mis kasutab service-it, et saada filmid
        private List<Movie> GetMovies()
        {
            var items = _movieService.GetAllMovies();
            return items;
        }

        // Funktsioon, mis kasutab service-it, et saada film id järgi
        private Movie GetMovieById(int id) {
            var movie = _movieService.GetMovieById(id);

            return movie;
        }

    }
}