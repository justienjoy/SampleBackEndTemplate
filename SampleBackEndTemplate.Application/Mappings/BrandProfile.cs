using SampleBackEndTemplate.Application.Features.Brands.Commands.Create;
using SampleBackEndTemplate.Application.Features.Brands.Queries.GetAllCached;
using SampleBackEndTemplate.Application.Features.Brands.Queries.GetById;
using SampleBackEndTemplate.Domain.Entities.Catalog;
using AutoMapper;

namespace SampleBackEndTemplate.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}