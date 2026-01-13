using System.Collections;
using System.Collections.Generic;
using System;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Products> GetAllProducts();
    }
}
