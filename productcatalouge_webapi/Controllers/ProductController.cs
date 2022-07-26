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
    [Route("api/[controller]")]
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
        /// This method is use to get all the products. Url: https://localhost:5001/api/product
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
                return BadRequest("Error has Occurred.Please contact administrator.!!!");
            }

        }
        [HttpGet]
        [Route("orderbyproducts/{type}", Name = "orderbyproducts")]
        //https://localhost:5001/api/product/orderbyproducts/namedesc
        public IActionResult OrderByProducts(int type)
        {
            try
            {
                return Ok(_productServices.OrderByProducts(type));
            }
            catch (Exception ex)
            {
                _logger.LogError("Error is method name : OrderByProducts " + ex.Message);
                return BadRequest("Error has Occurred.Please contact administrator.!!!");
            }
        }

        /// <summary>
        /// This method is use to get the products by id.
        /// </summary>
        /// <param name="id">int</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            try
            {
                return Ok(_productServices.GetProducts(id));
            }
            catch (Exception ex)
            {
                _logger.LogError("Error is method name : GetProductbyid " + ex.Message);
                return BadRequest("Error has Occurred.Please contact administrator.!!!");
            }

        }

        /// <summary>
        /// This method is use to search the products. url:https://localhost:5001/api/product/serachproducts/value
        /// </summary>
        /// <param search="search">string</param>

        /// <returns></returns>
        [HttpGet]
        [Route("serachproducts/{search?}", Name = "serachproducts")]
        public IActionResult SearchProduct(string search = "")
        {
            try
            {
                return Ok(_productServices.SearchProducts(search));
            }
            catch (Exception ex)
            {
                _logger.LogError("Error is method name : SearchProducts " + ex.Message);
                return BadRequest("Error has Occurred.Please contact administrator.!!!");
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
                return BadRequest("Error has Occurred.Please contact administrator.!!!");
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
                return BadRequest("Error has Occurred.Please contact administrator.!!!");
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
                return BadRequest("Error has Occurred.Please contact administrator.!!!");
            }
        }
    }
}
