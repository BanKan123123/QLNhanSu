namespace QLNhanSu.Tabs.Employees.FormNhanVien.FeatureNhanVien
{
    partial class FeatureNhanVIen
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
            label1 = new Label();
            btnThemNhanVien = new Button();
            txtHoten = new TextBox();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            label3 = new Label();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            txtCCCD = new TextBox();
            label4 = new Label();
            txtDienThoai = new TextBox();
            label5 = new Label();
            txtDiaChi = new TextBox();
            label6 = new Label();
            btnAnh = new Button();
            label7 = new Label();
            cboTrinhDo = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            cboBoPhan = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            cboTonGiao = new ComboBox();
            label12 = new Label();
            cboDanToc = new ComboBox();
            cboPhongBan = new ComboBox();
            cboChucVu = new ComboBox();
            btnHuyNhanVien = new Button();
            label13 = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 152);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên:";
            // 
            // btnThemNhanVien
            // 
            btnThemNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemNhanVien.Location = new Point(934, 677);
            btnThemNhanVien.Name = "btnThemNhanVien";
            btnThemNhanVien.Size = new Size(166, 49);
            btnThemNhanVien.TabIndex = 1;
            btnThemNhanVien.Text = "Thêm";
            btnThemNhanVien.UseVisualStyleBackColor = true;
            btnThemNhanVien.Click += btnThemNhanVien_Click;
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(184, 149);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(467, 30);
            txtHoten.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 213);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 3;
            label2.Text = "Ngày sinh:";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(184, 206);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(136, 30);
            dtpDate.TabIndex = 4;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 213);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 5;
            label3.Text = "Giới Tính:";
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(511, 210);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(68, 27);
            rdoNam.TabIndex = 6;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(597, 210);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(54, 27);
            rdoNu.TabIndex = 7;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(184, 262);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(467, 30);
            txtCCCD.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 265);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 8;
            label4.Text = "CCCD:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(184, 323);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(467, 30);
            txtDienThoai.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 326);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 10;
            label5.Text = "Điện thoại: ";
            label5.Click += label5_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(184, 377);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(467, 30);
            txtDiaChi.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 380);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 12;
            label6.Text = "Địa chỉ:";
            // 
            // btnAnh
            // 
            btnAnh.Location = new Point(872, 337);
            btnAnh.Name = "btnAnh";
            btnAnh.Size = new Size(137, 35);
            btnAnh.TabIndex = 15;
            btnAnh.Text = "Chọn ảnh";
            btnAnh.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 439);
            label7.Name = "label7";
            label7.Size = new Size(76, 23);
            label7.TabIndex = 16;
            label7.Text = "Chức vụ:";
            // 
            // cboTrinhDo
            // 
            cboTrinhDo.FormattingEnabled = true;
            cboTrinhDo.Location = new Point(479, 431);
            cboTrinhDo.Name = "cboTrinhDo";
            cboTrinhDo.Size = new Size(172, 31);
            cboTrinhDo.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(396, 439);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 18;
            label8.Text = "Trình độ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 499);
            label9.Name = "label9";
            label9.Size = new Size(98, 23);
            label9.TabIndex = 20;
            label9.Text = "Phòng ban:";
            // 
            // cboBoPhan
            // 
            cboBoPhan.FormattingEnabled = true;
            cboBoPhan.Location = new Point(479, 491);
            cboBoPhan.Name = "cboBoPhan";
            cboBoPhan.Size = new Size(172, 31);
            cboBoPhan.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(396, 499);
            label10.Name = "label10";
            label10.Size = new Size(78, 23);
            label10.TabIndex = 22;
            label10.Text = "Bộ phận:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(80, 555);
            label11.Name = "label11";
            label11.Size = new Size(74, 23);
            label11.TabIndex = 24;
            label11.Text = "Dân tộc:";
            // 
            // cboTonGiao
            // 
            cboTonGiao.FormattingEnabled = true;
            cboTonGiao.Location = new Point(479, 547);
            cboTonGiao.Name = "cboTonGiao";
            cboTonGiao.Size = new Size(172, 31);
            cboTonGiao.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(396, 555);
            label12.Name = "label12";
            label12.Size = new Size(79, 23);
            label12.TabIndex = 26;
            label12.Text = "Tôn giáo:";
            // 
            // cboDanToc
            // 
            cboDanToc.FormattingEnabled = true;
            cboDanToc.Location = new Point(184, 547);
            cboDanToc.Name = "cboDanToc";
            cboDanToc.Size = new Size(172, 31);
            cboDanToc.TabIndex = 30;
            // 
            // cboPhongBan
            // 
            cboPhongBan.FormattingEnabled = true;
            cboPhongBan.Location = new Point(184, 491);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(172, 31);
            cboPhongBan.TabIndex = 29;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(184, 431);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(172, 31);
            cboChucVu.TabIndex = 28;
            // 
            // btnHuyNhanVien
            // 
            btnHuyNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuyNhanVien.Location = new Point(741, 677);
            btnHuyNhanVien.Name = "btnHuyNhanVien";
            btnHuyNhanVien.Size = new Size(166, 49);
            btnHuyNhanVien.TabIndex = 31;
            btnHuyNhanVien.Text = "Hủy";
            btnHuyNhanVien.UseVisualStyleBackColor = true;
            btnHuyNhanVien.Click += btnHuyNhanVien_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(447, 46);
            label13.Name = "label13";
            label13.Size = new Size(216, 38);
            label13.TabIndex = 32;
            label13.Text = "Thêm nhân viên";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(549, 677);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(166, 49);
            btnReset.TabIndex = 33;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // FrThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 741);
            Controls.Add(btnReset);
            Controls.Add(label13);
            Controls.Add(btnHuyNhanVien);
            Controls.Add(cboDanToc);
            Controls.Add(cboPhongBan);
            Controls.Add(cboChucVu);
            Controls.Add(cboTonGiao);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(cboBoPhan);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cboTrinhDo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnAnh);
            Controls.Add(txtDiaChi);
            Controls.Add(label6);
            Controls.Add(txtDienThoai);
            Controls.Add(label5);
            Controls.Add(txtCCCD);
            Controls.Add(label4);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(label3);
            Controls.Add(dtpDate);
            Controls.Add(label2);
            Controls.Add(txtHoten);
            Controls.Add(btnThemNhanVien);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrThemNhanVien";
            Text = "Thêm Nhân Viên";
            Load += FrThemNhanVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnThemNhanVien;
        private TextBox txtHoten;
        private Label label2;
        private DateTimePicker dtpDate;
        private Label label3;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private TextBox txtCCCD;
        private Label label4;
        private TextBox txtDienThoai;
        private Label label5;
        private TextBox txtDiaChi;
        private Label label6;
        private Button btnAnh;
        private Label label7;
        private ComboBox cboTrinhDo;
        private Label label8;
        private Label label9;
        private ComboBox cboBoPhan;
        private Label label10;
        private Label label11;
        private ComboBox cboTonGiao;
        private Label label12;
        private ComboBox cboDanToc;
        private ComboBox cboPhongBan;
        private ComboBox cboChucVu;
        private Button btnHuyNhanVien;
        private Label label13;
        private Button btnReset;
    }
}