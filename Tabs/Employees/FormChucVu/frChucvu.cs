using QLNhanSu.Tabs.Employees.FormChucVu;
using QLNhanSu.Tabs.Employees.FormChucVu.FeatureChucVu;
using QLNhanSu.Tabs.Employees.FormChucVu.FormChucNang;
using QLNhanSu.Tabs.Employees.FormNhanVien;
using QLNhanSu.Tabs.Employees.FormNhanVien.FeatureNhanVien;
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
        public void RefreshData()
        {
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
            FeatureChucVu featureChucVu = new FeatureChucVu();
            featureChucVu.SetTextForm(btnThem.Text.Trim());
            featureChucVu.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FeatureChucVu featureChucVu = new FeatureChucVu();
            featureChucVu.SetTextForm(btnSua.Text.Trim());
            featureChucVu.GetDataChucVu();
            featureChucVu.Show();
        }

        private void frPosition_Load(object sender, EventArgs e)
        {

        }

        private void dgvChucvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (DataGridViewRow)dgvChucvu.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            GlobalDataChucVu.SelectedId = id;
            GlobalDataChucVu.SelectedChucVu = row.Cells[1].Value.ToString();
        }
        public void XoaChucVu()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM tbl_ChucVu WHERE IDCV = '" + GlobalDataChucVu.SelectedId + "'";
                    bindingSQL.XoaNhanVien(query);
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không có dữ liệu để xóa");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaChucVu();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string timkKiem = txtSearch.Text;
            if (String.IsNullOrEmpty(timkKiem) == false)
            {
                string query = "SELECT * FROM tbl_ChucVu WHERE TENCV LIKE '%" + timkKiem + "%'";
                dgvChucvu.DataSource = bindingSQL.Search(query);
            }
            else
            {
                RefreshData();
            }
        }
    }
}
