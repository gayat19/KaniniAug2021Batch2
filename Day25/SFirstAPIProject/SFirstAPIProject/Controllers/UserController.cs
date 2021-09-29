using Microsoft.AspNetCore.Mvc;
using SFirstAPIProject.Models;
using SFirstAPIProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SFirstAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService userSevice)
        {
            _service = userSevice;
        }
        
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return null;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return null;
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult<UserDTO>> Post([FromBody] UserDTO user)
        {
            var userDTO = _service.Register(user);
            if (userDTO != null)
                return userDTO;
            return BadRequest("Not able to register");
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           
        }
    }
}
