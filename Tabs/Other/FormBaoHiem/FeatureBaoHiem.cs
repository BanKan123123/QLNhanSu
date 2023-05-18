using QLNhanSu.Tabs.Employees.FormNhanVien;

namespace QLNhanSu.Tabs.Other.FormBaoHiem
{
    public partial class FeatureBaoHiem : Form
    {
        QLNhanSu.BindingSQL.BindingSQL bindingSQL = new BindingSQL.BindingSQL();
        int id;
        public FeatureBaoHiem()
        {
            InitializeComponent();
        }

        private void FeatureBaoHiem_Load(object sender, EventArgs e)
        {

        }

        public Boolean kiemTraDuLieu()
        {
            string soBH, date, noiCap, noiKham, manv;

            soBH = txtSoBaoHiem.Text;
            if (soBH.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtSoBaoHiem.Focus();
                return false;
            }
            date = dtpDate.Text;

            if (date.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                dtpDate.Focus();
                return false;
            }
            noiCap = txtNoiCap.Text;
            if (noiCap.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtNoiCap.Focus();
                return false;
            }
            noiKham = txtNoiKham.Text;
            if (noiKham.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                txtNoiKham.Focus();
                return false;
            }
            manv = cboMasv.Text;
            if (manv.Trim() == "")
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                cboMasv.Focus();
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban chắc chắn không muốn thêm nhân viên nữa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void GetDataSelectNhanVien()
        {
            cboMasv.DataSource = bindingSQL.GetManv();
        }
        public void SetTextForm(string nameButton)
        {
            if (nameButton.Equals("Thêm"))
            {
                lblTitleBaoHiem.Text = "Thêm Nhân Viên";
                btnThemBaoHiem.Text = "Thêm";
                GetDataSelectNhanVien();
                this.Show();
            }
            if (nameButton.Equals("Sửa"))
            {
                lblTitleBaoHiem.Text = "Sửa Nhân Viên";
                btnThemBaoHiem.Text = "Sửa";
                GetDataSelectNhanVien();
                this.Show();
            }
            if (nameButton.Equals("Xem"))
            {
                lblTitleBaoHiem.Text = "Xem Nhân Viên";
                btnThemBaoHiem.Visible = true;
                btnReset.Visible = true;
            }
        }
        public void GetDataBaoHiem()
        {
            id = GlobalDataNhanVien.SelectedId;
            txtSoBaoHiem.Text = GlobalDataBaoHiem.SelectedSoBH;
            dtpDate.Text = GlobalDataBaoHiem.SelectedDate;
            txtNoiCap.Text = GlobalDataBaoHiem.SelectedNoiCap;
            txtNoiKham.Text = GlobalDataBaoHiem.SelectedKhamBenh;
            cboMasv.Text = GlobalDataBaoHiem.SelectedMasv;
        }

        public void Reset()
        {
            txtSoBaoHiem.Text = "";
            dtpDate.Text = "";
            txtNoiCap.Text = "";
            txtNoiKham.Text = "";
            cboMasv.SelectedIndex = -1;
        }

        public void ThemBaoHiemNhanVien()
        {
            try
            {
                if (kiemTraDuLieu())
                {
                    string soBH, date, noiCap, noiKham, manv;
                    soBH = txtSoBaoHiem.Text;
                    date = dtpDate.Value.ToString("yyyy-MM-dd");
                    noiCap = txtNoiCap.Text;
                    noiKham = txtNoiKham.Text;
                    manv = cboMasv.SelectedValue.ToString();
                    string query = "INSERT INTO tbl_BaoHiem VALUES ('" + soBH + "', '" + date + "', '" + noiCap + " ' , '" + noiKham + "', '" + manv + "')";
                    bindingSQL.ThemNhanVien(query);
                    this.Close();
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SuaBaoHiemNhanVien()
        {
            try
            {
                if (kiemTraDuLieu())
                {
                    string soBH, date, noiCap, noiKham, manv;
                    soBH = txtSoBaoHiem.Text;
                    date = dtpDate.Value.ToString("yyyy-MM-dd");
                    noiCap = txtNoiCap.Text;
                    noiKham = txtNoiKham.Text;
                    manv = cboMasv.SelectedValue.ToString();

                    string query = "UPDATE tbl_BaoHiem SET SOBH = '" + soBH + "', NGAYCAP = '" + date + "', NOICAP = '" + noiCap + "', NOIKHAMBENH = '" + noiKham + "', MANV = '" + manv + "' WHERE IDBH = '" + id + "'";
                    bindingSQL.ThemNhanVien(query);
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemBaoHiem_Click(object sender, EventArgs e)
        {
            if (btnThemBaoHiem.Text.Trim().Equals("Thêm"))
            {
                ThemBaoHiemNhanVien();
            }
            if (btnThemBaoHiem.Text.Trim().Equals("Sửa"))
            {
                SuaBaoHiemNhanVien();
            }
        }
    }
}
