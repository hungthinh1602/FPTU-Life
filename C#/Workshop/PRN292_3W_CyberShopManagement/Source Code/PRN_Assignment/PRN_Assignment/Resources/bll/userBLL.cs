using PRN_Assignment.Resources.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Assignment.Resources.bll
{
    class userBLL
    {
        userDAL userdal;
        public userBLL()
        {
            userdal = new userDAL();
        }

        public bool login(string id, string pass)
        {
            return userdal.login(id, pass);
        }
    }
}
