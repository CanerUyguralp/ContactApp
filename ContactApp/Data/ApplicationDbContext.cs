using Microsoft.EntityFrameworkCore;
using ContactApp.Models;

namespace ContactApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}
