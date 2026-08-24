using Microsoft.EntityFrameworkCore;

namespace ProfileDetail.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<ProfileDetail> ProfileDetails { get; set; }
    }
}
 