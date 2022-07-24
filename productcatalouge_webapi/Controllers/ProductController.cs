using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Product.Core;
using ProductDB = Product.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productcatalouge_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        /// <summary>
        /// Created a private  variable _logger and _productServices
        /// </summary>
        private readonly ILogger<ProductController> _logger;
        private IProductServices _productServices;

        /// <summary>
        /// Use dependency injection for Ilogger & IProductServices
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="productServices"></param>
        public ProductController(ILogger<ProductController> logger, IProductServices productServices)
        {
            _logger = logger;
            _productServices = productServices;
        }


        /// <summary>
        /// This method is use to get all the products.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetProduct()
        {
            try
            {
                return Ok(_productServices.GetProducts());
            }
            catch (Exception ex)
            {
                _logger.LogError("Error is method name : GetProduct " + ex.Message);
                return BadRequest("Error has Occurred.Please contact administrator");
            }
            
        }

        /// <summary>
        /// This method is use to get the products by id.
        /// </summary>
        /// <param name="id">int</param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult GetProduct(int id)
        {
            try
            {
                return Ok(_productServices.GetProducts(id));
            }
            catch (Exception ex)
            {
                _logger.LogError("Error is method name : GetProductbyid " + ex.Message);
                return BadRequest("Error has Occurred.Please contact administrator");
            }
           
        }

        /// <summary>
        /// This method is use to filter the products.
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="color">string</param>
        /// <param name="size">string</param>
        /// <param name="price">string</param>
        /// <returns></returns>
        [HttpGet("{name?}/{color?}/{size?}/{price:double?}")]
        public IActionResult FilterProducts(string name="", string color = "", string size = "", double price=0.0)
        {
            try
            {
                return Ok(_productServices.FilterProducts(name, color, size, price));
            }
            catch (Exception ex)
            {
                _logger.LogError("Error is method name : FilterProducts " + ex.Message);
                return BadRequest("Error has Occurred.Please contact administrator");
            }
        }

        /// <summary>
        /// This method is use to create the product.
        /// </summary>
        /// <param name="product">entity model</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateProduct(ProductDB.Product product)
        {
            try
            {
                var _product = _productServices.CreateProduct(product);
                return CreatedAtRoute("GetProduct", new { _product.Id }, _product);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error is method name : CreateProduct " + ex.Message);
                return BadRequest("Error has Occurred.Please contact administrator");
            }

        }

        /// <summary>
        /// This method is use to edit the product.
        /// </summary>
        /// <param name="product">entity model</param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult EditProduct([FromBody] ProductDB.Product product)
        {
            try
            {
                _productServices.EditProduct(product);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError("Error is method name : EditProduct " + ex.Message);
                return BadRequest("Error has Occurred.Please contact administrator");
            }
        }

        /// <summary>
        /// This method is use to delete the product.
        /// </summary>
        /// <param name="id">int</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                _productServices.DeleteProduct(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError("Error is method name : DeleteProduct " + ex.Message);
                return BadRequest("Error has Occurred.Please contact administrator");
            }
        }
    }
}
