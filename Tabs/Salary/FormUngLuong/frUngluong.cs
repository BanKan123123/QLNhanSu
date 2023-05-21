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
    public partial class frUngLuong : Form
    {
        private readonly string nameTable = "dbo.tbl_UngLuong";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frUngLuong()
        {
            InitializeComponent();
            BindingData();
        }

        private void dgvUngLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvUngLuong.DataSource = dt;
        }

        private void frUngLuong_Load(object sender, EventArgs e)
        {

        }
    }
}
