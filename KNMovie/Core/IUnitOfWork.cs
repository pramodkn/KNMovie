using KNMovie.Data.Repositories;
using System;
using System.Threading.Tasks;

namespace KNMovie.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository Movie { get; }
        Task<int> CommitAsync();
    }
}
