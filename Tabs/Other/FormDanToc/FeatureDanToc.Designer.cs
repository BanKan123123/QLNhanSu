namespace QLNhanSu.Tabs.Other.FormDanToc
{
    partial class FeatureDanToc
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
            btnReset = new Button();
            btnHuyNhanVien = new Button();
            btnThemNhanVien = new Button();
            txtDantoc = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbCancel).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(242, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(127, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm dân tộc";
            // 
            // ptbCancel
            // 
            ptbCancel.Image = Properties.Resources.icons8_cancel_30;
            ptbCancel.Location = new Point(592, 9);
            ptbCancel.Margin = new Padding(3, 2, 3, 2);
            ptbCancel.Name = "ptbCancel";
            ptbCancel.Size = new Size(30, 30);
            ptbCancel.SizeMode = PictureBoxSizeMode.AutoSize;
            ptbCancel.TabIndex = 1;
            ptbCancel.TabStop = false;
            ptbCancel.Click += ptbCancel_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(73, 202);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(145, 37);
            btnReset.TabIndex = 41;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnHuyNhanVien
            // 
            btnHuyNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuyNhanVien.Location = new Point(241, 202);
            btnHuyNhanVien.Margin = new Padding(3, 2, 3, 2);
            btnHuyNhanVien.Name = "btnHuyNhanVien";
            btnHuyNhanVien.Size = new Size(145, 37);
            btnHuyNhanVien.TabIndex = 40;
            btnHuyNhanVien.Text = "Hủy";
            btnHuyNhanVien.UseVisualStyleBackColor = true;
            btnHuyNhanVien.Click += btnHuyNhanVien_Click;
            // 
            // btnThemNhanVien
            // 
            btnThemNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemNhanVien.Location = new Point(410, 202);
            btnThemNhanVien.Margin = new Padding(3, 2, 3, 2);
            btnThemNhanVien.Name = "btnThemNhanVien";
            btnThemNhanVien.Size = new Size(145, 37);
            btnThemNhanVien.TabIndex = 39;
            btnThemNhanVien.Text = "Thêm";
            btnThemNhanVien.UseVisualStyleBackColor = true;
            btnThemNhanVien.Click += btnThemNhanVien_Click;
            // 
            // txtDantoc
            // 
            txtDantoc.Location = new Point(218, 122);
            txtDantoc.Margin = new Padding(3, 2, 3, 2);
            txtDantoc.Name = "txtDantoc";
            txtDantoc.Size = new Size(238, 23);
            txtDantoc.TabIndex = 38;
            txtDantoc.TextChanged += txtChucVu_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 130);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 37;
            label1.Text = "Tên Dân Tộc :";
            label1.Click += label1_Click;
            // 
            // FeatureDanToc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 360);
            Controls.Add(btnReset);
            Controls.Add(btnHuyNhanVien);
            Controls.Add(btnThemNhanVien);
            Controls.Add(txtDantoc);
            Controls.Add(label1);
            Controls.Add(ptbCancel);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FeatureDanToc";
            Text = "FeatureDanToc";
            Load += FeatureDanToc_Load;
            ((System.ComponentModel.ISupportInitialize)ptbCancel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox ptbCancel;
        private Button btnReset;
        private Button btnHuyNhanVien;
        private Button btnThemNhanVien;
        private TextBox txtDantoc;
        private Label label1;
    }
}