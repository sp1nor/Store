using MediatR;
using Store.Application.Common.Persistence;
using Store.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Store.Application.Features.ProductFeature.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly IGenericRepository<Product> _repository;

        public GetAllProductsQueryHandler(IGenericRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return _repository.GetAll();
        }
    }
}
