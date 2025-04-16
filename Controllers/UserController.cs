using Microsoft.AspNetCore.Mvc;
using movieTasks.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace movieTasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            User user = new User();
            return user.Read();
        }

        // POST- login
        [HttpPost("logIn")]
        public bool Login([FromBody] User user)
        {
            return user.Login();
        }

        // POST- register
        [HttpPost("register")]
        public bool Register([FromBody] User user)
        {
            return user.Register();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
