using FoodOrdering.Data;
using FoodOrdering.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodOrdering.Controllers 
{

    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {

        private readonly FoodOrderingDbContext _context;

        // Constructor
        public MenuController(FoodOrderingDbContext context)
        {
            _context = context;
        }

        // HTTP GET Request
        [HttpGet]
        public async Task<ActionResult<List<MenuItem>>> Get()
        {
            var menu = await _context.MenuItems.ToListAsync();

            return Ok(menu);
        }
    
    }
}
