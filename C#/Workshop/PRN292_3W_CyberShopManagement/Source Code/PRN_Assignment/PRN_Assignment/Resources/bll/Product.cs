using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Assignment.Resources.bll
{
    class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string Producer { get; set; }
        public int Quantity { get; set; }
        public int QuantityLeft { get; set; }
        public string Description { get; set; }

    }
}
