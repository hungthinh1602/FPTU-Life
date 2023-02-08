using PRN_Assignment.Resources.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Assignment.Resources.bll
{
    class OrderBLL
    {
        OrderDAL orddal;

        public OrderBLL()
        {
            orddal = new OrderDAL();
        }
        public DataTable getAllOrd()
        {
            return orddal.getAllOrd();
        }
        public bool addOrd(Order ord)
        {
            return orddal.addOrd(ord);
        }

        public bool deleteOrd(Order ord)
        {
            return orddal.deleteOrd(ord);
        }

        public DataTable findOrder(string ord)
        {
            return orddal.findOrder(ord);
        }
    }
}
