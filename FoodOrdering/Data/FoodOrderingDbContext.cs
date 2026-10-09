using FoodOrdering.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrdering.Data
{
    public class FoodOrderingDbContext : DbContext
    {
        public FoodOrderingDbContext(
            DbContextOptions<FoodOrderingDbContext> options)
            : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; } = null!;
    }
}