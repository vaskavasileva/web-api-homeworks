using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie_App.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movie_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        // GET: api/<MoviesController>
        [HttpGet]
        public ActionResult<List<Movie>> GetAllMovies()
        {
            return Ok(StaticDb.GetAllMovies());
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public ActionResult<Movie> GetById([FromRoute] int id)
        {
            var movie = StaticDb.GetAllMovies().SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return BadRequest("No movie with that id found");
            }
            return Ok(movie);
        }

        // POST api/<MoviesController>
        [HttpPost]
        public ActionResult Post([FromBody] Movie movie)
        {
            var movieCheck = StaticDb.GetAllMovies().SingleOrDefault(m => m.Id == movie.Id);
            if (movieCheck != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Movie with that id already exists");
            }
            movie.Id = StaticDb.GetAllMovies().Count + 1;
            StaticDb.GetAllMovies().Add(movie);
            return Ok("Movie added successfully");
        }

        [HttpGet("getMovieByName")]
        public ActionResult<Movie> GetMovieByName([FromQuery] string name)
        {
            var movie = StaticDb.GetAllMovies().SingleOrDefault(m => m.Name.ToLower() == name.ToLower());
            if (movie == null)
            {
                return BadRequest("No such movie exists");
            }
            return Ok(movie);
        }

        [HttpGet("{id}/getArtistsFromMovie")]
        public ActionResult<List<string>> GetArtistsFromMovie([FromRoute] int id, [FromQuery] string name)
        {
            var movie = StaticDb.GetAllMovies().SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return BadRequest("No such movie exists");
            }
            var artistsContainingName = new List<string>();
            foreach (var artistName in movie.Artists)
            {
                if (artistName.ToLower().StartsWith(name.ToLower()))
                {
                    artistsContainingName.Add(artistName);
                }
            }
            if (artistsContainingName.Count < 1)
            {
                return StatusCode(StatusCodes.Status404NotFound, "No artists that contain that name were found");
            }
            return Ok(artistsContainingName);
        }

        [HttpGet("checkLanguage")]
        public ActionResult<string,List<Movie>> CheckLanguage([FromHeader(Name ="Accept-Language"] string language )
        {
            var allMovies = StaticDb.GetAllMovies();
            if (language == "mk-MK")
            {
                return Ok($"Во респонсот се вклучени сите филмови кои ги чуваме во датабаза", allMovies);
            }
            return Ok("In the response are included all artists that are stored in the database", allMovies);
        }
    }
}
