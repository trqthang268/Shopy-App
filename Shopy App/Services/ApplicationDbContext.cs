using Microsoft.EntityFrameworkCore;
using Shopy_App.Models;

namespace Shopy_App.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base (options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
