using AspNETWebApi.Entities;
using AspNETWebApi.Features.Products.Commands;
using AspNETWebApi.Features.Products.Queries;
using AspNETWebApi.Features.Products.Queries.GetById;
using AutoMapper;

namespace AspNETWebApi.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile() {
            CreateMap<ProductsResponse, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();    
            CreateMap<CreateUpdateProductCommand, Product>().ReverseMap();
        }
    }
}
