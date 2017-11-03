using System;
using System.Collections.Generic;
using System.Linq;

namespace testweb.Models
{
    public class ProductRepository :   IProductRepository, IDisposable
    {
        private StoreContext context;

        public ProductRepository(StoreContext context)
        {
          
            this.context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Product GetProductByID(int productId)
        {
            return context.products.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.products.ToList();
        }

        public IEnumerable<Category> GetCategories()
        {
            return context.categories.ToList();
        }

        public void InsertProduct(Product product)
        {
            context.products.Add(product);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
