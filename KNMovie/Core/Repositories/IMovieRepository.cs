using KNMovie.Core.Repositories;
using KNMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KNMovie.Data.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetAllWithGenreIdAsync(int genreId);
        Task<IEnumerable<Movie>> GetAllWithCityIdAsync(int cityId);
        Task<IEnumerable<Movie>> GetAllWithMultiplexIdAsync(int multiplexId);
        Task<Movie> GetWithMovieIdAsync(int movieId);
        Task<IEnumerable<Movie>> GetAllMovieAsync();


    }
}
