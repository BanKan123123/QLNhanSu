namespace QLNhanSu.Tabs.Salary
{
    partial class frUngLuong
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
            cboSearch = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvUngLuong = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUngLuong).BeginInit();
            SuspendLayout();
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            cboSearch.Location = new Point(759, 36);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(151, 28);
            cboSearch.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(533, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 27);
            txtSearch.TabIndex = 10;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(443, 36);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(84, 25);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Tìm kiếm";
            // 
            // dgvUngLuong
            // 
            dgvUngLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUngLuong.Location = new Point(0, 92);
            dgvUngLuong.Name = "dgvUngLuong";
            dgvUngLuong.RowHeadersWidth = 51;
            dgvUngLuong.RowTemplate.Height = 29;
            dgvUngLuong.Size = new Size(910, 543);
            dgvUngLuong.TabIndex = 8;
            dgvUngLuong.CellContentClick += dgvUngLuong_CellContentClick;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(952, 226);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(139, 45);
            btnXoa.TabIndex = 42;
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
            btnSua.TabIndex = 41;
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
            btnThem.TabIndex = 40;
            btnThem.Text = "    Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // frUngLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 635);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvUngLuong);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frUngLuong";
            Text = "Ứng lương";
            ((System.ComponentModel.ISupportInitialize)dgvUngLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvUngLuong;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}