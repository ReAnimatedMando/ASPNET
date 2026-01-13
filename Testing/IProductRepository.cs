using System.Collections;
using System.Collections.Generic;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Products> GetAllProducts();
    }
}
