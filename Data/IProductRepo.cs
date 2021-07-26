using EstoqueWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueWebAPI.Data
{
    public interface IProductRepo
    {
        IEnumerable<Product> getAllProducts();
        Product getProductById(int id);
        void createProduct();
        void updateProduct();
        void deleteProduct();

    }
}
