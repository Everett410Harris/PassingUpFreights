using Microsoft.EntityFrameworkCore;
using PassingUpFreights.Models.Domain;

namespace PassingUpFreights.Data
{
    public class FreightDbContext : DbContext
    {
        public FreightDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
