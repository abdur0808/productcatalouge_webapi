using ProductDB = Product.DB;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Product.Core
{
    public class ProductServices: IProductServices
    {
        /// <summary>
        /// Creating the DbContext variable
        /// </summary>
        private ProductDB.AppDbContext _context;
        public ProductServices(ProductDB.AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This Method is use for Craeting teh product
        /// </summary>
        /// <param name="product"> entity model</param>
        /// <returns>product</returns>
        public ProductDB.Product CreateProduct(ProductDB.Product product)
        {
            try
            {
                _context.Add(product);
                _context.SaveChanges();
                return product;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
          
        }

        /// <summary>
        /// This method is use for Get the products by id
        /// </summary>
        /// <param name="Id"> passing the id parameter</param>
        /// <returns></returns>
        public ProductDB.Product GetProducts(int Id)
        {
            try
            {
                return _context.Products.FirstOrDefault(x => x.Id == Id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// This method is use for filter  the products
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="color">string</param>
        /// <param name="size">string</param>
        /// <param name="price">string</param>
        /// <returns> Product collections</returns>
        public List<ProductDB.Product> FilterProducts( string name, string color, string size, double price)
        {
            try
            {
                return _context.Products.Where(p => p.Name == name || p.Color == color || p.Size == size || p.Price == price).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// This method is use for Get all the products
        /// </summary>
        /// <returns> Product collections</returns>
        public List<ProductDB.Product> GetProducts()
        {
            try
            {
                return _context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// This method is use for Edit the product
        /// </summary>
        /// <param name="product">entity model</param>
        public void EditProduct(ProductDB.Product product)
        {
            try
            {
                var _product = _context.Products.First(x => x.Id == product.Id);
                _product.Name = product.Name;
                _product.Description = product.Description;
                _product.Color = product.Color;
                _product.Size = product.Size;
                _product.ImageId = product.ImageId;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// This method is use for delete the product
        /// </summary>
        /// <param name="Id">int</param>
        public void DeleteProduct(int Id)
        {
            try
            {
                var _product = _context.Products.First(x => x.Id == Id);
                _context.Products.Remove(_product);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
