using Dapper;
using System.Collections.Generic;
using System.Data;
using System;
using Testing.Models;
using System.Data;
using Dapper;
using System.Collections.Generic;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _conn.Query<Products>("SELECT * FROM Products;");
        }
    }
}
