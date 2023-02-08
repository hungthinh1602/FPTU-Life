using PRN_Assignment.Resources.bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_Assignment
{
    public partial class Login : Form
    {
        userBLL userCtr;
        public Login()
        {
            InitializeComponent();
            userCtr = new userBLL();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            string id = txt_id.Text;
            string pass = txt_password.Text;
            try
            {
                if (txt_id.Text == "" || txt_password.Text == "")
                {
                    MessageBox.Show("Nhập ID và Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (userCtr.login(id, pass))
                    {
                        this.Hide();
                        MainForm fmmain = new MainForm();
                        fmmain.Show();
                    }                    
                    else
                    {

                        MessageBox.Show("ID hoặc password không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
