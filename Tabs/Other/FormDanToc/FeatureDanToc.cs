using QLNhanSu.Tabs.Employees;
using QLNhanSu.Tabs.Employees.FormChucVu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Other.FormDanToc
{
    public partial class FeatureDanToc : Form
    {
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        int id;
        public FeatureDanToc()
        {
            InitializeComponent();
        }

        private void ptbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyNhanVien_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban chắc chắn không muốn thêm dân tộc nữa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void GetDataDanToc()
        {
            id = GlobalDataDanToc.SelectedId;
            txtDantoc.Text = GlobalDataDanToc.SelectedDanToc;
        }

        public void SetTextForm(string nameButton)
        {
            if (nameButton.Equals("Thêm"))
            {
                lblTitle.Text = "Thêm dân tộc";
                btnThemNhanVien.Text = "Thêm";
            }
            if (nameButton.Equals("Sửa"))
            {
                lblTitle.Text = "Sửa dân tộc";
                btnThemNhanVien.Text = "Sửa";
            }
            if (nameButton.Equals("Xem"))
            {
                lblTitle.Text = "Xem dân tộc";
                btnThemNhanVien.Visible = true;
                btnReset.Visible = true;
            }
        }
        public Boolean kiemTraDuLiieu()
        {
            string ten = txtDantoc.Text;
            if (ten.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtDantoc.Focus();
                return false;
            }
            return true;
        }
        public void ThemDanToc()
        {
            if (kiemTraDuLiieu())
            {
                string ten = txtDantoc.Text;
                if (ten.Trim() == "")
                {
                    MessageBox.Show("Mời bạn nhập dữ liệu ");
                    txtDantoc.Focus();
                    return;
                }

                try
                {
                    string query = "INSERT INTO tbl_DanToc VALUES (N'" + ten + "')";
                    bindingSQL.ThemNhanVien(query);
                    frDantoc position = (frDantoc)Application.OpenForms["frDantoc"];
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
            txtDantoc.Text = "";
        }

        public void SuaDanToc()
        {
            string ten = txtDantoc.Text;
            if (ten.Trim() == "")
            {
                MessageBox.Show("Mời bạn nhập dữ liệu ");
                txtDantoc.Focus();
                return;
            }

            try
            {
                string query = "UPDATE tbl_DanToc SET TENDT = '" + ten + "' WHERE IDDT = '" + id + "'";

                bindingSQL.ThemNhanVien(query);
                frPosition position = (frPosition)Application.OpenForms["frPosition"];
                if (position != null)
                {
                    position.RefreshData();
                }
                this.Close();
                txtDantoc.Text = "";
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
                ThemDanToc();

            }
            if (btnThemNhanVien.Text.Trim().Equals("Sửa"))
            {
                SuaDanToc();
            }
        }

        private void txtChucVu_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void FeatureDanToc_Load(object sender, EventArgs e)
        {

        }
    }
}
