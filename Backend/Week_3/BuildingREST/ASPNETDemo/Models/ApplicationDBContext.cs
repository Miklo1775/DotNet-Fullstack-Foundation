using Microsoft.EntityFrameworkCore;

namespace ASPNETDemo.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) { }
    }
}
