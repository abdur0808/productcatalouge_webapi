using ProductDB = Product.DB;
using System.Collections.Generic;


namespace Product.Core
{
    /// <summary>
    /// This interface is use to define teh signature of the actions.
    /// </summary>
    public interface IProductServices
    {
        ProductDB.Product GetProducts(int Id);

        List<ProductDB.Product> GetProducts();

        ProductDB.Product CreateProduct(ProductDB.Product product);

        void DeleteProduct(int Id);

        void EditProduct(ProductDB.Product product);

        List<ProductDB.Product> SearchProducts(string search);

        List<ProductDB.Product> OrderByProducts(int type);

    }
}
