using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNhanSu
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=LAPTOP-4T313C1P\\SQLEXPRESS;Initial Catalog=ImportSQL;User ID=sa;Password=banban123";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string query = "INSERT INTO dbo.Authen(username, dbo.Authen.password) VALUES('" + txtUsername.Text.Trim() + "'," + "'" + txtPassword.Text.Trim() + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
        }
        private void txtRepassword_Leave(object sender, EventArgs e)
        {
            if (txtRepassword.Text == "")
            {
                errorRequied.SetError(this.txtRepassword, "Nhap lai mat khau");
                btnRegister.Enabled = false;
            } else
            {
                errorRequied.Clear();
            }

            if (txtPassword.Text != txtRepassword.Text)
            {
                txtRepassword.Focus();
                errorConfirm.SetError(this.txtRepassword, "Xac nhan password khong dung");
                btnRegister.Enabled = false;
            }
            else
            {
                errorConfirm.Clear();
                btnRegister.Enabled = true;
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            {
                errorRequied.SetError(this.txtPassword, "Nhap mat khau");
                btnRegister.Enabled = false;
            }
            else
            {
                errorRequied.Clear();
            }
        }
    }
}
