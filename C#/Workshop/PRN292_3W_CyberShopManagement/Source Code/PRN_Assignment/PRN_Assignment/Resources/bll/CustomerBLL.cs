using PRN_Assignment.Resources.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Assignment.Resources.bll
{
    class CustomerBLL
    {
        customerDAL cusdal;

        public CustomerBLL()
        {
            cusdal = new customerDAL();
        }

        public DataTable getAllCus()
        {
            return cusdal.getAllCus();
        }
        public bool addCus(Customer cus)
        {
            return cusdal.addCus(cus);
        }
        public bool updateCus(Customer cus)
        {
            return cusdal.updateCus(cus);
        }
        public bool deleteCus(Customer cus)
        {
            return cusdal.deleteCus(cus);
        }
        public DataTable findCus(string cus)
        {
            return cusdal.findCus(cus);
        }
    }
}
