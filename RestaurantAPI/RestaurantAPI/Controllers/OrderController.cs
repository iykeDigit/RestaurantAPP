using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly Context _context;

        public OrderController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<>

    }
}
