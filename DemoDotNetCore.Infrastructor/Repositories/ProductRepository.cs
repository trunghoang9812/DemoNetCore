using DemoDotNetCore.Domain.Entities;
using DemoDotNetCore.Infrastructor.DBConText;
using DemoDotNetCore.Infrastructor.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDotNetCore.Infrastructor.Repositories
{
    public class ProductRepository : IProductRepository 
    {
        private readonly DemoContext _context;
        public ProductRepository(DemoContext context)
        {
            _context = context;
        }
        public Product Create(Product product)
        {
            return _context.Products.Add(product).Entity;
        }
        
        public void Delete(Product product)
        {
            _context.Products.Remove(product);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public List<Product> GetProductsByContainer(string container)
        {
            return _context.Products
                .Where(x => x.Container == container)
                .ToList();
        }

        public int SaveChange()
        {
            return _context.SaveChanges();
        }

        public Product Update(Product product)
        {
            return _context.Products.Update(product).Entity;
        }
    }
}
