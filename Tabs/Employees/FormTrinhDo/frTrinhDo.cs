using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Employees
{
    public partial class frTrinhDo : Form
    {
        private readonly string nameTable = "dbo.tbl_TrinhDo";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frTrinhDo()
        {
            InitializeComponent();
            BindingData();
        }

        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvTrinhdo.DataSource = dt;
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
