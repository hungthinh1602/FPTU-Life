using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroADO_NET
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public bool Login(string userName , string password)
        {
            bool result = false;
            string strConnection = "server=.;database=manager;uid=sa;pwd=123";
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "select * from Employees where " +
                " EmpID = @ID and EmpPass = @Pass";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", userName);
            cmd.Parameters.AddWithValue("@Pass", password);
            SqlDataReader dr;
            try{
                cnn.Open();
                dr = cmd.ExecuteReader();
                result = dr.HasRows;
                //dr.Read();

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            finally {
                cnn.Close();
            }
            return result;
        }

        public  void ShowForm()
        {
            frmMaintainBook f = new frmMaintainBook();
            Application.Run(f); 
         
        }
        private  void btnLogin_Click(object sender, EventArgs e) {
            //if (Login(txtUserName.Text,txtPassword.Text))
            if(txtUserName.Text=="tom" && txtPassword.Text=="123")
            {
                this.Hide();
                Thread t = new Thread(new ThreadStart(ShowForm));
                t.Start();               
                this.Close();
            }
            else{
                MessageBox.Show("Login fail.");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
