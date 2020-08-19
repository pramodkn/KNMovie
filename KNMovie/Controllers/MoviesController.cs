using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KNMovie.Core.Services;
using KNMovie.Data;
using KNMovie.Models;
using KNMovie.Models.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KNMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieAPIContext _context;
        private readonly IMovieService _movieService;

        public MoviesController(MovieAPIContext context, IMovieService movieService)
        {
            _context = context;
            this._movieService = movieService;

        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovie()
        {
            var movie = await _movieService.GetAllMovie();

            return movie.ToList();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movie = await _context.Movie.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }


        [HttpPut("{id}")]
        [Authorize(Roles = UserRoles.Admin)]
        public async Task<IActionResult> PutMovie(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            _context.Entry(movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]
        public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        {

            var returned = await _movieService.CreateMovie(movie);

            //_context.Movie.Add(movie);
            //await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie", new { AffectedRow = returned }, movie);
        }


        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]

        public async Task<ActionResult<Movie>> DeleteMovie(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();

            return movie;
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}