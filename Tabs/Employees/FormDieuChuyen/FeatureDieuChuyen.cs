using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Employees.FormDieuChuyen
{
    public partial class FeatureDieuChuyen : Form
    {
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        public FeatureDieuChuyen()
        {
            InitializeComponent();
        }
        private void ptbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetDataSelectedDieuChuyen()
        {
            cboMaNV.DataSource = bindingSQL.GetManv();
            cboMaNV.DisplayMember = "MANV";
            cboMaNV.ValueMember = "MANV";

            cboMaPBMoi.DataSource = bindingSQL.GetPhongBan();
            cboMaPBMoi.DisplayMember = "IDPB";
            cboMaPBMoi.ValueMember = "IDPB";

            cboMaCTYMoi.DataSource = bindingSQL.GetMACTY();
            cboMaCTYMoi.DisplayMember = "MACTY";
            cboMaCTYMoi.ValueMember = "MACTY";
        }

        public void SetTextForm(string nameButton)
        {
            if (nameButton.Equals("Điều chuyển"))
            {
                lblTitle.Text = "Điều chuyển";
                btnDieuChuyen.Text = "Điều chuyển";
                GetDataSelectedDieuChuyen();
            }
            if (nameButton.Equals("Sửa"))
            {
                lblTitle.Text = "Sửa điều chuyển";
                btnDieuChuyen.Text = "Sửa";
            }
            if (nameButton.Equals("Xem"))
            {
                lblTitle.Text = "Xem điều chuyển";
                btnDieuChuyen.Text = "Thoát";
                btnCancel.Visible = true;
                btnReset.Visible = true;
            }
        }

        private void FeatureDieuChuyen_Load(object sender, EventArgs e)
        {
            cboMaNV.SelectedIndex = -1;
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedIndex > 0)
            {
                cboMaPBCu.DataSource = bindingSQL.GetIdphongban(Convert.ToInt32(cboMaNV.SelectedValue));
                cboMaPBCu.DisplayMember = "IDPB";
                cboMaPBCu.ValueMember = "IDPB";
                //GetMaCTY
                cboMaCTYCu.DataSource = bindingSQL.GetMACTYOfEmply(Convert.ToInt32(cboMaNV.SelectedValue));
                cboMaCTYCu.DisplayMember = "MACTY";
                cboMaCTYCu.ValueMember = "MACTY";
            }
        }

        private void cboMaCTYMoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
