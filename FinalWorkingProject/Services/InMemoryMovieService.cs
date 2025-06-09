using System.Collections.Generic;
using System.Threading.Tasks;
using FinalWorkingProject.Models;

namespace FinalWorkingProject.Services
{
    public class InMemoryMovieService
    {
        private readonly List<Movie> _movies = new List<Movie>();

        public async Task<List<Movie>> GetAllAsync()
        {
            return await Task.Run(() => _movies);
        }

        public async Task AddAsync(Movie movie)
        {
            movie.Id = Guid.NewGuid().ToString(); // Генерира уникално ID

            await Task.Run(() => _movies.Add(movie));
        }
    }
}