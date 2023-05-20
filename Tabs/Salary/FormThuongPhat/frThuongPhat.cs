using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Salary
{
    public partial class frThuongPhat : Form
    {
        private readonly string nameTable = "dbo.tbl_KhenThuongKyLuat";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frThuongPhat()
        {
            InitializeComponent();
            BindingData();
        }

        private void dgvThuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvThuong.DataSource = dt;
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
