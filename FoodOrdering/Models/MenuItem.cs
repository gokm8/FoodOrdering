namespace FoodOrdering.Models
{
    public class MenuItem
    {
        public int ID { get; set; } 
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required decimal Price { get; set; }
    }
}
