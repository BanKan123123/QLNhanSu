using DevExpress.XtraEditors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLNhanSu.Tabs.Salary
{
    partial class frChamCong
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

        // Tạo một đối tượng TextEdit Control

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
            dgvChamCong = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            cboSearch.Location = new Point(759, 36);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(151, 28);
            cboSearch.TabIndex = 7;
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
            // dgvChamCong
            // 
            dgvChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamCong.Location = new Point(0, 93);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.RowHeadersWidth = 51;
            dgvChamCong.RowTemplate.Height = 29;
            dgvChamCong.Size = new Size(910, 254);
            dgvChamCong.TabIndex = 4;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.icons8_delete_30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(952, 227);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(139, 45);
            btnXoa.TabIndex = 33;
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
            btnSua.TabIndex = 32;
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
            btnThem.TabIndex = 31;
            btnThem.Text = "    Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // frChamCong
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
            Controls.Add(dgvChamCong);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frChamCong";
            Text = "Chấm công";
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvChamCong;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}