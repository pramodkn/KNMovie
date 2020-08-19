using KNMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KNMovie.Core.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMovie();
        Task<Movie> GetMovieById(int id);
        Task<int> CreateMovie(Movie newMovie);
        Task UpdateMovie(Movie movieToBeUpdated, Movie movie);
        Task DeleteMovie(Movie movie);
    }
}
