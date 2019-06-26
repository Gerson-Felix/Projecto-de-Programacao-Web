using AutoMapper;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Vitty.DTOS;
using Vitty.Models;

namespace Vitty.Controllers.API
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public IMapper Mapper;

        public MoviesController()
        {
            _context = new ApplicationDbContext();

            var config = new MapperConfiguration(cfg =>
           {
               cfg.CreateMap<Movie, MovieDTO>();
               cfg.CreateMap<Genre, GenreDTO>();
               cfg.CreateMap<MovieDTO, Movie>();
           });

            Mapper = config.CreateMapper();
        }

        public IEnumerable<MovieDTO> GetMovies(string query = null)
        {
            var moviesQuery = _context.Movies
                .Include(m => m.Genre)
                .Where(m => m.NumberAvailable > 0);

            if (!String.IsNullOrWhiteSpace(query))
                moviesQuery = moviesQuery.Where(m => m.Name.Contains(query));

            var moviesDtos = Mapper.Map<List<MovieDTO>>(moviesQuery).ToList();
            
            return moviesDtos;
        }

        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDTO>(movie));
        }

        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDTO movieDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MovieDTO, Movie>(movieDTO);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDTO.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDTO);
        }

        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDTO movieDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                return NotFound();

            Mapper.Map(movieDTO, movieInDb);

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                return NotFound();

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
