namespace QLNhanSu.Tabs.Employees
{
    partial class frDepart
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
            dgvPhongban = new DataGridView();
            comboBox1 = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhongban).BeginInit();
            SuspendLayout();
            // 
            // dgvPhongban
            // 
            dgvPhongban.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhongban.Location = new Point(0, 93);
            dgvPhongban.Name = "dgvPhongban";
            dgvPhongban.RowHeadersWidth = 51;
            dgvPhongban.RowTemplate.Height = 29;
            dgvPhongban.Size = new Size(910, 543);
            dgvPhongban.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            comboBox1.Location = new Point(759, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(533, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 27);
            txtSearch.TabIndex = 8;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(443, 36);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(84, 25);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Tìm kiếm";
            // 
            // button3
            // 
            button3.Image = Properties.Resources.icons8_delete_30;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(952, 227);
            button3.Name = "button3";
            button3.Size = new Size(139, 45);
            button3.TabIndex = 15;
            button3.Text = "    Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.icons8_edit_30;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(952, 160);
            button2.Name = "button2";
            button2.Size = new Size(139, 45);
            button2.TabIndex = 14;
            button2.Text = "    Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_add_30;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(952, 93);
            button1.Name = "button1";
            button1.Size = new Size(139, 45);
            button1.TabIndex = 13;
            button1.Text = "    Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // frDepart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 635);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvPhongban);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frDepart";
            Text = "Phòng ban";
            Load += frDepart_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhongban).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPhongban;
        private ComboBox comboBox1;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}