using Microsoft.EntityFrameworkCore;
using Tes3.Entites;

namespace Tes3.Tes3.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options) : base(options)  { }
        public DbSet<User> Users { get; set; } = null!;

        public DbSet<Courier> Couriers { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<CountersOfCreaton> CountersOfCreatons { get; set; } = null!;

        public DbSet<ShoppingList> ShoppingList { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
