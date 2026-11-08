namespace foodordering.server.Models
{
    public class Order
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
