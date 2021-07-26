using EstoqueWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueWebAPI.Data
{
    public class SqlEstoqueRepo : IEstoqueRepo
    {
        private readonly EstoqueContext _context;
        public SqlEstoqueRepo(EstoqueContext context)
        {
            _context = context;
        }

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
            return _context.Products.ToList();
        }

        public Product getProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public void updateProduct()
        {
            throw new NotImplementedException();
        }
    }
}
