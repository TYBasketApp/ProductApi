using System.Collections.Generic;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Abstract;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            var addedProduct = _productService.Add(product);

            return new JsonResult(addedProduct);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult GetProducts([FromBody]List<int> productIds)
        {
            var products = _productService.GetProductsByIds(productIds);

            return new JsonResult(products);
        }
    }
}