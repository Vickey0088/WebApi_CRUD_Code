using Microsoft.EntityFrameworkCore;

namespace WebApiCRUDCode.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option) { }
        public DbSet<Students> Students { get; set; }
    }
}
