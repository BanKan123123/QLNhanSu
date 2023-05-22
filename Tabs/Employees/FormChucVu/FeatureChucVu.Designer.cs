namespace QLNhanSu.Tabs.Employees.FormChucVu.FeatureChucVu
{
    partial class FeatureChucVu
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
            label1 = new Label();
            txtChucVu = new TextBox();
            btnReset = new Button();
            btnHuyNhanVien = new Button();
            btnThemNhanVien = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbCancel).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(318, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(156, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm chức vụ";
            // 
            // ptbCancel
            // 
            ptbCancel.Image = Properties.Resources.icons8_cancel_30;
            ptbCancel.Location = new Point(758, 12);
            ptbCancel.Name = "ptbCancel";
            ptbCancel.Size = new Size(30, 30);
            ptbCancel.SizeMode = PictureBoxSizeMode.AutoSize;
            ptbCancel.TabIndex = 1;
            ptbCancel.TabStop = false;
            ptbCancel.Click += ptbCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 121);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Chức vụ:";
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(294, 114);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(271, 27);
            txtChucVu.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(237, 389);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(166, 49);
            btnReset.TabIndex = 36;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnHuyNhanVien
            // 
            btnHuyNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuyNhanVien.Location = new Point(429, 389);
            btnHuyNhanVien.Name = "btnHuyNhanVien";
            btnHuyNhanVien.Size = new Size(166, 49);
            btnHuyNhanVien.TabIndex = 35;
            btnHuyNhanVien.Text = "Hủy";
            btnHuyNhanVien.UseVisualStyleBackColor = true;
            btnHuyNhanVien.Click += btnHuyNhanVien_Click_1;
            // 
            // btnThemNhanVien
            // 
            btnThemNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemNhanVien.Location = new Point(622, 389);
            btnThemNhanVien.Name = "btnThemNhanVien";
            btnThemNhanVien.Size = new Size(166, 49);
            btnThemNhanVien.TabIndex = 34;
            btnThemNhanVien.Text = "Thêm";
            btnThemNhanVien.UseVisualStyleBackColor = true;
            btnThemNhanVien.Click += btnThemNhanVien_Click;
            // 
            // FeatureChucVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnHuyNhanVien);
            Controls.Add(btnThemNhanVien);
            Controls.Add(txtChucVu);
            Controls.Add(label1);
            Controls.Add(ptbCancel);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FeatureChucVu";
            Text = "FrAdd";
            ((System.ComponentModel.ISupportInitialize)ptbCancel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox ptbCancel;
        private Label label1;
        private TextBox txtChucVu;
        private Button btnReset;
        private Button btnHuyNhanVien;
        private Button btnThemNhanVien;
    }
}