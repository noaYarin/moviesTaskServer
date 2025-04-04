using Microsoft.AspNetCore.Mvc;
using movieTasks.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace movieTasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            Movie movie = new Movie();
            return movie.Read();
        }

        [HttpGet("searchByTitle")]
        public IEnumerable<Movie> GetByTitle(string title)
        {
            Movie movie = new Movie();
            return movie.GetByTitle(title);
        }

        [HttpGet("from/{startDate}/until/{endDate}")]
        public IEnumerable<Movie> GetByReleaseDate(DateTime startDate, DateTime endDate)
        {
            Movie movie = new Movie();
            return movie.GetByReleaseDate(startDate,endDate);
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MoviesController>
        [HttpPost]
        public bool Post([FromBody] Movie movie)
        {
            return movie.Insert();
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public bool Delete(string id)
        {
            Movie movie = new Movie();
           return movie.Delete(id);
        }
    }
}
