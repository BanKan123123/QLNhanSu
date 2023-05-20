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
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboSearch = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvTangLuong = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTangLuong).BeginInit();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(939, 226);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(152, 45);
            btnXoa.TabIndex = 40;
            btnXoa.Text = "    Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.icons8_edit_30;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(939, 159);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(152, 45);
            btnSua.TabIndex = 39;
            btnSua.Text = "    Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(939, 92);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(152, 45);
            btnThem.TabIndex = 38;
            btnThem.Text = "    Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            cboSearch.Location = new Point(759, 37);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(151, 28);
            cboSearch.TabIndex = 43;
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
            Controls.Add(cboSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frTangLuong";
            Text = "frTangLuong";
            Load += frTangLuong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTangLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvTangLuong;
    }
}