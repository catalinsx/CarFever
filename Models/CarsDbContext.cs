using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class CarsDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
        {

        }
    }
}
