using AspNETWebApi.Features.Product.Queries;
using AutoMapper;

namespace AspNETWebApi.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile() {
            CreateMap<ProductsResponse, Product>().ReverseMap();
        }
    }
}
