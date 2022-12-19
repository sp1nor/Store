using Store.Domain.Common.Models;

namespace Store.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
