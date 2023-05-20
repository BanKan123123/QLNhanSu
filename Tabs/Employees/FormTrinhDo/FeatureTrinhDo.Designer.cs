namespace QLNhanSu.Tabs.Employees.FormTrinhDo
{
    partial class FeatureTrinhDo
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
            ((System.ComponentModel.ISupportInitialize)ptbCancel).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(329, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(158, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm trình độ";
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
            // FeatureTrinhDo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ptbCancel);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FeatureTrinhDo";
            Text = "FeatureTrinhDo";
            ((System.ComponentModel.ISupportInitialize)ptbCancel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox ptbCancel;
    }
}