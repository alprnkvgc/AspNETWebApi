using AspNETWebApi.Features.Product.Queries;
using AspNETWebApi.Features.Product.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AspNETWebApi.Controllers.v1
{
    public class ProductController : BaseApiController<ProductController>
    {
        /// <summary>
        /// Get All Companies
        /// </summary>
        /// <returns>Status 200 OK</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            var products = Mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }
        /// <summary>
        /// Get a Product By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 Ok</returns>
        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var product = Mediator.Send(new GetProductByIdQuery() { Id = id });
            return Ok(product);
        }
    }

}