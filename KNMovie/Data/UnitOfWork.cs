using KNMovie.Core;
using KNMovie.Core.Repositories;
using KNMovie.Data.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KNMovie.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private MovieRepository _movieRepository;
        private readonly IConfiguration _config;

        public UnitOfWork(MovieAPIContext context, IConfiguration config)
        {
            _config = config;

        }

        public IMovieRepository Movie => _movieRepository ?? new MovieRepository(_config);
        
    }
}
