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
    public partial class frBaoHiem : Form
    {
        private readonly string nameTable = "dbo.tbl_BaoHiem";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frBaoHiem()
        {
            InitializeComponent();
            BindingData();
        }

        private void frBaoHiem_Load(object sender, EventArgs e)
        {

        }

        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvBaohiem.DataSource = dt;
        }
    }
}
