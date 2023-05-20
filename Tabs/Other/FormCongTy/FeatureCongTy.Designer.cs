namespace QLNhanSu.Tabs.Other.FormCongTy
{
    partial class FeatureCongTy
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
            lblTenCongTy = new Label();
            lblName = new Label();
            lblNgayThanhLap = new Label();
            lblNgay = new Label();
            ptbCancel = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbCancel).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(269, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(238, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Giới thiệu công ty";
            // 
            // lblTenCongTy
            // 
            lblTenCongTy.AutoSize = true;
            lblTenCongTy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenCongTy.Location = new Point(151, 131);
            lblTenCongTy.Name = "lblTenCongTy";
            lblTenCongTy.Size = new Size(136, 31);
            lblTenCongTy.TabIndex = 1;
            lblTenCongTy.Text = "Tên công ty:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(307, 131);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 28);
            lblName.TabIndex = 2;
            lblName.Text = "label1";
            // 
            // lblNgayThanhLap
            // 
            lblNgayThanhLap.AutoSize = true;
            lblNgayThanhLap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgayThanhLap.Location = new Point(151, 187);
            lblNgayThanhLap.Name = "lblNgayThanhLap";
            lblNgayThanhLap.Size = new Size(180, 31);
            lblNgayThanhLap.TabIndex = 3;
            lblNgayThanhLap.Text = "Ngày Thành lập:";
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgay.Location = new Point(346, 189);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(65, 28);
            lblNgay.TabIndex = 4;
            lblNgay.Text = "label1";
            // 
            // ptbCancel
            // 
            ptbCancel.Image = Properties.Resources.icons8_cancel_30;
            ptbCancel.Location = new Point(736, 12);
            ptbCancel.Name = "ptbCancel";
            ptbCancel.Size = new Size(30, 30);
            ptbCancel.SizeMode = PictureBoxSizeMode.AutoSize;
            ptbCancel.TabIndex = 5;
            ptbCancel.TabStop = false;
            ptbCancel.Click += ptbCancel_Click;
            // 
            // FeatureCongTy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 511);
            Controls.Add(ptbCancel);
            Controls.Add(lblNgay);
            Controls.Add(lblNgayThanhLap);
            Controls.Add(lblName);
            Controls.Add(lblTenCongTy);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FeatureCongTy";
            Text = "FeatureCongTy";
            ((System.ComponentModel.ISupportInitialize)ptbCancel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTenCongTy;
        private Label lblName;
        private Label lblNgayThanhLap;
        private Label lblNgay;
        private PictureBox ptbCancel;
    }
}