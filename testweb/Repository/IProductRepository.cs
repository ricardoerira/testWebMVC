using System;
using System.Collections.Generic;

namespace testweb.Models
{
    public interface IProductRepository : IDisposable
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int productId);
        void InsertProduct(Product product);
        IEnumerable<Category> GetCategories();

        void Save();
      
    }
}
