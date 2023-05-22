using QLNhanSu.BindingSQL;
using QLNhanSu.Tabs.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Employees.FormNhanVien.FeatureNhanVien
{
    public partial class FeatureNhanVIen : Form
    {
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        int id;
        public FeatureNhanVIen()
        {
            InitializeComponent();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrThemNhanVien_Load(object sender, EventArgs e)
        {


        }

        public void GetDataSelectNhanVien()
        {
            cboDanToc.DataSource = bindingSQL.BindingData("tbl_DanToc");
            cboDanToc.DisplayMember = "tenDt";
            cboDanToc.ValueMember = "idDt";

            cboBoPhan.DataSource = bindingSQL.BindingData("tbl_BoPhan");
            cboBoPhan.DisplayMember = "tenBp";
            cboBoPhan.ValueMember = "idBp";

            //cboCongTy.DataSource = bindingSQL.BindingData("tbl_DanToc");
            //cboCongTy.DisplayMember = "tenCty";
            //cboCongTy.ValueMember = "maCty";

            cboChucVu.DataSource = bindingSQL.BindingData("tbl_ChucVu");
            cboChucVu.DisplayMember = "tenCv";
            cboChucVu.ValueMember = "idCv";

            cboPhongBan.DataSource = bindingSQL.BindingData("tbl_PhongBan");
            cboPhongBan.DisplayMember = "tenPb";
            cboPhongBan.ValueMember = "idPb";

            cboTonGiao.DataSource = bindingSQL.BindingData("tbl_TonGiao");
            cboTonGiao.DisplayMember = "tenTg";
            cboTonGiao.ValueMember = "idTg";

            cboTrinhDo.DataSource = bindingSQL.BindingData("tbl_TrinhDo");
            cboTrinhDo.DisplayMember = "tenTd";
            cboTrinhDo.ValueMember = "idTd";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHuyNhanVien_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban chắc chắn không muốn thêm nhân viên nữa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (btnThemNhanVien.Text.Trim().Equals("Thêm"))
            {
                ThemNhanVien();

            }
            if (btnThemNhanVien.Text.Trim().Equals("Sửa"))
            {
                SuaNhanVien();
            }
        }

        public void GetDataNhanVien()
        {
            id = GlobalDataNhanVien.SelectedId;
            txtHoten.Text = GlobalDataNhanVien.SelectedHoTen;
            dtpDate.Text = GlobalDataNhanVien.SelectedNgaySinh;
            string sex = GlobalDataNhanVien.SelectedGioiTinh;
            if (sex.Equals("Nu"))
            {
                rdoNu.Checked = true;
            }
            else if (sex.Equals("Nam"))
            {
                rdoNam.Checked = true;
            }
            txtDienThoai.Text = GlobalDataNhanVien.SelectedDienThoai;
            txtCCCD.Text = GlobalDataNhanVien.SelectedCCCD;
            txtDiaChi.Text = GlobalDataNhanVien.SelectedDiaChi;

            cboBoPhan.Text = GlobalDataNhanVien.SelectedBoPhan;
            cboChucVu.Text = GlobalDataNhanVien.SelectedChucVu;
            cboDanToc.Text = GlobalDataNhanVien.SelectedDanToc;
            cboPhongBan.Text = GlobalDataNhanVien.SelectedPhongBan;
            cboTonGiao.Text = GlobalDataNhanVien.SelectedTonGiao;
            cboTrinhDo.Text = GlobalDataNhanVien.SelectedTrinhDo;
        }

        public void SetTextForm(string nameButton)
        {
            if (nameButton.Equals("Thêm"))
            {
                lblTitleNhanVien.Text = "Thêm Nhân Viên";
                btnThemNhanVien.Text = "Thêm";
                GetDataSelectNhanVien();
            }
            if (nameButton.Equals("Sửa"))
            {
                lblTitleNhanVien.Text = "Sửa Nhân Viên";
                btnThemNhanVien.Text = "Sửa";
                GetDataSelectNhanVien();
            }
            if (nameButton.Equals("Xem"))
            {
                lblTitleNhanVien.Text = "Xem Nhân Viên";
                btnThemNhanVien.Visible = true;
                btnReset.Visible = true;
            }
        }

        public void reset()
        {
            txtCCCD.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtHoten.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            dtpDate.Text = "";

            cboBoPhan.Text = "";
            cboChucVu.Text = "";
            cboDanToc.Text = "";
            cboPhongBan.Text = "";
            cboTonGiao.Text = "";
            cboTrinhDo.Text = "";
        }

        public Boolean kiemTraDuLiieu()
        {
            string ten, gioiTinh, ngaySinh, cccd, dienThoai, diaChi;
            string tencv, tentd, tenpb, tenbp, tendt, tentg;
            ten = txtHoten.Text;
            if (ten.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtHoten.Focus();
                return false;
            }

            ngaySinh = dtpDate.Text;
            if (ngaySinh.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                dtpDate.Focus();
                return false;
            }

            gioiTinh = "";
            if (rdoNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdoNu.Checked)
            {
                gioiTinh = "Nu";
            }
            if (gioiTinh.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");

                return false;
            }

            cccd = txtCCCD.Text;
            if (cccd.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtCCCD.Focus();
                return false;
            }

            dienThoai = txtDienThoai.Text;
            if (dienThoai.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtDienThoai.Focus();
                return false;
            }

            diaChi = txtDiaChi.Text;
            if (diaChi.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtDiaChi.Focus();
                return false;
            }


            tencv = cboChucVu.Text;
            if (tencv.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                cboChucVu.Focus();
                return false;
            }

            tentd = cboTrinhDo.Text;
            if (tentd.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                cboTrinhDo.Focus();
                return false;
            }

            tenpb = cboPhongBan.Text;
            if (tenpb.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                cboPhongBan.Focus();
                return false;
            }

            tenbp = cboBoPhan.Text;
            if (tenbp.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                cboBoPhan.Focus();
                return false;
            }

            tendt = cboDanToc.Text;
            if (tendt.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                cboDanToc.Focus();
                return false;
            }

            tentg = cboTonGiao.Text;
            if (tentg.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                cboTonGiao.Focus();
                return false;
            }

            return true;
        }

        public void ThemNhanVien()
        {
            if (kiemTraDuLiieu())
            {
                string ten, gioiTinh, ngaySinh, cccd, dienThoai, diaChi;
                int idcv, idtd, idpb, idbp, iddt, idtg;
                ten = txtHoten.Text;
                ngaySinh = dtpDate.Value.ToString("yyyy-MM-dd");
                gioiTinh = "";
                if (rdoNam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else if (rdoNu.Checked)
                {
                    gioiTinh = "Nu";
                }
                cccd = txtCCCD.Text;
                dienThoai = txtDienThoai.Text;
                diaChi = txtDiaChi.Text;

                idcv = Convert.ToInt32(cboChucVu.SelectedValue);
                idtd = Convert.ToInt32(cboTrinhDo.SelectedValue);

                idpb = Convert.ToInt32(cboPhongBan.SelectedValue);


                idbp = Convert.ToInt32(cboBoPhan.SelectedValue);

                idtg = Convert.ToInt32(cboTonGiao.SelectedValue);
                iddt = Convert.ToInt32(cboDanToc.SelectedValue);

                try
                {
                    string query = "INSERT INTO tbl_NhanVien VALUES (N'" + ten + "' , N'" + gioiTinh + "' ,  '" + ngaySinh + "' , '" + dienThoai + "' , '" + cccd + "'  , N'" + diaChi + "' , '" + idpb + "' , '" + idbp + "' , '" + idcv + "' , '" + idtd + "', '" + iddt + "' , '" + idtg + "' , '" + 1 + "'  , '" + "" + "' )";
                    bindingSQL.ThemNhanVien(query);
                    frEmploy employ = (frEmploy)Application.OpenForms["frEmploy"];
                    if (employ != null)
                    {
                        employ.RefreshData();
                    }
                    this.Close();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void SuaNhanVien()
        {
            if (kiemTraDuLiieu())
            {
                string ten, gioiTinh, ngaySinh, cccd, dienThoai, diaChi;
                int idcv, idtd, idpb, idbp, iddt, idtg, macty;
                ten = txtHoten.Text;
                ngaySinh = dtpDate.Text;
                gioiTinh = "";
                if (rdoNam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else if (rdoNu.Checked)
                {
                    gioiTinh = "Nu";
                }
                cccd = txtCCCD.Text;
                dienThoai = txtDienThoai.Text;
                diaChi = txtDiaChi.Text;

                idcv = Convert.ToInt32(cboChucVu.SelectedValue);
                idtd = Convert.ToInt32(cboTrinhDo.SelectedValue);

                idpb = Convert.ToInt32(cboPhongBan.SelectedValue);


                idbp = Convert.ToInt32(cboBoPhan.SelectedValue);

                idtg = Convert.ToInt32(cboTonGiao.SelectedValue);
                iddt = Convert.ToInt32(cboDanToc.SelectedValue);
                try
                {
                    string query = "UPDATE tbl_NhanVien SET  HOTEN = N'" + ten + "' , GIOITINH = N'" + gioiTinh + "' , NGAYSINH = '" + ngaySinh + "' , DIENTHOAI = '" + dienThoai + "' , CCCD = '" + cccd + "' , DIACHI = '" + diaChi + "' , IDPB = '" + idpb + "' , IDBP = '" + idbp + "' , IDCV = '" + idcv + "' ,IDTD = '" + idtd + "', IDDT = '" + iddt + "' , IDTG = '" + idtg + "' ,MACTY = '" + 1 + "' WHERE MANV = '" + id + "' ";
                    bindingSQL.ThemNhanVien(query);
                    frEmploy employ = (frEmploy)Application.OpenForms["frEmploy"];
                    if (employ != null)
                    {
                        employ.RefreshData();
                    }
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

    }

}
