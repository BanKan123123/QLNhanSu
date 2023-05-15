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
    public partial class frDepart : Form
    {
        private readonly string nameTable = "dbo.tbl_PhongBan";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frDepart()
        {
            InitializeComponent();
            BindingData();
        }

        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvPhongban.DataSource = dt;
        }
        private void frDepart_Load(object sender, EventArgs e)
        {

        }
    }
}
