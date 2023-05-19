namespace QLNhanSu.Tabs.Employees.FormTangLuong
{
    partial class frTangLuong
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvTangLuong = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTangLuong).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Image = Properties.Resources.icons8_delete_30;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(939, 226);
            button3.Name = "button3";
            button3.Size = new Size(152, 45);
            button3.TabIndex = 40;
            button3.Text = "    Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.icons8_edit_30;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(939, 159);
            button2.Name = "button2";
            button2.Size = new Size(152, 45);
            button2.TabIndex = 39;
            button2.Text = "    Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_add_30;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(939, 92);
            button1.Name = "button1";
            button1.Size = new Size(152, 45);
            button1.TabIndex = 38;
            button1.Text = "    Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            comboBox1.Location = new Point(759, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 43;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(533, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 27);
            txtSearch.TabIndex = 42;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(443, 37);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(84, 25);
            lblSearch.TabIndex = 41;
            lblSearch.Text = "Tìm kiếm";
            // 
            // dgvTangLuong
            // 
            dgvTangLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTangLuong.Location = new Point(0, 92);
            dgvTangLuong.Name = "dgvTangLuong";
            dgvTangLuong.RowHeadersWidth = 51;
            dgvTangLuong.RowTemplate.Height = 29;
            dgvTangLuong.Size = new Size(910, 543);
            dgvTangLuong.TabIndex = 44;
            // 
            // frTangLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 635);
            Controls.Add(dgvTangLuong);
            Controls.Add(comboBox1);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frTangLuong";
            Text = "frTangLuong";
            Load += frTangLuong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTangLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvTangLuong;
    }
}