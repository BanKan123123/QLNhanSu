namespace QLNhanSu.Tabs.Home
{
    partial class frChPassword
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
            lblOldPassword = new Label();
            txtOldPassword = new TextBox();
            lblTitle = new Label();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtRePassword = new TextBox();
            lblRepassword = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOldPassword.Location = new Point(162, 114);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(119, 28);
            lblOldPassword.TabIndex = 0;
            lblOldPassword.Text = "Mật khẩu cũ";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOldPassword.Location = new Point(347, 111);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(257, 34);
            txtOldPassword.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Image = Properties.Resources.icons8_back_arrow_32__1_;
            lblTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitle.Location = new Point(64, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(273, 31);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "      Đổi mật khẩu của bạn";
            lblTitle.Click += lblTitle_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(347, 179);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(257, 34);
            txtNewPassword.TabIndex = 4;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewPassword.Location = new Point(162, 182);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(133, 28);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "Mật khẩu mới";
            // 
            // txtRePassword
            // 
            txtRePassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRePassword.Location = new Point(347, 244);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(257, 34);
            txtRePassword.TabIndex = 6;
            // 
            // lblRepassword
            // 
            lblRepassword.AutoSize = true;
            lblRepassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRepassword.Location = new Point(162, 250);
            lblRepassword.Name = "lblRepassword";
            lblRepassword.Size = new Size(171, 28);
            lblRepassword.TabIndex = 5;
            lblRepassword.Text = "Nhập lại mật khẩu";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(428, 384);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 42);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu thay đổi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(627, 384);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 42);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frChPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtRePassword);
            Controls.Add(lblRepassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblTitle);
            Controls.Add(txtOldPassword);
            Controls.Add(lblOldPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frChPassword";
            Text = "Thay đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOldPassword;
        private TextBox txtOldPassword;
        private Label lblTitle;
        private TextBox txtNewPassword;
        private Label lblNewPassword;
        private TextBox txtRePassword;
        private Label lblRepassword;
        private Button btnSave;
        private Button btnCancel;
    }
}