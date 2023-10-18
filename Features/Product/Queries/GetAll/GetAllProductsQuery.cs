using AutoMapper;
using MediatR;

namespace AspNETWebApi.Features.Product.Queries
{
    public class GetAllProductsQuery : IRequest<List<ProductsResponse>>
    {
        public GetAllProductsQuery() { }
    }
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductsResponse>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<ProductsResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = _context.Products.ToList();
            var mappedProducts = _mapper.Map<List<ProductsResponse>>(products);
            return Task.FromResult(mappedProducts);
        }
    }
}

