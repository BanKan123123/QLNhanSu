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
            lblTitle.Location = new Point(278, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(129, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm chức vụ";
            // 
            // ptbCancel
            // 
            ptbCancel.Image = Properties.Resources.icons8_cancel_30;
            ptbCancel.Location = new Point(663, 9);
            ptbCancel.Margin = new Padding(3, 2, 3, 2);
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
            label1.Location = new Point(196, 91);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Chức vụ:";
            label1.Click += label1_Click;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(257, 86);
            txtChucVu.Margin = new Padding(3, 2, 3, 2);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(238, 23);
            txtChucVu.TabIndex = 3;
            txtChucVu.TextChanged += txtChucVu_TextChanged;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(112, 166);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(145, 37);
            btnReset.TabIndex = 36;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnHuyNhanVien
            // 
            btnHuyNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuyNhanVien.Location = new Point(280, 166);
            btnHuyNhanVien.Margin = new Padding(3, 2, 3, 2);
            btnHuyNhanVien.Name = "btnHuyNhanVien";
            btnHuyNhanVien.Size = new Size(145, 37);
            btnHuyNhanVien.TabIndex = 35;
            btnHuyNhanVien.Text = "Hủy";
            btnHuyNhanVien.UseVisualStyleBackColor = true;
            btnHuyNhanVien.Click += btnHuyNhanVien_Click_1;
            // 
            // btnThemNhanVien
            // 
            btnThemNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemNhanVien.Location = new Point(449, 166);
            btnThemNhanVien.Margin = new Padding(3, 2, 3, 2);
            btnThemNhanVien.Name = "btnThemNhanVien";
            btnThemNhanVien.Size = new Size(145, 37);
            btnThemNhanVien.TabIndex = 34;
            btnThemNhanVien.Text = "Thêm";
            btnThemNhanVien.UseVisualStyleBackColor = true;
            btnThemNhanVien.Click += btnThemNhanVien_Click;
            // 
            // FeatureChucVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnReset);
            Controls.Add(btnHuyNhanVien);
            Controls.Add(btnThemNhanVien);
            Controls.Add(txtChucVu);
            Controls.Add(label1);
            Controls.Add(ptbCancel);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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