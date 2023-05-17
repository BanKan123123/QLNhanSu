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
    public partial class frThuong : Form
    {
        private readonly string nameTable = "dbo.tbl_tbl_KhenThuongKyLuat";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frThuong()
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
    }
}
