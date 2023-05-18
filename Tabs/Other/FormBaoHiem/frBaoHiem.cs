using QLNhanSu.Tabs.Employees.FormNhanVien;
using QLNhanSu.Tabs.Other.FormBaoHiem;
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



        private void dgvBaohiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (DataGridViewRow)dgvBaohiem.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            GlobalDataBaoHiem.SelectedId = id;
            GlobalDataBaoHiem.SelectedSoBH = row.Cells[1].Value.ToString();
            GlobalDataBaoHiem.SelectedDate = row.Cells[2].Value.ToString();
            GlobalDataBaoHiem.SelectedNoiCap = row.Cells[3].Value.ToString();
            GlobalDataBaoHiem.SelectedKhamBenh = row.Cells[4].Value.ToString();
            GlobalDataBaoHiem.SelectedMasv = row.Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FeatureBaoHiem featureBaoHiem = new FeatureBaoHiem();
            featureBaoHiem.SetTextForm(btnThem.Text.Trim());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FeatureBaoHiem featureBaoHiem = new FeatureBaoHiem();
            featureBaoHiem.SetTextForm(btnSua.Text.Trim());
            featureBaoHiem.GetDataBaoHiem();
            featureBaoHiem.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM tbl_BaoHiem WHERE MANV = '" + GlobalDataBaoHiem.SelectedId + "'";
                    bindingSQL.XoaNhanVien(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không có dữ liệu để xóa");
                }
            }
        }

    }
}
