using Dapper;
using KNMovie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KNMovie.Data.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        private readonly IConfiguration _config;

        public MovieRepository(IConfiguration config)
            : base()
        {
            _config = config;
        }
        public override async Task<int> AddAsync(Movie movie)
        {
            var sqlInsert = "INSERT INTO Movie (Title, ReleaseDate, RunningTime) Values (@Title, @ReleaseDate, @RunningTime);";

            using (IDbConnection conn = Connection)
            {
                conn.Open();
                var affectedRows = await conn.ExecuteAsync(sqlInsert, movie);
                return affectedRows;
            }
        }
        

        public async Task<IEnumerable<Movie>> GetAllMovieAsync()
        {
            using (IDbConnection conn = Connection)
            {
                string queryManyToManyMovieWithGenre = @"select M.*,G.Id as GenreId, G.Name
                                    from Movie M 
                                    left join MovieGenre as MG on MG.MovieId = M.Id
                                    left join Genre as G on G.Id = MG.GenreId";

                conn.Open();
                var result = await conn.QueryAsync<Movie, Genre, Movie>(queryManyToManyMovieWithGenre, (movie, genre) =>
                {
                    movie.Genre.Add(genre);
                    return movie;
                },
                splitOn: "GenreId");
                var movieList = result.GroupBy(p => p.Id).Select(g =>
                {
                    var groupedPost = g.First();
                    groupedPost.Genre = g.Select(p => p.Genre.Single()).ToList();
                    return groupedPost;
                });
                return movieList.ToList();
            }
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

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("ConnectionStringMSSQL"));
            }
        }
    }

}
