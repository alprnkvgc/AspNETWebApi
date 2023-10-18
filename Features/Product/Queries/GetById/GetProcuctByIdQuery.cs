using AutoMapper;
using MediatR;

namespace AspNETWebApi.Features.Product.Queries.GetById
{
    public class GetProductByIdQuery : IRequest<GetProductByIdResponse>
    {
        public int Id { get; set; }
    }
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdResponse>
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<GetProductByIdResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = _context.Products.Where(p => p.Id == request.Id).FirstOrDefault();
            if (product == null) throw new Exception("Böyle bir ürün bulunmamaktadır");
            var mappedProduct = _mapper.Map<GetProductByIdResponse>(product);
            return Task.FromResult(mappedProduct);
        }
    }
}
