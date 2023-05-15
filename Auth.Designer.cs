namespace QLNhanSu
{
    partial class Auth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            fileSystemWatcher1 = new FileSystemWatcher();
            lblUserName = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            panel1 = new Panel();
            btnRegis = new Button();
            panel2 = new Panel();
            lblLogin = new Label();
            pictureBox1 = new PictureBox();
            errorRequied = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorRequied).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            fileSystemWatcher1.Changed += fileSystemWatcher1_Changed;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(66, 86);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(82, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(162, 83);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(66, 146);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(162, 202);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegis);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblUserName);
            panel1.Location = new Point(547, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 305);
            panel1.TabIndex = 5;
            // 
            // btnRegis
            // 
            btnRegis.Location = new Point(312, 202);
            btnRegis.Name = "btnRegis";
            btnRegis.Size = new Size(94, 29);
            btnRegis.TabIndex = 5;
            btnRegis.Text = "Đăng ký";
            btnRegis.UseVisualStyleBackColor = true;
            btnRegis.Click += btnRegis_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblLogin);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 467);
            panel2.TabIndex = 6;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(126, 31);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(247, 60);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Đăng Nhập";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(20, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 335);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // errorRequied
            // 
            errorRequied.ContainerControl = this;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 587);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Auth";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorRequied).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUserName;
        private Label lblLogin;
        private Button btnRegis;
        private ErrorProvider errorRequied;
    }
}