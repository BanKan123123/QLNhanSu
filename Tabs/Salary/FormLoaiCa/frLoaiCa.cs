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
    public partial class frLoaiCa : Form
    {
        private readonly string nameTable = "dbo.tbl_KhenThuongKyLuat";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frLoaiCa()
        {
            InitializeComponent();
            BindingData();
        }

        private void dgvPhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvPhat.DataSource = dt;
        }
    }
}
