using QLNhanSu.Tabs.Employees.FormNhanVien;
using QLNhanSu.Tabs.Other.FormHopDong;
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
    public partial class frHopDong : Form
    {
        private readonly string nameTable = "dbo.tbl_HopDong";
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public frHopDong()
        {
            InitializeComponent();
            BindingData();
        }
        public void BindingData()
        {
            DataTable dt = new DataTable();
            dt = bindingSQL.BindingData(nameTable);
            dgvBaoHiem.DataSource = dt;
        }


        private void dgvBaoHiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (DataGridViewRow)dgvBaoHiem.Rows[e.RowIndex];
            int shd = Convert.ToInt32(row.Cells[0].Value.ToString());
            GlobalDataHopDong.SelectedSoHopDong = shd;
            GlobalDataHopDong.SelectedNguoiDaiDien = row.Cells[1].Value.ToString();
            GlobalDataHopDong.SelectedNhanVien = row.Cells[2].Value.ToString();
            GlobalDataHopDong.SelectedNgayBatDau = row.Cells[3].Value.ToString();
            GlobalDataHopDong.SelectedNgayKetThuc = row.Cells[4].Value.ToString();
            GlobalDataHopDong.SelectedNgayKy = row.Cells[5].Value.ToString();
            GlobalDataHopDong.SelectedNoiDung = row.Cells[6].Value.ToString();
            GlobalDataHopDong.SelectedLanKy = Convert.ToInt32(row.Cells[7].Value.ToString());
            GlobalDataHopDong.SelectedThoiGian = row.Cells[8].Value.ToString();
            object selectedHeSoLuongObject = row.Cells[9].Value;
            if (selectedHeSoLuongObject != DBNull.Value)
            {
                double selectedHeSoLuong = Convert.ToDouble(selectedHeSoLuongObject);
                GlobalDataHopDong.SelectedHeSoLuong = (float)selectedHeSoLuong;
            }
            else
            {
                GlobalDataHopDong.SelectedHeSoLuong = 0.0f;
            }
            object SelectedLuongCoBanObject = row.Cells[10].Value;
            if (SelectedLuongCoBanObject != DBNull.Value)
            {
                double selectedLuongCoBan = Convert.ToDouble(SelectedLuongCoBanObject);
                GlobalDataHopDong.SelectedLuongCoBan = (float)selectedLuongCoBan;
            }
            else
            {
                GlobalDataHopDong.SelectedLuongCoBan = 0.0f;
            }
            GlobalDataHopDong.SelectedLoaiHopDong = row.Cells[11].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FeatureHopDong featureHopDong = new FeatureHopDong();
            featureHopDong.SetTextForm(btnThem.Text.Trim());
            featureHopDong.Show();
        }

        private void frHopDong_Load(object sender, EventArgs e)
        {

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            FeatureHopDong featureHopDong = new FeatureHopDong();
            featureHopDong.SetTextForm(btnSua.Text.Trim());
            featureHopDong.GetDataHopDong();
            featureHopDong.Show();
        }

        public void XoaNhanVien()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM tbl_NhanVien WHERE MANV = '" + GlobalDataHopDong.SelectedSoHopDong + "'";
                    bindingSQL.XoaNhanVien(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaNhanVien();
        }
    }
}
