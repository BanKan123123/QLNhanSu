using QLNhanSu.Tabs.Employees.FormChucVu;
using QLNhanSu.Tabs.Employees.FormChucVu.FeatureChucVu;
using QLNhanSu.Tabs.Other.FormDanToc;
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
        public void RefreshData()
        {
            BindingData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (DataGridViewRow)dgvDanToc.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            GlobalDataDanToc.SelectedId = id;
            GlobalDataDanToc.SelectedDanToc = row.Cells[1].Value.ToString();
        }
        public void XoaDanToc()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM tbl_DanToc WHERE IDCV = '" + GlobalDataDanToc.SelectedId + "'";
                    bindingSQL.XoaNhanVien(query);
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không có dữ liệu để xóa");
                }
            }
        }

        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvDanToc.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FeatureDanToc featureDanToc = new FeatureDanToc();
            featureDanToc.SetTextForm(btnThem.Text.Trim());
            featureDanToc.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FeatureDanToc featureDanToc = new FeatureDanToc();
            featureDanToc.SetTextForm(btnThem.Text.Trim());
            featureDanToc.GetDataDanToc();
            featureDanToc.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaDanToc();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string timkKiem = txtSearch.Text;
            if (String.IsNullOrEmpty(timkKiem) == false)
            {
                string query = "SELECT * FROM tbl_DanToc WHERE TENCV LIKE '%" + timkKiem + "%'";
                dgvDanToc.DataSource = bindingSQL.Search(query);
            }
            else
            {
                RefreshData();
            }
        }
    }
}
