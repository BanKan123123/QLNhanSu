namespace QLNhanSu.Tabs.Other
{
    partial class frBaoHiem
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
            dgvBaohiem = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBaohiem).BeginInit();
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
            // dgvBaohiem
            // 
            dgvBaohiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaohiem.Location = new Point(0, 93);
            dgvBaohiem.Name = "dgvBaohiem";
            dgvBaohiem.RowHeadersWidth = 51;
            dgvBaohiem.RowTemplate.Height = 29;
            dgvBaohiem.Size = new Size(910, 543);
            dgvBaohiem.TabIndex = 8;
            dgvBaohiem.CellContentClick += dgvBaohiem_CellContentClick;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(952, 227);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(139, 45);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "    Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.icons8_edit_30;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(952, 160);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(139, 45);
            btnSua.TabIndex = 20;
            btnSua.Text = "    Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(952, 93);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(139, 45);
            btnThem.TabIndex = 19;
            btnThem.Text = "    Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frBaoHiem
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
            Controls.Add(dgvBaohiem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frBaoHiem";
            Text = "frBaoHiem";
            Load += frBaoHiem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBaohiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvBaohiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}