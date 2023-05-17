namespace QLNhanSu
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tclApp = new TabControl();
            tpSystem = new TabPage();
            btnLogout = new Button();
            btnHome = new Button();
            btnChPassword = new Button();
            tpEmploy = new TabPage();
            btnTrinhDo = new Button();
            btnDepart = new Button();
            btnPosition = new Button();
            btnEmploy = new Button();
            tpSalary = new TabPage();
            btnTinhLuong = new Button();
            btnThuong = new Button();
            btnTangCa = new Button();
            btnPhat = new Button();
            btnUngLuong = new Button();
            btnChamCong = new Button();
            tpOther = new TabPage();
            btnBaoHiem = new Button();
            btnHopDong = new Button();
            btnDanToc = new Button();
            btnTonGiao = new Button();
            pnlContainer = new Panel();
            tclApp.SuspendLayout();
            tpSystem.SuspendLayout();
            tpEmploy.SuspendLayout();
            tpSalary.SuspendLayout();
            tpOther.SuspendLayout();
            SuspendLayout();
            // 
            // tclApp
            // 
            tclApp.Controls.Add(tpSystem);
            tclApp.Controls.Add(tpEmploy);
            tclApp.Controls.Add(tpSalary);
            tclApp.Controls.Add(tpOther);
            tclApp.Location = new Point(0, 0);
            tclApp.Name = "tclApp";
            tclApp.SelectedIndex = 0;
            tclApp.Size = new Size(1300, 92);
            tclApp.TabIndex = 0;
            // 
            // tpSystem
            // 
            tpSystem.Controls.Add(btnLogout);
            tpSystem.Controls.Add(btnHome);
            tpSystem.Controls.Add(btnChPassword);
            tpSystem.Location = new Point(4, 32);
            tpSystem.Name = "tpSystem";
            tpSystem.Padding = new Padding(3);
            tpSystem.Size = new Size(1292, 56);
            tpSystem.TabIndex = 0;
            tpSystem.Text = "Hệ thống";
            tpSystem.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(944, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 56);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "      Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(234, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(150, 56);
            btnHome.TabIndex = 1;
            btnHome.Text = "      Trang chủ";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnChPassword
            // 
            btnChPassword.Image = (Image)resources.GetObject("btnChPassword.Image");
            btnChPassword.ImageAlign = ContentAlignment.MiddleLeft;
            btnChPassword.Location = new Point(588, 0);
            btnChPassword.Name = "btnChPassword";
            btnChPassword.Size = new Size(154, 56);
            btnChPassword.TabIndex = 0;
            btnChPassword.Text = "      Đổi mật khẩu";
            btnChPassword.UseVisualStyleBackColor = true;
            btnChPassword.Click += btnChPassword_Click;
            // 
            // tpEmploy
            // 
            tpEmploy.Controls.Add(btnTrinhDo);
            tpEmploy.Controls.Add(btnDepart);
            tpEmploy.Controls.Add(btnPosition);
            tpEmploy.Controls.Add(btnEmploy);
            tpEmploy.Location = new Point(4, 32);
            tpEmploy.Name = "tpEmploy";
            tpEmploy.Size = new Size(1292, 56);
            tpEmploy.TabIndex = 3;
            tpEmploy.Text = "Nhân sự";
            tpEmploy.UseVisualStyleBackColor = true;
            // 
            // btnTrinhDo
            // 
            btnTrinhDo.Image = Properties.Resources.icons8_level_30;
            btnTrinhDo.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrinhDo.Location = new Point(1005, 0);
            btnTrinhDo.Name = "btnTrinhDo";
            btnTrinhDo.Size = new Size(154, 56);
            btnTrinhDo.TabIndex = 5;
            btnTrinhDo.Text = "      Trình độ";
            btnTrinhDo.UseVisualStyleBackColor = true;
            btnTrinhDo.Click += btnTrinhDo_Click;
            // 
            // btnDepart
            // 
            btnDepart.Image = Properties.Resources.icons8_department_30;
            btnDepart.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepart.Location = new Point(728, 0);
            btnDepart.Name = "btnDepart";
            btnDepart.Size = new Size(154, 56);
            btnDepart.TabIndex = 3;
            btnDepart.Text = "      Phòng ban";
            btnDepart.UseVisualStyleBackColor = true;
            btnDepart.Click += btnDepart_Click;
            // 
            // btnPosition
            // 
            btnPosition.Image = Properties.Resources.icons8_position_30;
            btnPosition.ImageAlign = ContentAlignment.MiddleLeft;
            btnPosition.Location = new Point(424, 0);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(154, 56);
            btnPosition.TabIndex = 2;
            btnPosition.Text = "      Chức vụ";
            btnPosition.UseVisualStyleBackColor = true;
            btnPosition.Click += btnPosition_Click;
            // 
            // btnEmploy
            // 
            btnEmploy.Image = Properties.Resources.icons8_employee_30;
            btnEmploy.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmploy.Location = new Point(136, 0);
            btnEmploy.Name = "btnEmploy";
            btnEmploy.Size = new Size(154, 56);
            btnEmploy.TabIndex = 1;
            btnEmploy.Text = "      Nhân viên";
            btnEmploy.UseVisualStyleBackColor = true;
            btnEmploy.Click += btnEmploy_Click;
            // 
            // tpSalary
            // 
            tpSalary.Controls.Add(btnTinhLuong);
            tpSalary.Controls.Add(btnThuong);
            tpSalary.Controls.Add(btnTangCa);
            tpSalary.Controls.Add(btnPhat);
            tpSalary.Controls.Add(btnUngLuong);
            tpSalary.Controls.Add(btnChamCong);
            tpSalary.Location = new Point(4, 32);
            tpSalary.Name = "tpSalary";
            tpSalary.Padding = new Padding(3);
            tpSalary.Size = new Size(1292, 56);
            tpSalary.TabIndex = 1;
            tpSalary.Text = "Lương";
            tpSalary.UseVisualStyleBackColor = true;
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.Image = Properties.Resources.icons8_money_30;
            btnTinhLuong.ImageAlign = ContentAlignment.MiddleLeft;
            btnTinhLuong.Location = new Point(1090, 0);
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.Size = new Size(154, 56);
            btnTinhLuong.TabIndex = 6;
            btnTinhLuong.Text = "      Tính lương";
            btnTinhLuong.UseVisualStyleBackColor = true;
            btnTinhLuong.Click += btnTinhLuong_Click;
            // 
            // btnThuong
            // 
            btnThuong.Image = Properties.Resources.icons8_bonus_30;
            btnThuong.ImageAlign = ContentAlignment.MiddleLeft;
            btnThuong.Location = new Point(463, 0);
            btnThuong.Name = "btnThuong";
            btnThuong.Size = new Size(154, 56);
            btnThuong.TabIndex = 5;
            btnThuong.Text = "      Thưởng";
            btnThuong.UseVisualStyleBackColor = true;
            btnThuong.Click += btnThuong_Click;
            // 
            // btnTangCa
            // 
            btnTangCa.Image = Properties.Resources.icons8_overtime_30;
            btnTangCa.ImageAlign = ContentAlignment.MiddleLeft;
            btnTangCa.Location = new Point(882, 0);
            btnTangCa.Name = "btnTangCa";
            btnTangCa.Size = new Size(154, 56);
            btnTangCa.TabIndex = 4;
            btnTangCa.Text = "      Tăng ca";
            btnTangCa.UseVisualStyleBackColor = true;
            btnTangCa.Click += btnTangCa_Click;
            // 
            // btnPhat
            // 
            btnPhat.Image = Properties.Resources.icons8_soccer_yellow_card_30;
            btnPhat.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhat.Location = new Point(670, 0);
            btnPhat.Name = "btnPhat";
            btnPhat.Size = new Size(154, 56);
            btnPhat.TabIndex = 3;
            btnPhat.Text = "      Phạt";
            btnPhat.UseVisualStyleBackColor = true;
            btnPhat.Click += btnPhat_Click;
            // 
            // btnUngLuong
            // 
            btnUngLuong.Image = Properties.Resources.icons8_donate_30;
            btnUngLuong.ImageAlign = ContentAlignment.MiddleLeft;
            btnUngLuong.Location = new Point(250, 0);
            btnUngLuong.Name = "btnUngLuong";
            btnUngLuong.Size = new Size(154, 56);
            btnUngLuong.TabIndex = 2;
            btnUngLuong.Text = "      Ứng lương";
            btnUngLuong.UseVisualStyleBackColor = true;
            btnUngLuong.Click += btnUngLuong_Click;
            // 
            // btnChamCong
            // 
            btnChamCong.Image = Properties.Resources.icons8_timer_30;
            btnChamCong.ImageAlign = ContentAlignment.MiddleLeft;
            btnChamCong.Location = new Point(47, 0);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new Size(154, 56);
            btnChamCong.TabIndex = 1;
            btnChamCong.Text = "      Chấm công";
            btnChamCong.UseVisualStyleBackColor = true;
            btnChamCong.Click += btnChamCong_Click;
            // 
            // tpOther
            // 
            tpOther.Controls.Add(btnBaoHiem);
            tpOther.Controls.Add(btnHopDong);
            tpOther.Controls.Add(btnDanToc);
            tpOther.Controls.Add(btnTonGiao);
            tpOther.Location = new Point(4, 32);
            tpOther.Name = "tpOther";
            tpOther.Size = new Size(1292, 56);
            tpOther.TabIndex = 2;
            tpOther.Text = "Khác";
            tpOther.UseVisualStyleBackColor = true;
            // 
            // btnBaoHiem
            // 
            btnBaoHiem.Image = Properties.Resources.icons8_insurance_30;
            btnBaoHiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoHiem.Location = new Point(1008, 0);
            btnBaoHiem.Name = "btnBaoHiem";
            btnBaoHiem.Size = new Size(154, 56);
            btnBaoHiem.TabIndex = 5;
            btnBaoHiem.Text = "      Bảo hiểm";
            btnBaoHiem.UseVisualStyleBackColor = true;
            btnBaoHiem.Click += btnBaoHiem_Click;
            // 
            // btnHopDong
            // 
            btnHopDong.Image = Properties.Resources.icons8_contract_30;
            btnHopDong.ImageAlign = ContentAlignment.MiddleLeft;
            btnHopDong.Location = new Point(734, 0);
            btnHopDong.Name = "btnHopDong";
            btnHopDong.Size = new Size(154, 56);
            btnHopDong.TabIndex = 3;
            btnHopDong.Text = "      Hợp đồng";
            btnHopDong.UseVisualStyleBackColor = true;
            btnHopDong.Click += btnHopDong_Click;
            // 
            // btnDanToc
            // 
            btnDanToc.Image = Properties.Resources.icons8_nation_30;
            btnDanToc.ImageAlign = ContentAlignment.MiddleLeft;
            btnDanToc.Location = new Point(437, 0);
            btnDanToc.Name = "btnDanToc";
            btnDanToc.Size = new Size(154, 56);
            btnDanToc.TabIndex = 2;
            btnDanToc.Text = "      Dân tộc";
            btnDanToc.UseVisualStyleBackColor = true;
            btnDanToc.Click += btnDanToc_Click;
            // 
            // btnTonGiao
            // 
            btnTonGiao.Image = Properties.Resources.icons8_religion_30;
            btnTonGiao.ImageAlign = ContentAlignment.MiddleLeft;
            btnTonGiao.Location = new Point(136, 0);
            btnTonGiao.Name = "btnTonGiao";
            btnTonGiao.Size = new Size(154, 56);
            btnTonGiao.TabIndex = 2;
            btnTonGiao.Text = "      Tôn giáo";
            btnTonGiao.UseVisualStyleBackColor = true;
            btnTonGiao.Click += btnTonGiao_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.Location = new Point(4, 94);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1292, 682);
            pnlContainer.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1296, 773);
            Controls.Add(pnlContainer);
            Controls.Add(tclApp);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Main";
            Text = "Quản Lý Nhân Sự";
            Load += Main_Load;
            tclApp.ResumeLayout(false);
            tpSystem.ResumeLayout(false);
            tpEmploy.ResumeLayout(false);
            tpSalary.ResumeLayout(false);
            tpOther.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tpEmploy;
        private TabControl tclApp;
        private TabPage tpSystem;
        private Button btnChPassword;
        private TabPage tpSalary;
        private TabPage tpOther;
        private Button btnHome;
        private Button btnLogout;
        private Button btnChamCong;
        private Button btnEmploy;
        private Button btnPosition;
        private Button btnDepart;
        private Button btnTinhLuong;
        private Button btnThuong;
        private Button btnTangCa;
        private Button btnPhat;
        private Button btnUngLuong;
        private Button btnBaoHiem;
        private Button btnHopDong;
        private Button btnDanToc;
        private Button btnTonGiao;
        private Button btnTrinhDo;
        private Panel pnlContainer;
    }
}