namespace QLNhanSu.Tabs.Other
{
    partial class frDantoc
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
            cboSeach = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvDanToc = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanToc).BeginInit();
            SuspendLayout();
            // 
            // cboSeach
            // 
            cboSeach.FormattingEnabled = true;
            cboSeach.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            cboSeach.Location = new Point(759, 36);
            cboSeach.Name = "cboSeach";
            cboSeach.Size = new Size(151, 28);
            cboSeach.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(533, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 27);
            txtSearch.TabIndex = 6;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(443, 36);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(84, 25);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Tìm kiếm";
            // 
            // dgvDanToc
            // 
            dgvDanToc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanToc.Location = new Point(0, 92);
            dgvDanToc.Name = "dgvDanToc";
            dgvDanToc.RowHeadersWidth = 51;
            dgvDanToc.RowTemplate.Height = 29;
            dgvDanToc.Size = new Size(910, 543);
            dgvDanToc.TabIndex = 4;
            dgvDanToc.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(952, 226);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(139, 45);
            btnXoa.TabIndex = 24;
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
            btnSua.TabIndex = 23;
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
            btnThem.TabIndex = 22;
            btnThem.Text = "    Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // frDantoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 635);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboSeach);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvDanToc);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frDantoc";
            Text = "Dân tộc";
            ((System.ComponentModel.ISupportInitialize)dgvDanToc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSeach;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvDanToc;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}