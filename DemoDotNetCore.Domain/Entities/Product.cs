using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDotNetCore.Domain.Entities
{
    public class Product
    {
        public Product()
        {

        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public string Container { get; set; }
        public string About { get; set; }
        public string Description { get; set; }
        public string Preview { get; set; }
        public string Details { get; set; }
        public string Ingredients { get; set; }
    }
}
