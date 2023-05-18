using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Other.FormHopDong
{
    public partial class FeatureHopDong : Form
    {
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        int shd;
        public FeatureHopDong()
        {
            InitializeComponent();
        }

        private void FeatureHopDong_Load(object sender, EventArgs e)
        {

        }
        public void reset()
        {
            txtHeSoLuong.Text = "";
            txtLanKy.Text = "";
            txtLoaiHopDong.Text = "";
            txtNoiDung.Text = "";
            txtSoHopDong.Text = "";
            txtThoiHan.Text = "";

            dtpNgayBatDau.Text = "";
            dtpNgayKetThuc.Text = "";
            dtpNgayKy.Text = "";

            cboNguoiDaiDien.Text = "";
            cboNhanVien.Text = "";
        }

        public void GetDataSelectNhanVien()
        {

        }

        public void SetTextForm(string nameButton)
        {
            if (nameButton.Equals("Thêm"))
            {
                lblTitleHopDong.Text = "Thêm Nhân Viên";
                btnThemHopDong.Text = "Thêm";
            }
            if (nameButton.Equals("Sửa"))
            {
                lblTitleHopDong.Text = "Sửa Nhân Viên";
                btnThemHopDong.Text = "Sửa";
            }
            if (nameButton.Equals("Xem"))
            {
                lblTitleHopDong.Text = "Xem Nhân Viên";
                btnThemHopDong.Visible = true;
                btnReset.Visible = true;
            }
        }

        public Boolean kiemTraDuLieu()
        {
            string soHopDong, nguoiDaiDien, nhanVien, ngayBatDau, ngayKetThuc, ngayKy, thoiHan, lanKy, hsl, loaiHopDong, congTy, noiDung;

            soHopDong = txtSoHopDong.Text;
            if (soHopDong.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtSoHopDong.Focus();
                return false;
            }

            nguoiDaiDien = cboNguoiDaiDien.Text;
            if (nguoiDaiDien.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                cboNguoiDaiDien.Focus();
                return false;
            }



            nhanVien = cboNhanVien.Text;
            if (nhanVien.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                cboNhanVien.Focus();
                return false;
            }

            ngayBatDau = dtpNgayBatDau.Text;
            if (ngayBatDau.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                dtpNgayBatDau.Focus();
                return false;
            }

            ngayKetThuc = dtpNgayKetThuc.Text;
            if (ngayKetThuc.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                dtpNgayKetThuc.Focus();
                return false;
            }


            ngayKy = dtpNgayKy.Text;
            if (ngayKy.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                dtpNgayKy.Focus();
                return false;
            }


            thoiHan = txtThoiHan.Text;
            if (thoiHan.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtThoiHan.Focus();
                return false;
            }

            lanKy = txtLanKy.Text;
            if (Int32.TryParse(lanKy.Trim(), out int a) == false)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtLanKy.Focus();
                return false;
            }

            hsl = txtHeSoLuong.Text;
            if (Double.TryParse(hsl, out double b) == false)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtHeSoLuong.Focus();
                return false;
            }

            loaiHopDong = txtLoaiHopDong.Text;
            if (loaiHopDong.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtLoaiHopDong.Focus();
                return false;
            }

            noiDung = txtNoiDung.Text;
            if (noiDung.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtNoiDung.Focus();
                return false;
            }

            string lcb = txtLuongCoBan.Text;
            if (Double.TryParse(lcb, out double c) == false)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtLuongCoBan.Focus();
                return false;
            }
            return true;

        }

        public void luuThem()
        {
            if (kiemTraDuLieu())
            {
                string soHopDong = txtSoHopDong.Text;
                int nguoiDaiDien = Convert.ToInt32(cboNguoiDaiDien.SelectedValue);
                int nhanVien = Convert.ToInt32(cboNhanVien.SelectedValue);
                string ngayBatDau = dtpNgayBatDau.Text;
                string ngayKetThuc = dtpNgayKetThuc.Text;
                string ngayKy = dtpNgayKy.Text;
                string noiDung = txtNoiDung.Text;
                int lanKy = Convert.ToInt32(txtLanKy.Text);
                string thoiHan = txtThoiHan.Text;
                string hsl = txtHeSoLuong.Text;
                double lcb = Convert.ToDouble(txtLuongCoBan.Text);
                string loaiHopDong = txtLoaiHopDong.Text;
                //int maCty = Convert.ToInt32(cboCongTy.SelectedValue);
                try
                {
                    string query = "INSERT INTO tbl_HopDong VALUES ('" + soHopDong + "' , '" + nguoiDaiDien + "' , '" + nhanVien + "' , '" + ngayBatDau + "' , '" + ngayKetThuc + "' , '" + ngayKy + "' , '" + noiDung + "' , '" + lanKy + "' , '" + thoiHan + "' ,'" + lcb + "' ,  '" + hsl + "' , '" + loaiHopDong + "' , '" + 1 + "')";
                    bindingSQL.ThemNhanVien(query);
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không thể thêm được");
                }
            }
        }

        public void luuSua()

        {

            if (kiemTraDuLieu())
            {
                string soHopDong = txtSoHopDong.Text;
                int nguoiDaiDien = Convert.ToInt32(cboNguoiDaiDien.SelectedValue);
                int nhanVien = Convert.ToInt32(cboNhanVien.SelectedValue);
                string ngayBatDau = dtpNgayBatDau.Text;
                string ngayKetThuc = dtpNgayKetThuc.Text;
                string ngayKy = dtpNgayKy.Text;
                string noiDung = txtNoiDung.Text;
                int lanKy = Convert.ToInt32(txtLanKy.Text);
                string thoiHan = txtThoiHan.Text;
                double hsl = Convert.ToDouble(txtHeSoLuong.Text);
                string loaiHopDong = txtLoaiHopDong.Text;
                //int maCty = Convert.ToInt32(cboCongTy.SelectedValue);
                double lcb = Convert.ToDouble(txtLuongCoBan.Text);

                try
                {
                    string query = "UPDATE tbl_HopDong SET SOHD = '" + soHopDong + "' , NGUOIDAIDIEN = '" + nguoiDaiDien + "' , MANV = '" + nhanVien + "' , NGAYBATDAU = '" + ngayBatDau + "' , NGAYKETTHUC = '" + ngayKetThuc + "' , NGAYKY = '" + ngayKy + "' ,NOIDUNG = '" + noiDung + "' , LANKY = '" + lanKy + "' , THOIHAN = '" + thoiHan + "' , LUONGCOBAN = '" + lcb + "' , HESOLUONG = '" + hsl + "' ,LOAIHOPDONG = '" + loaiHopDong + "' , MACTY ='" + 1 + "' WHERE SOHD ='" + shd + "' ";
                    bindingSQL.ThemNhanVien(query);
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không thể sửa được");
                }
            }
        }

    }
}
