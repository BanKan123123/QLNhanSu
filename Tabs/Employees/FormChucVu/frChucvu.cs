using QLNhanSu.Tabs.Employees.FormChucVu.FormChucNang;
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
    public partial class frPosition : Form
    {
        private readonly string nameTable = "dbo.tbl_ChucVu";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();

        public frPosition()
        {
            InitializeComponent();
            BindingData();
        }

        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvChucvu.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void frPosition_Load(object sender, EventArgs e)
        {

        }
    }
}
