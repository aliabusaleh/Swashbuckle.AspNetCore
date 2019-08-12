using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using TheBasics.Models;

namespace TheBasics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public int CreateUser([FromBody, Required]User user)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        [HttpGet("search")]
        public IEnumerable<User> SearchUsers([FromQuery]string keywords, [FromQuery]PagingParams pagingParams, [FromHeader]string host)
        {
            throw new NotImplementedException();
        }
    }
}
