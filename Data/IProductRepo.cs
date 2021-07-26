using EstoqueWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueWebAPI.Data
{
    interface IProductRepo
    {
        IEnumerable<Product> getAllProducts();
        Product GetProductById();
        void createProduct();
        void updateProduct();
        void deleteProduct();

    }
}
