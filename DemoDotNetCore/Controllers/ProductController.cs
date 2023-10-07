using DemoDotNetCore.Domain.Entities;
using DemoDotNetCore.Infrastructor.IRepositories;
using DemoDotNetCore.RequestModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNetCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        /// <summary>
        /// Api tao moi san pham
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("Create")] //     api/Product/Create
        public IActionResult CreateProduct([FromBody] CreateProductRequest request)
        {

            var product = new Product()
            {
                Name = request.Name,
                Price = request.Price,
                OldPrice = request.OldPrice,
                Description = request.Description,
                Container = request.Container,
                Details = request.Details,
                Preview = request.Preview
            };
            product = _productRepository.Create(product);
            _productRepository.SaveChange();
            return Ok(product);
        }

        /// <summary>
        /// Api tao moi san pham
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productRepository.GetProducts();
            return Ok(products);
        }

        /// <summary>
        /// Api tao moi san pham
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("products-by-container")]
        public IActionResult GetProducts(string container)
        {
            var products = _productRepository.GetProductsByContainer(container);
            return Ok(products);
        }
    }
}
