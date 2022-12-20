using AutoMapper;
using Store.Application.Features.ProductFeature.Commands.CreateProduct;
using Store.Domain.Entities;

namespace Store.Application.Features.ProductFeature.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProductCommand, Product>();
        }
    }
}
