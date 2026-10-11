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

        // GET /api/menu
        [HttpGet]
        public async Task<ActionResult<List<MenuItem>>> GetMenuItems()
        {
            var menu = await _context.MenuItems.ToListAsync();

            return Ok(menu);
        }
    
        //GET /api/menu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MenuItem>> GetMenuItem(int id)
        {
            var menuItem = await _context.MenuItems.FindAsync(id);

            if (menuItem == null)
            {
                return NotFound();
            }

            return Ok(menuItem);
        }
    }
}
