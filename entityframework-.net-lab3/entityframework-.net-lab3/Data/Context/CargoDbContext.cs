using entityframework_.net_lab3.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace entityframework_.net_lab3.Data.Context
{
    public class CargoDbContext:DbContext
    {
        public CargoDbContext(DbContextOptions options)
       : base(options)
        {

        }

        public DbSet<Factory> Factories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        



    }
}
