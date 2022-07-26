using ProductDB = Product.DB;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Product.Core
{
    public class ProductServices : IProductServices
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
        /// <param search="search">string</param>

        /// <returns> Product collections</returns>
        public List<ProductDB.Product> SearchProducts(string seacrch)
        {
            try
            {
                string _search = seacrch.ToLower();
                return _context.Products.
                    Where(p => p.Name.Contains(_search) ||
                          p.Color.Contains(_search) ||
                          p.Size.Contains(_search)).ToList();
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
        /// This is use for product sorting
        /// </summary>
        /// <param name="type">string</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        public List<ProductDB.Product> OrderByProducts(int type)
        {
            try
            {
                List<ProductDB.Product> response = null;
                switch (type)
                {

                    case 1: // Product (A to Z)
                        response = new List<ProductDB.Product>();
                        response = _context.Products.OrderBy(p => p.Name).ToList();
                        break;

                    case 2: // Product (Z to A)
                        response = new List<ProductDB.Product>();

                        response = _context.Products.OrderByDescending(p => p.Name).ToList();
                        break;
                    case 3:// Price (low to high)
                        response = new List<ProductDB.Product>();
                        response = _context.Products.OrderBy(p => p.Price).ToList();
                        break;

                    case 4:// Price (high to low)
                        response = new List<ProductDB.Product>();
                        response = _context.Products.OrderByDescending(p => p.Price).ToList();
                        break;
                    default:
                        response = new List<ProductDB.Product>();
                        response = _context.Products.OrderBy(p => p.Name).ToList();
                        break;
                }

                return response;
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
                var _product = _context.Products
                    .First(x => x.Id == product.Id);
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
