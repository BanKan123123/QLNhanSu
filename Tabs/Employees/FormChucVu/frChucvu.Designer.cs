namespace QLNhanSu.Tabs.Employees
{
    partial class frPosition
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
            dgvChucvu = new DataGridView();
            comboBox1 = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChucvu).BeginInit();
            SuspendLayout();
            // 
            // dgvChucvu
            // 
            dgvChucvu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChucvu.Location = new Point(0, 92);
            dgvChucvu.Name = "dgvChucvu";
            dgvChucvu.RowHeadersWidth = 51;
            dgvChucvu.RowTemplate.Height = 29;
            dgvChucvu.Size = new Size(910, 543);
            dgvChucvu.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            comboBox1.Location = new Point(759, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(533, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 27);
            txtSearch.TabIndex = 5;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(443, 36);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(84, 25);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Tìm kiếm";
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(952, 92);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(139, 45);
            btnThem.TabIndex = 7;
            btnThem.Text = "    Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.icons8_edit_30;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(952, 159);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(139, 45);
            btnSua.TabIndex = 8;
            btnSua.Text = "    Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(952, 226);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(139, 45);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "    Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // frPosition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 635);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(comboBox1);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvChucvu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frPosition";
            Text = "Chức vụ";
            Load += frPosition_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChucvu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvChucvu;
        private ComboBox comboBox1;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}