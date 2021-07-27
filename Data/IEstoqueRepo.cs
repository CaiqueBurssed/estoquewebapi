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

        void createProduct(Product product);
        void updateProduct(Product product);
        void deleteProduct(Product product);
        IEnumerable<Product> getAllProducts();
        Product getProductById(int id);

    }
}
