using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Employees.FormBoPhan
{
    public partial class frBoPhan : Form
    {
        private readonly string nameTable = "dbo.tbl_BoPhan";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frBoPhan()
        {
            InitializeComponent();
            BindingData();
        }

        private void dgvBoPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvBoPhan.DataSource = dt;
        }

    }
}
