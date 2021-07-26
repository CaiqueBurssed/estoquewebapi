using EstoqueWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueWebAPI.Data
{
    public interface IEstoqueRepo
    {
        bool SaveChanges();


        IEnumerable<Product> getAllProducts();
        Product getProductById(int id);
        void createProduct(Product product);
        void updateProduct();
        void deleteProduct();

    }
}
