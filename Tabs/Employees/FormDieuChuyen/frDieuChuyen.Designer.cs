namespace QLNhanSu.Tabs.Employees.FormDieuChuyen
{
    partial class frDieuChuyen
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
            btnXoa = new Button();
            btnSua = new Button();
            btnDieuChuyen = new Button();
            dgvDieuChuyen = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDieuChuyen).BeginInit();
            SuspendLayout();
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            cboSearch.Location = new Point(759, 35);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(151, 28);
            cboSearch.TabIndex = 14;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(533, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 27);
            txtSearch.TabIndex = 13;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(443, 38);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(84, 25);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Tìm kiếm";
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
            // btnDieuChuyen
            // 
            btnDieuChuyen.Image = Properties.Resources.icons8_add_30;
            btnDieuChuyen.ImageAlign = ContentAlignment.MiddleLeft;
            btnDieuChuyen.Location = new Point(952, 92);
            btnDieuChuyen.Name = "btnDieuChuyen";
            btnDieuChuyen.Size = new Size(139, 45);
            btnDieuChuyen.TabIndex = 22;
            btnDieuChuyen.Text = "      Điều chuyển";
            btnDieuChuyen.UseVisualStyleBackColor = true;
            btnDieuChuyen.Click += btnDieuChuyen_Click;
            // 
            // dgvDieuChuyen
            // 
            dgvDieuChuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDieuChuyen.Location = new Point(0, 92);
            dgvDieuChuyen.Name = "dgvDieuChuyen";
            dgvDieuChuyen.RowHeadersWidth = 51;
            dgvDieuChuyen.RowTemplate.Height = 29;
            dgvDieuChuyen.Size = new Size(910, 543);
            dgvDieuChuyen.TabIndex = 25;
            dgvDieuChuyen.CellContentClick += dgvDieuChuyen_CellContentClick;
            // 
            // frDieuChuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 635);
            Controls.Add(dgvDieuChuyen);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnDieuChuyen);
            Controls.Add(cboSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frDieuChuyen";
            Text = "frDieuChuyen";
            Load += frDieuChuyen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDieuChuyen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnXoa;
        private Button btnSua;
        private Button btnDieuChuyen;
        private DataGridView dgvDieuChuyen;
    }
}