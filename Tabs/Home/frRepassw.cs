using QLNhanSu.BindingSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Home
{
    public partial class frChPassword : Form
    {
        frHome home = new frHome();
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frChPassword()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn không muốn hủy bỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                home.Show();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bindingSQL.TestPassword(txtOldPassword.Text);
            DialogResult result = MessageBox.Show("Bạn chắc chắn không muốn hủy bỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công");
                this.Close();
                home.Show();
            }
        }
    }
}
