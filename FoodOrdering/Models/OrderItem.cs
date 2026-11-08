using FoodOrdering.Models;
using System.ComponentModel.DataAnnotations;

namespace foodordering.server.Models
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int OrderId { get; set; }
        public required List<MenuItem> MenuItems { get; set; } = new();
        [Range(1,100)]
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
