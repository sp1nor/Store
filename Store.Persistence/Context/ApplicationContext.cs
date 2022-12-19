using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;

namespace Store.Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }
    }
}
