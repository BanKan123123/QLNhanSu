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
        string strcon = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QLNHANSU;Integrated Security=True";
        string strAuth = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QLNHANSU;Integrated Security=True";
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

        public DataTable Search(string query)
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

        public DataTable GetMACTY()
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
                string query = "SELECT MACTY FROM tbl_CongTy";
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

        public DataTable GetPhongBan()
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
                string query = "SELECT IDPB FROM tbl_PhongBan";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dt);
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }
        public DataTable GetMACTYOfEmply(int id)
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
                string query = "SELECT MACTY FROM tbl_NhanVien WHERE MANV = " + id;
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
        public DataTable GetIdphongban(int id)
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
                string query = "SELECT nv.IDPB, TENPB  FROM tbl_NhanVien as nv, tbl_PhongBan as pb  WHERE (nv.IDPB = pb.IDPB) and  MANV = " + id;
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

        internal object GetIdphongban(object selectedValue)
        {
            throw new NotImplementedException();
        }
    }
}
