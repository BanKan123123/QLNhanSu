using QLNhanSu.BindingSQL;
using QLNhanSu.Tabs.Employees;
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

        frHome frHome = new frHome();
        frChPassword frChPassword = new frChPassword();
        Auth auth = new Auth();
        frEmploy employ = new frEmploy();
        frPosition position = new frPosition();
        frDepart depart = new frDepart();
        frTrinhDo frTrinhDo = new frTrinhDo();
        frChamCong frChamCong = new frChamCong();
        frUngLuong frUngLuong = new frUngLuong();
        frThuong frThuong = new frThuong();
        frPhat frPhat = new frPhat();
        frTangCa frTangCa = new frTangCa();
        frTinhLuong frTinhLuong = new frTinhLuong();
        frTonGiao frTonGiao = new frTonGiao();
        frDantoc frDantoc = new frDantoc();
        frHopDong frHopGiao = new frHopDong();
        frBaoHiem frBaoHiem = new frBaoHiem();

        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }



        public void ShowChildForm(Panel pnlContainer, Form childrent)
        {
            childrent.MdiParent = this;
            childrent.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(childrent);
            pnlContainer.Tag = childrent;
            childrent.BringToFront();
            childrent.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frHome);
        }
        private void btnChPassword_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frChPassword);
            frHome.Hide();
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
            ShowChildForm(pnlContainer, employ);
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, position);
            employ.Hide();
        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, depart);
            position.Hide();
        }

        private void btnTrinhDo_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frTrinhDo);
            depart.Hide();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frChamCong);
        }

        private void btnUngLuong_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frUngLuong);
            frChamCong.Hide();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frThuong);
            frUngLuong.Hide();
        }

        private void btnPhat_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frPhat);
            frThuong.Hide();
        }

        private void btnTangCa_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frTangCa);
            frPhat.Hide();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frTinhLuong);
            frTangCa.Hide();
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frTonGiao);
            frTinhLuong.Hide();
        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frDantoc);
            frTonGiao.Hide();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frHopGiao);
            frDantoc.Hide();
        }

        private void btnBaoHiem_Click(object sender, EventArgs e)
        {
            ShowChildForm(pnlContainer, frBaoHiem);
            frHopGiao.Hide();
        }
    }
}
