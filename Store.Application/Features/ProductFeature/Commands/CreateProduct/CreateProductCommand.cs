using MediatR;
using Store.Domain.Entities;

namespace Store.Application.Features.ProductFeature.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
