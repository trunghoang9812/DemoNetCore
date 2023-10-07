using DemoDotNetCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDotNetCore.Infrastructor.IRepositories
{
    public interface IProductRepository
    {
        Product Create(Product product);
        Product Update(Product product);
        void Delete(Product product);
        List<Product> GetProducts();
        List<Product> GetProductsByContainer(string container);
        int SaveChange();
    }
}
