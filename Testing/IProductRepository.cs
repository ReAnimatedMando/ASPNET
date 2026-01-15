using System.Collections;
using System.Collections.Generic;
using System;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        public Product GetProduct(int id);

        public void UpdateProduct(Product product);

        public void InsertProductj(Product productToInsert);

        public IEnumerable<Category> GetCategories();

        public Product AssignCategory();
    }
}
