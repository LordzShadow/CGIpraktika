using System;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year {get; set;}
        public string Description { get; set; }
        public double Rating { get; set; }
        public int CategoryId { get; set;}
    }
}