using KNMovie.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KNMovie.Data.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieAPIContext context)
            : base(context)
        { }

     
        private MovieAPIContext MovieAPIDBContext
        {
            get { return Context as MovieAPIContext; }
        }

        public async Task<IEnumerable<Movie>> GetAllMovieAsync()
        {
            return await MovieAPIDBContext.Movie
                 .Include(m => m.Genre)
                 .ToListAsync();
        }

        public Task<IEnumerable<Movie>> GetAllWithCityIdAsync(int cityId)
        {
            throw new NotImplementedException();

        }

        public Task<IEnumerable<Movie>> GetAllWithGenreIdAsync(int genreId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetAllWithMultiplexIdAsync(int multiplexId)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetWithMovieIdAsync(int movieId)
        {
            throw new NotImplementedException();
        }
    
    }

}
