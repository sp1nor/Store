using MediatR;
using Store.Application.Common.Persistence;
using Store.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Store.Application.Features.ProductFeature.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly IGenericRepository<Product> _repository;
        private readonly IUnitOfWork<Product> _unitOfWork;

        public CreateProductCommandHandler(
            IGenericRepository<Product> repository,
            IUnitOfWork<Product> unitOfWork
            )
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product();
            product.Name = request.Name;
            product.Price = request.Price;

            _repository.Create(product);
            _unitOfWork.Save();

            return product;
        }
    }
}
