using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Movies.Models;

namespace Movies.Services
{
    public class MovieService : IMovieService
    {

        private List<Movie> moviesList = new List<Movie> {
            new Movie {Id = 1, Title = "Star Wars: The Rise of Skywalker", Year = 2019, Description = "The surviving members of the resistance face the First Order once again, and the legendary conflict between the Jedi and the Sith reaches its peak bringing the Skywalker saga to its end.", Rating = 6.7, CategoryId = 3},
            new Movie {Id = 2, Title = "The Shawshank Redemption", Year = 1994, Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", Rating = 9.2, CategoryId = 2},
            new Movie {Id = 3, Title = "The Godfather", Year = 1972, Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", Rating = 9.1, CategoryId = 4},
            new Movie {Id = 4, Title = "Avengers: Endgame", Year = 2019, Description = "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.", Rating = 8.4, CategoryId = 3},
            new Movie {Id = 5, Title = "One Flew Over the Cuckoo's Nest", Year = 1975, Description = "A criminal pleads insanity and is admitted to a mental institution, where he rebels against the oppressive nurse and rallies up the scared patients.", Rating = 8.7, CategoryId = 2},
            new Movie {Id = 6, Title = "Once Upon a Time... in Hollywood", Year = 2019, Description = "A faded television actor and his stunt double strive to achieve fame and success in the film industry during the final years of Hollywood's Golden Age in 1969 Los Angeles.", Rating = 7.7, CategoryId = 1},
            new Movie {Id = 7, Title = "The Perks of Being a Wallflower", Year = 2012, Description = "An introvert freshman is taken under the wings of two seniors who welcome him to the real world.", Rating = 8.0, CategoryId = 5},
            new Movie {Id = 8, Title = "Good Will Hunting", Year = 1997, Description = "Will Hunting, a janitor at M.I.T., has a gift for mathematics, but needs help from a psychologist to find direction in his life.", Rating = 8.3, CategoryId = 2},
            new Movie {Id = 9, Title = "Inception", Year = 2010, Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", Rating = 8.8, CategoryId = 3},
            new Movie {Id = 10, Title = "The Matrix", Year = 1999, Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", Rating = 8.7, CategoryId = 3},
            new Movie {Id = 11, Title = "12 Angry Men", Year = 1957, Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence", Rating = 8.9, CategoryId = 2}
        };

        private List<Category> catList = new List<Category> {
            new Category {Id = 3, Name = "Action"},
            new Category {Id = 1, Name = "Comedy"},
            new Category {Id = 2, Name = "Drama"},
            new Category {Id = 4, Name = "Crime"},
            new Category {Id = 5, Name = "Romance"}
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

        public List<Category> GetCategories()
        {
            return catList;
        }
    }
}