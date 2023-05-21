namespace QLNhanSu.Tabs.Employees.FormDieuChuyen
{
    partial class FeatureDieuChuyen
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
            lblTitle = new Label();
            ptbCancel = new PictureBox();
            lblSoQD = new Label();
            txtSoQD = new TextBox();
            dtpNgayDieuChuyen = new DateTimePicker();
            lblNgayDieuChuyen = new Label();
            cboMaNV = new ComboBox();
            label4 = new Label();
            lblMapbCu = new Label();
            cboMaPBCu = new ComboBox();
            lblMapbMoi = new Label();
            cboMaPBMoi = new ComboBox();
            txtLyDo = new TextBox();
            lblLyDo = new Label();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            btnDieuChuyen = new Button();
            btnCancel = new Button();
            btnReset = new Button();
            lblMaCTYCu = new Label();
            cboMaCTYCu = new ComboBox();
            lblMaCTYMoi = new Label();
            cboMaCTYMoi = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ptbCancel).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(323, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 31);
            lblTitle.TabIndex = 0;
            // 
            // ptbCancel
            // 
            ptbCancel.Image = Properties.Resources.icons8_cancel_30;
            ptbCancel.Location = new Point(738, 12);
            ptbCancel.Name = "ptbCancel";
            ptbCancel.Size = new Size(30, 30);
            ptbCancel.SizeMode = PictureBoxSizeMode.AutoSize;
            ptbCancel.TabIndex = 1;
            ptbCancel.TabStop = false;
            ptbCancel.Click += ptbCancel_Click;
            // 
            // lblSoQD
            // 
            lblSoQD.AutoSize = true;
            lblSoQD.Location = new Point(93, 92);
            lblSoQD.Name = "lblSoQD";
            lblSoQD.Size = new Size(63, 23);
            lblSoQD.TabIndex = 2;
            lblSoQD.Text = "Số QĐ:";
            // 
            // txtSoQD
            // 
            txtSoQD.Location = new Point(253, 85);
            txtSoQD.Name = "txtSoQD";
            txtSoQD.Size = new Size(426, 30);
            txtSoQD.TabIndex = 3;
            // 
            // dtpNgayDieuChuyen
            // 
            dtpNgayDieuChuyen.Format = DateTimePickerFormat.Short;
            dtpNgayDieuChuyen.Location = new Point(253, 144);
            dtpNgayDieuChuyen.Name = "dtpNgayDieuChuyen";
            dtpNgayDieuChuyen.Size = new Size(160, 30);
            dtpNgayDieuChuyen.TabIndex = 4;
            // 
            // lblNgayDieuChuyen
            // 
            lblNgayDieuChuyen.AutoSize = true;
            lblNgayDieuChuyen.Location = new Point(93, 151);
            lblNgayDieuChuyen.Name = "lblNgayDieuChuyen";
            lblNgayDieuChuyen.Size = new Size(152, 23);
            lblNgayDieuChuyen.TabIndex = 5;
            lblNgayDieuChuyen.Text = "Ngày điều chuyển:";
            // 
            // cboMaNV
            // 
            cboMaNV.FormattingEnabled = true;
            cboMaNV.Location = new Point(528, 143);
            cboMaNV.Name = "cboMaNV";
            cboMaNV.Size = new Size(151, 31);
            cboMaNV.TabIndex = 6;
            cboMaNV.SelectedIndexChanged += cboMaNV_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 150);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 7;
            label4.Text = "Mã NV:";
            // 
            // lblMapbCu
            // 
            lblMapbCu.AutoSize = true;
            lblMapbCu.Location = new Point(93, 213);
            lblMapbCu.Name = "lblMapbCu";
            lblMapbCu.Size = new Size(86, 23);
            lblMapbCu.TabIndex = 9;
            lblMapbCu.Text = "Mã PB cũ:";
            // 
            // cboMaPBCu
            // 
            cboMaPBCu.FormattingEnabled = true;
            cboMaPBCu.Location = new Point(253, 205);
            cboMaPBCu.Name = "cboMaPBCu";
            cboMaPBCu.Size = new Size(151, 31);
            cboMaPBCu.TabIndex = 8;
            // 
            // lblMapbMoi
            // 
            lblMapbMoi.AutoSize = true;
            lblMapbMoi.Location = new Point(425, 212);
            lblMapbMoi.Name = "lblMapbMoi";
            lblMapbMoi.Size = new Size(97, 23);
            lblMapbMoi.TabIndex = 11;
            lblMapbMoi.Text = "Mã PB mới:";
            // 
            // cboMaPBMoi
            // 
            cboMaPBMoi.FormattingEnabled = true;
            cboMaPBMoi.Location = new Point(528, 204);
            cboMaPBMoi.Name = "cboMaPBMoi";
            cboMaPBMoi.Size = new Size(151, 31);
            cboMaPBMoi.TabIndex = 10;
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(253, 325);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(426, 30);
            txtLyDo.TabIndex = 13;
            // 
            // lblLyDo
            // 
            lblLyDo.AutoSize = true;
            lblLyDo.Location = new Point(93, 332);
            lblLyDo.Name = "lblLyDo";
            lblLyDo.Size = new Size(54, 23);
            lblLyDo.TabIndex = 12;
            lblLyDo.Text = "Lý do:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(253, 384);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(426, 30);
            txtGhiChu.TabIndex = 15;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(93, 391);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(73, 23);
            lblGhiChu.TabIndex = 14;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // btnDieuChuyen
            // 
            btnDieuChuyen.Location = new Point(634, 467);
            btnDieuChuyen.Name = "btnDieuChuyen";
            btnDieuChuyen.Size = new Size(134, 40);
            btnDieuChuyen.TabIndex = 16;
            btnDieuChuyen.Text = "Điều chuyển";
            btnDieuChuyen.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(475, 467);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 40);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(315, 467);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(134, 40);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // lblMaCTYCu
            // 
            lblMaCTYCu.AutoSize = true;
            lblMaCTYCu.Location = new Point(93, 274);
            lblMaCTYCu.Name = "lblMaCTYCu";
            lblMaCTYCu.Size = new Size(95, 23);
            lblMaCTYCu.TabIndex = 20;
            lblMaCTYCu.Text = "Mã CTY cũ:";
            // 
            // cboMaCTYCu
            // 
            cboMaCTYCu.FormattingEnabled = true;
            cboMaCTYCu.Location = new Point(253, 266);
            cboMaCTYCu.Name = "cboMaCTYCu";
            cboMaCTYCu.Size = new Size(151, 31);
            cboMaCTYCu.TabIndex = 19;
            // 
            // lblMaCTYMoi
            // 
            lblMaCTYMoi.AutoSize = true;
            lblMaCTYMoi.Location = new Point(416, 274);
            lblMaCTYMoi.Name = "lblMaCTYMoi";
            lblMaCTYMoi.Size = new Size(106, 23);
            lblMaCTYMoi.TabIndex = 22;
            lblMaCTYMoi.Text = "Mã CTY mới:";
            // 
            // cboMaCTYMoi
            // 
            cboMaCTYMoi.FormattingEnabled = true;
            cboMaCTYMoi.Location = new Point(528, 266);
            cboMaCTYMoi.Name = "cboMaCTYMoi";
            cboMaCTYMoi.Size = new Size(151, 31);
            cboMaCTYMoi.TabIndex = 21;
            cboMaCTYMoi.SelectedIndexChanged += cboMaCTYMoi_SelectedIndexChanged;
            // 
            // FeatureDieuChuyen
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 519);
            Controls.Add(lblMaCTYMoi);
            Controls.Add(cboMaCTYMoi);
            Controls.Add(lblMaCTYCu);
            Controls.Add(cboMaCTYCu);
            Controls.Add(btnReset);
            Controls.Add(btnCancel);
            Controls.Add(btnDieuChuyen);
            Controls.Add(txtGhiChu);
            Controls.Add(lblGhiChu);
            Controls.Add(txtLyDo);
            Controls.Add(lblLyDo);
            Controls.Add(lblMapbMoi);
            Controls.Add(cboMaPBMoi);
            Controls.Add(lblMapbCu);
            Controls.Add(cboMaPBCu);
            Controls.Add(label4);
            Controls.Add(cboMaNV);
            Controls.Add(lblNgayDieuChuyen);
            Controls.Add(dtpNgayDieuChuyen);
            Controls.Add(txtSoQD);
            Controls.Add(lblSoQD);
            Controls.Add(ptbCancel);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FeatureDieuChuyen";
            Text = "FeatureDieuChuyen";
            Load += FeatureDieuChuyen_Load;
            ((System.ComponentModel.ISupportInitialize)ptbCancel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox ptbCancel;
        private Label lblSoQD;
        private TextBox txtSoQD;
        private DateTimePicker dtpNgayDieuChuyen;
        private Label lblNgayDieuChuyen;
        private ComboBox cboMaNV;
        private Label label4;
        private Label lblMapbCu;
        private ComboBox cboMaPBCu;
        private Label lblMapbMoi;
        private ComboBox cboMaPBMoi;
        private TextBox txtLyDo;
        private Label lblLyDo;
        private TextBox txtGhiChu;
        private Label lblGhiChu;
        private Button btnDieuChuyen;
        private Button btnCancel;
        private Button btnReset;
        private Label lblMaCTYCu;
        private ComboBox cboMaCTYCu;
        private Label lblMaCTYMoi;
        private ComboBox cboMaCTYMoi;
    }
}