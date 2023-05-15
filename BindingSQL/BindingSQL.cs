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
        public BindingSQL() { }
        public DataTable BindingData(string nameTable)
        {
            string strcon = "Data Source=LAPTOP-4T313C1P\\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Persist Security Info=True;User ID=sa;Password=banban123";
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
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
