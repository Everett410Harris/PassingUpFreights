using Microsoft.EntityFrameworkCore;

namespace PassingUpFreights.Data
{
    public class FreightDbContext : DbContext
    {
        public FreightDbContext(DbContextOptions options) : base(options)
        {
        }


    }
}
