using DevExpress.Map.Native;
using Microsoft.VisualBasic;
using QLNhanSu.Tabs.Employees.FormNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Employees.FormChucVu.FeatureChucVu
{
    public partial class FeatureChucVu : Form
    {
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        int id;
        public FeatureChucVu()
        {
            InitializeComponent();
        }

        private void frXemChucVu_Load(object sender, EventArgs e)
        {

        }

        private void ptbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyNhanVien_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban chắc chắn không muốn thêm nhân viên nữa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void GetDataChucVu()
        {
            id = GlobalDataChucVu.SelectedId;
            txtChucVu.Text = GlobalDataChucVu.SelectedChucVu;
        }

        public void SetTextForm(string nameButton)
        {
            if (nameButton.Equals("Thêm"))
            {
                lblTitle.Text = "Thêm chức vụ";
                btnThemNhanVien.Text = "Thêm";
            }
            if (nameButton.Equals("Sửa"))
            {
                lblTitle.Text = "Sửa chức vụ";
                btnThemNhanVien.Text = "Sửa";
            }
            if (nameButton.Equals("Xem"))
            {
                lblTitle.Text = "Xem chức vụ";
                btnThemNhanVien.Visible = true;
                btnReset.Visible = true;
            }
        }

        public Boolean kiemTraDuLiieu()
        {
            string ten = txtChucVu.Text;
            if (ten.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtChucVu.Focus();
                return false;
            }
            return true;
        }
        public void ThemChucVU()
        {
            if (kiemTraDuLiieu())
            {
                string ten = txtChucVu.Text;
                if (ten.Trim() == "")
                {
                    MessageBox.Show("Mời bạn nhập dữ liệu ");
                    txtChucVu.Focus();
                    return;
                }

                try
                {
                    string query = "INSERT INTO tbl_ChucVu VALUES ('" + ten + "')";
                    bindingSQL.ThemNhanVien(query);
                    frPosition position = (frPosition)Application.OpenForms["frPosition"];
                    if (position != null)
                    {
                        position.RefreshData();
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Reset()
        {
            txtChucVu.Text = "";
        }

        public void SuaChucVu()
        {
            string ten = txtChucVu.Text;
            if (ten.Trim() == "")
            {
                MessageBox.Show("Mời bạn nhập dữ liệu ");
                txtChucVu.Focus();
                return;
            }
            //string query1 = "SELECT * FROM tbl_DanToc WHERE TENDT = '" + ten + "'";
            //if (modify.GetDanToc(query1).Count > 0)
            //{
            //    MessageBox.Show("Tên dân tộc đã tồn tại");
            //    return;
            //}

            try
            {
                string query = "UPDATE tbl_ChucVu SET TENCV = '" + ten + "' WHERE IDCV = '" + id + "'";

                bindingSQL.ThemNhanVien(query);
                frPosition position = (frPosition)Application.OpenForms["frPosition"];
                if (position != null)
                {
                    position.RefreshData();
                }
                this.Close();
                txtChucVu.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (btnThemNhanVien.Text.Trim().Equals("Thêm"))
            {
                ThemChucVU();

            }
            if (btnThemNhanVien.Text.Trim().Equals("Sửa"))
            {
                SuaChucVu();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnHuyNhanVien_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban chắc chắn không muốn thêm chức vụ nữa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
