namespace QLNhanSu.Tabs.Employees
{
    partial class frTrinhDo
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
            cbSearch = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvTrinhdo = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTrinhdo).BeginInit();
            SuspendLayout();
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            cbSearch.Location = new Point(758, 37);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(151, 28);
            cbSearch.TabIndex = 11;
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(532, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 27);
            txtSearch.TabIndex = 10;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(442, 36);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(84, 25);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Tìm kiếm";
            // 
            // dgvTrinhdo
            // 
            dgvTrinhdo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrinhdo.Location = new Point(-1, 93);
            dgvTrinhdo.Name = "dgvTrinhdo";
            dgvTrinhdo.RowHeadersWidth = 51;
            dgvTrinhdo.RowTemplate.Height = 29;
            dgvTrinhdo.Size = new Size(910, 543);
            dgvTrinhdo.TabIndex = 8;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(952, 223);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(139, 45);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "    Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.icons8_edit_30;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(952, 160);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(139, 45);
            btnSua.TabIndex = 17;
            btnSua.Text = "    Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.icons8_add_30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(952, 93);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(139, 45);
            btnThem.TabIndex = 16;
            btnThem.Text = "    Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // frTrinhDo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 635);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cbSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvTrinhdo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frTrinhDo";
            Text = "Trình độ";
            ((System.ComponentModel.ISupportInitialize)dgvTrinhdo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvTrinhdo;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}