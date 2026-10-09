using Microsoft.EntityFrameworkCore;

namespace FoodOrdering.Models
{
    public class MenuItem
    {
        public int ID { get; set; } 
        public required string Name { get; set; }
        public string? Description { get; set; }
        [Precision(18,2)]
        public required decimal Price { get; set; }
    }
}
