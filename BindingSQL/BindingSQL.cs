using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLNhanSu.BindingSQL
{
    public class BindingSQL
    {
        Auth auth = new Auth();
        string strcon = "Data Source=LAPTOP-4T313C1P\\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Persist Security Info=True;User ID=sa;Password=1";
        string strAuth = "Data Source=LAPTOP-4T313C1P\\SQLEXPRESS;Initial Catalog=ImportSQL;Integrated Security=True";
        public BindingSQL() { }
        public DataTable BindingData(string nameTable)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(strcon);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string query = "SELECT * FROM " + nameTable;
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable GetManv()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(strcon);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string query = "SELECT MANV, HOTEN FROM tbl_NhanVien";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        public void TestPassword(string password)
        {
            SqlConnection con = new SqlConnection(strAuth);
            con.Open();
            MessageBox.Show(password + " / " + auth.username);
            string query = "";
        }

        public void ThemNhanVien(string query)
        {
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void XoaNhanVien(string query)
        {
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
