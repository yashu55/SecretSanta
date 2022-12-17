using Microsoft.EntityFrameworkCore;
using SecretSanta.Models;

namespace SecretSanta.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Teammate> Teammates { get; set; }
    }
}
