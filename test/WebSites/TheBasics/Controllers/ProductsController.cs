using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TheBasics.Models;

namespace TheBasics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Product>), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 401)]
        [ProducesDefaultResponseType(typeof(ProblemDetails))]
        public IActionResult GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
