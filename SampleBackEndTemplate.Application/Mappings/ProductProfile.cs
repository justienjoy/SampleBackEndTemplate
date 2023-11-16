using SampleBackEndTemplate.Application.Features.Products.Commands.Create;
using SampleBackEndTemplate.Application.Features.Products.Queries.GetAllCached;
using SampleBackEndTemplate.Application.Features.Products.Queries.GetAllPaged;
using SampleBackEndTemplate.Application.Features.Products.Queries.GetById;
using SampleBackEndTemplate.Domain.Entities.Catalog;
using AutoMapper;

namespace SampleBackEndTemplate.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}