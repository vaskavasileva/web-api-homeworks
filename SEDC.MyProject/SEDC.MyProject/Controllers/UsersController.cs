using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDC.MyProject.Models;

namespace SEDC.MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return Ok(StaticDb.AllUsers);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            var user = StaticDb.AllUsers.SingleOrDefault(u => u.Id == id);
            if (id < 1)
            {
                return BadRequest(null);
            }
            if (user == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, null);
            }
            return Ok(user);
        }
        [HttpPost]
        public ActionResult AddUser([FromBody] User user)
        {
            user.Id = StaticDb.AllUsers.Count + 1;
            StaticDb.AllUsers.Add(user);
            return Ok();
        }
        [HttpDelete]
        public ActionResult DeleteUser(int id)
        {
            var userToDelete = StaticDb.AllUsers.SingleOrDefault(u => u.Id == id);
            if (id < 1)
            {
                return BadRequest();
            }
            if (userToDelete == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            StaticDb.AllUsers.Remove(userToDelete);
            return Ok();
        }
    }
}
