using QLNhanSu.BindingSQL;
using QLNhanSu.Tabs.Employees;
using QLNhanSu.Tabs.Employees.FormTangLuong;
using QLNhanSu.Tabs.Home;
using QLNhanSu.Tabs.Other;
using QLNhanSu.Tabs.Salary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu
{
    public partial class Main : Form
    {
        Auth auth = new Auth();
        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private Form currentFormChild;
        private void openChildFrom(Form childFrom)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(childFrom);
            pnlContainer.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildFrom(new frHome());
        }
        private void btnChPassword_Click(object sender, EventArgs e)
        {
            openChildFrom(new frChPassword());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                auth.Show();
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnEmploy_Click(object sender, EventArgs e)
        {
            openChildFrom(new frEmploy());
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            openChildFrom(new frPosition());
        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            openChildFrom(new frDepart());
        }

        private void btnTrinhDo_Click(object sender, EventArgs e)
        {
            openChildFrom(new frTrinhDo());
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            openChildFrom(new frChamCong());
        }

        private void btnUngLuong_Click(object sender, EventArgs e)
        {
            openChildFrom(new frUngLuong());
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            openChildFrom(new frThuong());
        }

        private void btnPhat_Click(object sender, EventArgs e)
        {
            openChildFrom(new frPhat());
        }

        private void btnTangCa_Click(object sender, EventArgs e)
        {
            openChildFrom(new frTangCa());
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            openChildFrom(new frTinhLuong());
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            openChildFrom(new frTonGiao());
        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            openChildFrom(new frDantoc());
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            openChildFrom(new frHopDong());
        }

        private void btnBaoHiem_Click(object sender, EventArgs e)
        {
            openChildFrom(new frBaoHiem());
        }

        private void btnTangLuong_Click(object sender, EventArgs e)
        {
            openChildFrom(new frTangLuong());
        }
    }
}
