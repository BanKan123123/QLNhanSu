using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Employees.FormDieuChuyen
{
    public partial class frDieuChuyen : Form
    {
        private readonly string nameTable = "dbo.tbl_DieuChuyen";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frDieuChuyen()
        {
            InitializeComponent();
            BindingData();
        }

        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvDieuChuyen.DataSource = dt;
        }
    }
}
