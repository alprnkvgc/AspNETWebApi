using AspNETWebApi.Features.Product.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AspNETWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ISender _mediator;

        public ProductController(ISender mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            var products = _mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }
    }

}