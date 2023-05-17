using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Other
{
    public partial class frDantoc : Form
    {
        private readonly string nameTable = "dbo.tbl_DanToc";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frDantoc()
        {
            InitializeComponent();
            BindingData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvDanToc.DataSource = dt;
        }
    }
}
