using Store.Domain.Common.Models;
using System.Collections.Generic;

namespace Store.Domain.Entities
{
    public class Buyer : Entity
    {
        public string Name { get; set; }

        public List<int> SalesIds { get; set; }
    }
}
