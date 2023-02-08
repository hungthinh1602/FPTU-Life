using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DemoGetData_1_Table{
    public partial class frmMain : Form{
        public frmMain()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataTable dtBooks;
        public DataTable GetAllBook() {
            //string strConnection = "server=.;database=manager;uid=sa;pwd=123";
            string strConnection = 
                ConfigurationManager.
                ConnectionStrings
                ["ManagerDB"].ConnectionString;

            string SQL = "select * from Books";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL,cnn);
            //thuc thi command tra ve du lieu cho DataTable
            da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
            //doi tuong chua du lieu tu Adapter
            DataTable dtBook = new DataTable();
            if(cnn.State == ConnectionState.Closed) 
                cnn.Open();
            da.Fill(dtBook);
            cnn.Close();
            return dtBook;
        }
       
        private void btnGetBooks_Click(object sender, EventArgs e)
        {
            dtBooks = GetAllBook();
            //dtBooks.Columns.Add
            //("SubTotal", typeof(float), "BookPrice*BookQuantity");
            dgvBooks.DataSource = dtBooks;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            da.Update(dtBooks);
        }
    }
}
