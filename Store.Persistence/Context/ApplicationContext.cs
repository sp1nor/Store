using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using System.Linq;

namespace Store.Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            if (Products.ToList().Count == 0)
            {
                InitializeProductDefault();
            }
        }
        
        private void InitializeProductDefault()
        {
            Products.AddRange(
                new Product()
                {
                    Name = "apple1",
                    Price = 125252.32M
                },
                new Product()
                {
                    Name = "samsung1",
                    Price = 42443.32M
                },
                new Product()
                {
                    Name = "mio",
                    Price = 21222.23M
                }
            );

            this.SaveChanges();
        }
    }
}
