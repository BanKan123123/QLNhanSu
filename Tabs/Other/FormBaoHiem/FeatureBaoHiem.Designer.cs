namespace QLNhanSu.Tabs.Other.FormBaoHiem
{
    partial class FeatureBaoHiem
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
            txtSoBaoHiem = new TextBox();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            txtNoiCap = new TextBox();
            label3 = new Label();
            txtNoiKham = new TextBox();
            label4 = new Label();
            cboMasv = new ComboBox();
            label5 = new Label();
            lblTitleBaoHiem = new Label();
            btnThemBaoHiem = new Button();
            btnCancel = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(184, 100);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 0;
            label1.Text = "Số bảo hiểm:";
            // 
            // txtSoBaoHiem
            // 
            txtSoBaoHiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoBaoHiem.Location = new Point(340, 94);
            txtSoBaoHiem.Name = "txtSoBaoHiem";
            txtSoBaoHiem.Size = new Size(321, 34);
            txtSoBaoHiem.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(184, 160);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 2;
            label2.Text = "Ngày cấp:";
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(340, 160);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(151, 34);
            dtpDate.TabIndex = 3;
            // 
            // txtNoiCap
            // 
            txtNoiCap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoiCap.Location = new Point(340, 219);
            txtNoiCap.Name = "txtNoiCap";
            txtNoiCap.Size = new Size(321, 34);
            txtNoiCap.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(184, 225);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 4;
            label3.Text = "Nơi cấp:";
            // 
            // txtNoiKham
            // 
            txtNoiKham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoiKham.Location = new Point(340, 284);
            txtNoiKham.Name = "txtNoiKham";
            txtNoiKham.Size = new Size(321, 34);
            txtNoiKham.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(184, 290);
            label4.Name = "label4";
            label4.Size = new Size(150, 28);
            label4.TabIndex = 6;
            label4.Text = "Nơi khám bệnh:";
            // 
            // cboMasv
            // 
            cboMasv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboMasv.FormattingEnabled = true;
            cboMasv.Location = new Point(340, 348);
            cboMasv.Name = "cboMasv";
            cboMasv.Size = new Size(321, 36);
            cboMasv.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(184, 356);
            label5.Name = "label5";
            label5.Size = new Size(70, 28);
            label5.TabIndex = 9;
            label5.Text = "MANV";
            // 
            // lblTitleBaoHiem
            // 
            lblTitleBaoHiem.AutoSize = true;
            lblTitleBaoHiem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleBaoHiem.Location = new Point(371, 20);
            lblTitleBaoHiem.Name = "lblTitleBaoHiem";
            lblTitleBaoHiem.Size = new Size(0, 38);
            lblTitleBaoHiem.TabIndex = 10;
            lblTitleBaoHiem.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnThemBaoHiem
            // 
            btnThemBaoHiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemBaoHiem.Location = new Point(719, 477);
            btnThemBaoHiem.Name = "btnThemBaoHiem";
            btnThemBaoHiem.Size = new Size(149, 35);
            btnThemBaoHiem.TabIndex = 11;
            btnThemBaoHiem.Text = "Thêm";
            btnThemBaoHiem.UseVisualStyleBackColor = true;
            btnThemBaoHiem.Click += btnThemBaoHiem_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(555, 477);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(149, 35);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button1_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(391, 477);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(149, 35);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // FeatureBaoHiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 524);
            Controls.Add(btnReset);
            Controls.Add(btnCancel);
            Controls.Add(btnThemBaoHiem);
            Controls.Add(lblTitleBaoHiem);
            Controls.Add(label5);
            Controls.Add(cboMasv);
            Controls.Add(txtNoiKham);
            Controls.Add(label4);
            Controls.Add(txtNoiCap);
            Controls.Add(label3);
            Controls.Add(dtpDate);
            Controls.Add(label2);
            Controls.Add(txtSoBaoHiem);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FeatureBaoHiem";
            Text = "FeatureBaoHiem";
            Load += FeatureBaoHiem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSoBaoHiem;
        private Label label2;
        private DateTimePicker dtpDate;
        private TextBox txtNoiCap;
        private Label label3;
        private TextBox txtNoiKham;
        private Label label4;
        private ComboBox cboMasv;
        private Label label5;
        private Label lblTitleBaoHiem;
        private Button btnThemBaoHiem;
        private Button btnCancel;
        private Button btnReset;
    }
}