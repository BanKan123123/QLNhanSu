using QLNhanSu.BindingSQL;
using QLNhanSu.Tabs.Employees.FormNhanVien;
using QLNhanSu.Tabs.Employees.FormNhanVien.FeatureNhanVien;
using QLNhanSu.Tabs.Other;
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
    public partial class frEmploy : Form
    {
        private readonly string nameTable = "dbo.tbl_NhanVien";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();

        public frEmploy()
        {
            InitializeComponent();
            BindingData();
        }
        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvNhanvien.DataSource = dt;
        }
        private void frEmploy_Load(object sender, EventArgs e)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FeatureNhanVIen featureNhanVien = new FeatureNhanVIen();
            featureNhanVien.SetTextForm(btnThem.Text.Trim());
            featureNhanVien.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FeatureNhanVIen featureNhanVien = new FeatureNhanVIen();
            featureNhanVien.SetTextForm(btnSua.Text.Trim());
            featureNhanVien.GetDataNhanVien();
            featureNhanVien.Show();
        }

        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (DataGridViewRow)dgvNhanvien.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            GlobalDataNhanVien.SelectedId = id;
            GlobalDataNhanVien.SelectedHoTen = row.Cells[1].Value.ToString();
            GlobalDataNhanVien.SelectedGioiTinh = row.Cells[2].Value.ToString();
            GlobalDataNhanVien.SelectedNgaySinh = row.Cells[3].Value.ToString();
            GlobalDataNhanVien.SelectedDienThoai = row.Cells[4].Value.ToString();
            GlobalDataNhanVien.SelectedCCCD = row.Cells[5].Value.ToString();
            GlobalDataNhanVien.SelectedDiaChi = row.Cells[6].Value.ToString();
            GlobalDataNhanVien.SelectedPhongBan = row.Cells[7].Value.ToString();
            GlobalDataNhanVien.SelectedBoPhan = row.Cells[8].Value.ToString();
            GlobalDataNhanVien.SelectedChucVu = row.Cells[9].Value.ToString();
            GlobalDataNhanVien.SelectedTrinhDo = row.Cells[10].Value.ToString();
            GlobalDataNhanVien.SelectedDanToc = row.Cells[11].Value.ToString();
            GlobalDataNhanVien.SelectedTonGiao = row.Cells[12].Value.ToString();
            GlobalDataNhanVien.SelectedCongTy = row.Cells[13].Value.ToString();
        }
        public void XoaNhanVien()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM tbl_NhanVien WHERE MANV = '" + GlobalDataNhanVien.SelectedId + "'";
                    bindingSQL.XoaNhanVien(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không có dữ liệu để xóa");
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaNhanVien();
        }
    }
}
