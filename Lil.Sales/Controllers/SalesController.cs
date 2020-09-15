﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lil.Sales.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lil.Sales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISalesProvider salesProvider;
        public SalesController(ISalesProvider salesProvider)
        {
            this.salesProvider = salesProvider;
        }

        [HttpGet("{cistomerId}")]
        public async Task<IActionResult> GetAsync(string cistomerId)
        {
            var orders = await salesProvider.GetAsync(cistomerId);
            if (orders != null && orders.Any())
            {
                return Ok(orders);
            }
            return NotFound();
        }
    }
}
