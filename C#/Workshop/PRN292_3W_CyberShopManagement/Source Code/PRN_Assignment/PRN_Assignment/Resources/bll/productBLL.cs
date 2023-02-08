using PRN_Assignment.Resources.dal;
using PRN_Assignment.Resources.DBUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Assignment.Resources.bll
{
     class ProductBLL
    {
        ProductDAL prodal;
        
        public ProductBLL()
        {
            prodal = new ProductDAL();
        }

        public DataTable getAllPro()
        {
            return prodal.getAllPro();
        }
        public bool addPro(Product pro)
        {
            return prodal.addPro(pro);
        }
        public bool updatePro(Product pro)
        {
            return prodal.updatePro(pro);
        }
        public bool deletePro(Product pro)
        {
            return prodal.deletePro(pro);
        }
        public DataTable findPro(string pro)
        {
            return prodal.findPro(pro);
        }
        public bool checkProID(string id)
        {
            return prodal.checkproID(id);
        }
    }
}
