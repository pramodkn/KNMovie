using KNMovie.Core;
using KNMovie.Core.Repositories;
using KNMovie.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KNMovie.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieAPIContext _context;
        private MovieRepository _movieRepository;

        public UnitOfWork(MovieAPIContext context)
        {
            this._context = context;
        }


        public IMovieRepository Movie => _movieRepository ?? new MovieRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
