using AspNETWebApi.Features.Product.Queries;
using AspNETWebApi.Features.Product.Queries.GetById;
using AutoMapper;

namespace AspNETWebApi.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile() {
            CreateMap<ProductsResponse, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();    
        }
    }
}
