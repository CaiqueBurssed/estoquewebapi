using EstoqueWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueWebAPI.Data
{
    public class MockProductRepo : IProductRepo
    {
        public void createProduct()
        {
            throw new NotImplementedException();
        }

        public void deleteProduct()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> getAllProducts()
        {
            var products = new List<Product>
            {
                new Product{ Id = 0, Name = "Playstation 4", Quantity = 100 },
                new Product{ Id = 1, Name = "Xbox One", Quantity = 75 },
                new Product{ Id = 0, Name = "Nintendo Switch", Quantity = 50 }
            };

            return products;
        }

        public Product getProductById()
        {
            return new Product { Id = 0, Name = "Playstation 4", Quantity = 100 };
        }

        public void updateProduct()
        {
            throw new NotImplementedException();
        }
    }
}
