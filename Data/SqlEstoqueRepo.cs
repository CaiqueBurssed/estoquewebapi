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

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void createProduct(Product product)
        {
            if(product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _context.Products.Add(product);
        }

        public void updateProduct(Product product)
        {
            //Nothing
        }

        public void deleteProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _context.Products.Remove(product);
        }

        public IEnumerable<Product> getAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product getProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        
    }
}
