namespace QLNhanSu.Tabs.Employees
{
    partial class frEmploy
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
            dgvNhanvien = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            cboGioiTinh = new ComboBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanvien).BeginInit();
            SuspendLayout();
            // 
            // dgvNhanvien
            // 
            dgvNhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanvien.Location = new Point(1, 92);
            dgvNhanvien.Name = "dgvNhanvien";
            dgvNhanvien.RowHeadersWidth = 51;
            dgvNhanvien.RowTemplate.Height = 29;
            dgvNhanvien.Size = new Size(910, 543);
            dgvNhanvien.TabIndex = 0;
            dgvNhanvien.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(444, 36);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(84, 25);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Tìm kiếm";
            lblSearch.Click += lblSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(534, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(760, 36);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(151, 28);
            cboGioiTinh.TabIndex = 3;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(952, 226);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(139, 45);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "    Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.icons8_edit_30;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(952, 159);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(139, 45);
            btnSua.TabIndex = 11;
            btnSua.Text = "    Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(952, 92);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(139, 45);
            btnThem.TabIndex = 10;
            btnThem.Text = "    Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frEmploy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 635);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboGioiTinh);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvNhanvien);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frEmploy";
            Text = "s";
            Load += frEmploy_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNhanvien;
        private Label lblSearch;
        private TextBox txtSearch;
        private ComboBox cboGioiTinh;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}