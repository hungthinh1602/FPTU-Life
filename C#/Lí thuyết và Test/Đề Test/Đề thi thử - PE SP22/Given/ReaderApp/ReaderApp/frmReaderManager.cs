using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReaderApp
{
    public partial class frmReaderManager : Form
    {
        ReaderBLL readerbll;
        public frmReaderManager()
        {
            InitializeComponent();
            readerbll = new ReaderBLL();
        }

        public void showALL()
        {
            DataTable dt = readerbll.getAll();
            readersDataGridView.DataSource = dt;
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            readerIdTextBox.Enabled = true;
            readerIdTextBox.Text = "";
            readerNameTextBox.Text = "";
            categoryTextBox.Text = "";
            dateOfBirthDateTimePicker.Text = "";
            dateDateTimePicker.Text = "";
            addressTextBox.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Reader reader = new Reader();
            reader.ReaderID = readerIdTextBox.Text;
            reader.ReaderName = readerNameTextBox.Text;
            reader.Category = categoryTextBox.Text;
            reader.DateOfBirth = DateTime.Parse(dateOfBirthDateTimePicker.Text);
            reader.Date = DateTime.Parse(dateDateTimePicker.Text);
            reader.Address = addressTextBox.Text;

            if (readerbll.Insert(reader))
            {
                showALL();
            }
            else
            {
                MessageBox.Show("error", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            Reader reader = new Reader();
            reader.ReaderID = readerIdTextBox.Text;
            reader.ReaderName= readerNameTextBox.Text;
            reader.Category= categoryTextBox.Text;
            reader.DateOfBirth = DateTime.Parse(dateOfBirthDateTimePicker.Text);
            reader.Date = DateTime.Parse (dateDateTimePicker.Text);
            reader.Address= addressTextBox.Text;

            if (readerbll.Update(reader))
            {
                showALL();
            }
            else
            {
                MessageBox.Show("error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      

        private void btnLoad_Click(object sender, EventArgs e)
        {
           showALL();
        }

        private void frmReaderManager_Load(object sender, EventArgs e)
        {
            
        }

        private void readersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            readerIdTextBox.Enabled = false;
            readerIdTextBox.Text = readersDataGridView.Rows[index].Cells["ReaderID"].Value.ToString();
            readerNameTextBox.Text = readersDataGridView.Rows[index].Cells["ReaderName"].Value.ToString();
            categoryTextBox.Text = readersDataGridView.Rows[index].Cells["Category"].Value.ToString();
            dateOfBirthDateTimePicker.Text = readersDataGridView.Rows[index].Cells["DateOfBirth"].Value.ToString();
            dateDateTimePicker.Text = readersDataGridView.Rows[index].Cells["Date"].Value.ToString();                
            addressTextBox.Text = readersDataGridView.Rows[index].Cells["Address"].Value.ToString();
        }
    }
}
