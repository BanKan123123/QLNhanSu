using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using Microsoft.Win32;

namespace QLNhanSu
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string strcon = "Data Source=LAPTOP-4T313C1P\\SQLEXPRESS;Initial Catalog=ImportSQL;User ID=sa;Password=banban123";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            string query = "SELECT count(*) FROM dbo.Authen WHERE username = '" + txtUsername.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("Sai tai khoan hoac mat khau");
            }

        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                errorRequied.SetError(this.txtPassword, "Nhap mat khau");
            }
            else
            {
                errorRequied.Clear();
            }
        }
    }
}