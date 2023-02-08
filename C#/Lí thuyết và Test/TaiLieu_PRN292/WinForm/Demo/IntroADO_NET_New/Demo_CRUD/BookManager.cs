using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;


 using System.Data;
 using System.Data.SqlClient;
 namespace IntroADO_NET{
    public class BookManager {   
        string strConnection;
        public BookManager(){
            strConnection = getConnectionString();
        }
        //Phuong thuc lay chuoi ket noi
        public string getConnectionString(){
            string strConnection = "server=.;database=Manager;uid=sa;pwd=123";
            return strConnection;
        }
        //Phuong thuc lay tat cac Sach
        public DataTable getBooks(){
            string SQL = "select * from Books";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtBook = new DataTable();
            try{              
                if (cnn.State == ConnectionState.Closed){
                    cnn.Open();
                }                     
                da.Fill(dtBook);
            }
            catch (SqlException se){
                throw new Exception(se.Message);
            }
            finally{
                cnn.Close();
            }
            return dtBook;
        }

        //Phuong thuc them moi Sach
        public bool addNewBook(Book book){
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Insert Books values(@ID,@Title,@Quantity,@Price)";      
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", book.BookID);
            cmd.Parameters.AddWithValue("@Title", book.BookTitle);
            cmd.Parameters.AddWithValue("@Quantity",book.BookQuantity);
            cmd.Parameters.AddWithValue("@Price", book.BookPrice);          
            if (cnn.State == ConnectionState.Closed) {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }

        //Phuong thuc cap nhat Sach
        public bool updateBook(Book book){
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = 
                "Update Books set BookTitle=@Title,BookQuantity=@Quantity,"+
                " BookPrice=@Price where BookID=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", book.BookID);
            cmd.Parameters.AddWithValue("@Title", book.BookTitle);
            cmd.Parameters.AddWithValue("@Price", book.BookPrice);
            cmd.Parameters.AddWithValue("@Quantity", book.BookQuantity);
            if (cnn.State == ConnectionState.Closed){
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        //Phuong thuc xoa sach
        public bool deleteBook(int BookID){
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Delete Books where BookID=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", BookID);
            if (cnn.State == ConnectionState.Closed) {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }       
    }//end class
 }//end namespace
