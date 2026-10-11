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

        // HTTP PUT Request
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMenuItem(int id, MenuItem menuItem)
        {
            // Find the menu in the db
            var existingItem = await _context.MenuItems.FindAsync(id);

            if (existingItem == null)
            {
                return NotFound();
            }

            // Update properties of the menu
            existingItem.Name = menuItem.Name;
            existingItem.Description = menuItem.Description;
            existingItem.Price = menuItem.Price;

            // Save changes in the db
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // HTTP POST Request
        [HttpPost]
        public async Task<ActionResult<MenuItem>> PostMenuItem(MenuItem menuItem)
        {
            _context.MenuItems.Add(menuItem);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMenuItem), new { id = menuItem.ID }, menuItem);
        }
    }
}
