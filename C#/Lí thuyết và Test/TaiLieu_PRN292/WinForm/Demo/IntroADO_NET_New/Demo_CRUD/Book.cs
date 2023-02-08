using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroADO_NET
{
    //Khai bao entity cua Book
    public class Book
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public int BookQuantity { get; set; }
        public double BookPrice { get; set; }
    }
}
