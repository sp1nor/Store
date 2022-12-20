using AutoMapper;
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
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(
            IGenericRepository<Product> repository,
            IUnitOfWork<Product> unitOfWork,
            IMapper mapper
            )
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);

            _repository.Create(product);
            _unitOfWork.Save();

            return product;
        }
    }
}
