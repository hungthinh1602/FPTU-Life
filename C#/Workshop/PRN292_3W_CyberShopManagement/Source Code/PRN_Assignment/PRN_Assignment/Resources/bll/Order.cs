using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Assignment.Resources.bll
{
    class Order
    {
        public string OrderID { get; set; }
        public string ProductID { get; set; }
        public int OrderQuantity { get; set; }
        public decimal Price { get; set; }
        public string CustomerID { get; set; }
        public int Total { get; set; }
    }
}
