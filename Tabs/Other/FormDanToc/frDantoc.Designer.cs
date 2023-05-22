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
            cboSeach.Location = new Point(664, 27);
            cboSeach.Margin = new Padding(3, 2, 3, 2);
            cboSeach.Name = "cboSeach";
            cboSeach.Size = new Size(133, 23);
            cboSeach.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(466, 27);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 23);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(388, 27);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 20);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Tìm kiếm";
            // 
            // dgvDanToc
            // 
            dgvDanToc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanToc.Location = new Point(0, 69);
            dgvDanToc.Margin = new Padding(3, 2, 3, 2);
            dgvDanToc.Name = "dgvDanToc";
            dgvDanToc.RowHeadersWidth = 51;
            dgvDanToc.RowTemplate.Height = 29;
            dgvDanToc.Size = new Size(796, 407);
            dgvDanToc.TabIndex = 4;
            dgvDanToc.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(833, 170);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(122, 34);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "    Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.icons8_edit_30;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(833, 119);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(122, 34);
            btnSua.TabIndex = 23;
            btnSua.Text = "    Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(833, 69);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(122, 34);
            btnThem.TabIndex = 22;
            btnThem.Text = "    Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frDantoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 476);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboSeach);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvDanToc);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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