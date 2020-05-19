using Microsoft.EntityFrameworkCore;
using WebApplication2.ViewModel;

namespace order_ms.Infra
{
    public class OrderDbContext : DbContext
    {
        public DbSet<OrderModel> OrderData { get; set; }

        public OrderDbContext()
        {
        }

        public OrderDbContext(DbContextOptions
<OrderDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NAG6CHANDRVAR01; initial catalog=OrderDb;integrated security=true;");
        }
    }
}
