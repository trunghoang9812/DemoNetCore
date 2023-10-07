using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNetCore.RequestModels
{
    public class CreateProductRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public string Description { get; set; }
        public string Container { get; set; }
        public string Details { get; set; }
        public string Preview { get; set; }
    }
}
