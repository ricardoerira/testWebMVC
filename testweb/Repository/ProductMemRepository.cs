using System;
using System.Collections.Generic;
using System.Linq;

namespace testweb.Models
{
    public class ProductMemRepository :   IProductRepository, IDisposable
    {
        private StoreMemContext context;

        public ProductMemRepository(StoreMemContext context)
        {
            this.context = context;
            testData();
        }

        public void testData(){
            Category category = new Category();
            category.name = "fruits";
            this.context.Add(category);
            this.context.SaveChanges();
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
