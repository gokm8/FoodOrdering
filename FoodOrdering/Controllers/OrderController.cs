using foodordering.server.Models;
using FoodOrdering.Data;
using Microsoft.AspNetCore.Mvc;

namespace foodordering.server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly FoodOrderingDbContext _context;


        public OrderController(FoodOrderingDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            return null;
        }

    }

}
