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
        Task<Movie> CreateMusic(Movie newMovie);
        Task UpdateMusic(Movie movieToBeUpdated, Movie movie);
        Task DeleteMusic(Movie movie);
    }
}
