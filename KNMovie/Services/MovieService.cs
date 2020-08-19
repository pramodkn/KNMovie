using KNMovie.Core.Repositories;
using KNMovie.Core.Services;
using KNMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KNMovie.Services
{
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MovieService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<int> CreateMovie(Movie newMovie)
        {
            return await _unitOfWork.Movie.AddAsync(newMovie);
        }

        public Task DeleteMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetAllMovie()
        {
            return await _unitOfWork.Movie.GetAllMovieAsync();
        }

        public Task<Movie> GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMovie(Movie movieToBeUpdated, Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
