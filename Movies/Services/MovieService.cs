using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Movies.Models;

namespace Movies.Services
{
    public class MovieService : IMovieService
    {

        private List<Movie> moviesList = new List<Movie> {
            new Movie {Id = 1, Title = "Star Wars: The Rise of Skywalker", Year = 2019, Description = "The surviving members of the resistance face the First Order once again, and the legendary conflict between the Jedi and the Sith reaches its peak bringing the Skywalker saga to its end.", Rating = 7, CategoryId = 3},
            new Movie {Id = 2, Title = "The Shawshank Redemption", Year = 1994, Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", Rating = 9, CategoryId = 3},
            new Movie {Id = 3, Title = "The Godfather", Year = 1972, Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", Rating = 9, CategoryId = 3},
            new Movie {Id = 4, Title = "Avengers: Endgame", Year = 2019, Description = "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.", Rating = 8, CategoryId = 3},
            new Movie {Id = 5, Title = "Asi", Year = 2002, Description = "JEjejejejejeje", Rating = 10, CategoryId = 3},
            new Movie {Id = 6, Title = "Asi", Year = 2002, Description = "JEjejejejejeje", Rating = 10, CategoryId = 3},
            new Movie {Id = 7, Title = "Asi", Year = 2002, Description = "JEjejejejejeje", Rating = 10, CategoryId = 3},
            new Movie {Id = 8, Title = "Asi", Year = 2002, Description = "JEjejejejejeje", Rating = 10, CategoryId = 3},
            new Movie {Id = 9, Title = "Asi", Year = 2002, Description = "JEjejejejejeje", Rating = 10, CategoryId = 3},
            new Movie {Id = 10, Title = "Asi", Year = 2002, Description = "JEjejejejejeje", Rating = 10, CategoryId = 3},
            new Movie {Id = 11, Title = "Asi", Year = 2002, Description = "JEjejejejejeje", Rating = 10, CategoryId = 3}
        };
        public List<Movie> GetAllMovies()
        {
            return moviesList;
        }
        
        public Movie GetMovieById(int id)
        {
            for (int i = 0; i < moviesList.Count; i++)
            {
                if (moviesList[i].Id == id)
                {
                    return moviesList[i];
                }
            }
            return null;
        }
    }
}