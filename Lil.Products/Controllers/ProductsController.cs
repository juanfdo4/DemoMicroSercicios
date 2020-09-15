using Lil.Products.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lil.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProducsProvider producsProvider;
        public ProductsController(IProducsProvider producsProvider)
        {
            this.producsProvider = producsProvider;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            var result = await producsProvider.GetAsync(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }
    }
}
