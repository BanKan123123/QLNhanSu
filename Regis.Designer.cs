namespace QLNhanSu
{
    partial class Register
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
            components = new System.ComponentModel.Container();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtRepassword = new TextBox();
            lblRepassword = new Label();
            btnRegister = new Button();
            errorConfirm = new ErrorProvider(components);
            errorRequied = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorConfirm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorRequied).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(292, 122);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(411, 119);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(233, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(411, 198);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(292, 201);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtRepassword
            // 
            txtRepassword.Location = new Point(411, 278);
            txtRepassword.Margin = new Padding(4);
            txtRepassword.Name = "txtRepassword";
            txtRepassword.Size = new Size(233, 31);
            txtRepassword.TabIndex = 5;
            txtRepassword.UseSystemPasswordChar = true;
            txtRepassword.Leave += txtRepassword_Leave;
            // 
            // lblRepassword
            // 
            lblRepassword.AutoSize = true;
            lblRepassword.Location = new Point(268, 281);
            lblRepassword.Margin = new Padding(4, 0, 4, 0);
            lblRepassword.Name = "lblRepassword";
            lblRepassword.Size = new Size(115, 25);
            lblRepassword.TabIndex = 4;
            lblRepassword.Text = "Re-password";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(434, 348);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(149, 40);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // errorConfirm
            // 
            errorConfirm.ContainerControl = this;
            // 
            // errorRequied
            // 
            errorRequied.ContainerControl = this;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnRegister);
            Controls.Add(txtRepassword);
            Controls.Add(lblRepassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Register";
            Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)errorConfirm).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorRequied).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtRepassword;
        private Label lblRepassword;
        private Button btnRegister;
        private ErrorProvider errorConfirm;
        private ErrorProvider errorRequied;
    }
}