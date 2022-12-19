using Store.Domain.Common.Models;
using System;

namespace Store.Domain.Entities
{
    public class Sale : Entity
    {
        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public int SalesProductId { get; set; }

        public int? BuyerId { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
