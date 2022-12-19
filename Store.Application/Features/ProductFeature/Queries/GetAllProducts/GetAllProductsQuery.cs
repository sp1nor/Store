using MediatR;
using Store.Domain.Entities;
using System.Collections.Generic;

namespace Store.Application.Features.ProductFeature.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
