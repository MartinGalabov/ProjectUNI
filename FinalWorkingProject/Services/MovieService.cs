using FinalWorkingProject.Models;
using FinalWorkingProject.Models;
using System.Collections.Generic;

namespace FinalWorkingProject.Services
{
    public class MovieService
    {

        public List<Movie> GetAllMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = "1", Title = "Inception", Genre = "Sci-Fi" },
                new Movie { Id = "2", Title = "The Matrix", Genre = "Action" }
            };
        }
    }
}