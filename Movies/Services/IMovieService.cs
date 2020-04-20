using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Movies.Models;

namespace Movies.Services
{
    // Interface servie jaoks.
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        List<Category> GetCategories();
    }
}