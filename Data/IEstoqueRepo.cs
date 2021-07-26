using EstoqueWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueWebAPI.Data
{
    public interface IEstoqueRepo
    {
        IEnumerable<Product> getAllProducts();
        Product getProductById(int id);
        void createProduct();
        void updateProduct();
        void deleteProduct();

    }
}
