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
    public partial class frTangCa : Form
    {
        private readonly string nameTable = "dbo.tbl_TangCa";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frTangCa()
        {
            InitializeComponent();
            BindingData();
        }

        private void dgvTangCa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvTangCa.DataSource = dt;
        }
    }
}
