namespace QLNhanSu.Tabs.Home
{
    partial class frHome
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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(213, 209);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(651, 62);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome to Quản Lý Nhân Sự";
            // 
            // frHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 682);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frHome";
            Text = "Trang chủ";
            Load += frHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
    }
}