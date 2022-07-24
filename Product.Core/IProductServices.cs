using ProductDB = Product.DB;
using System.Collections.Generic;


namespace Product.Core
{
    /// <summary>
    /// Define the signature for the product entity.
    /// </summary>
    public interface IProductServices
    {
        ProductDB.Product GetProducts(int Id);

        List<ProductDB.Product> GetProducts();

        ProductDB.Product CreateProduct(ProductDB.Product product);

        void DeleteProduct(int Id);

        void EditProduct(ProductDB.Product product);

        List<ProductDB.Product> FilterProducts(string name,string color,string size, double price);




    }
}
