using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Employees.FormTangLuong
{
    public partial class frTangLuong : Form
    {
        private readonly string nameTable = "dbo.tbl_TangLuong";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frTangLuong()
        {
            InitializeComponent();
            BindingData();
        }

        private void frTangLuong_Load(object sender, EventArgs e)
        {

        }

        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvTangLuong.DataSource = dt;
        }
    }
}
