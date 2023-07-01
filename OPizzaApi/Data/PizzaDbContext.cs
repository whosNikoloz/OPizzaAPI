using Microsoft.EntityFrameworkCore;
using OPizzaApi.Model;

namespace OPizzaApi.Data
{
    public class PizzaDbContext :DbContext
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options) { }

        public DbSet<Pizza> pizzas { get; set; }
        public DbSet<Order> orders { get; set; }
    }
}
