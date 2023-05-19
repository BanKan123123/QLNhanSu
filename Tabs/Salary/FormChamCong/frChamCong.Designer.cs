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
            comboBox1 = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvChamCong = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            comboBox1.Location = new Point(759, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
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
            // button3
            // 
            button3.Image = Properties.Resources.icons8_delete_30;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(952, 227);
            button3.Name = "button3";
            button3.Size = new Size(139, 45);
            button3.TabIndex = 33;
            button3.Text = "    Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.icons8_edit_30;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(952, 160);
            button2.Name = "button2";
            button2.Size = new Size(139, 45);
            button2.TabIndex = 32;
            button2.Text = "    Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_add_30;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(952, 93);
            button1.Name = "button1";
            button1.Size = new Size(139, 45);
            button1.TabIndex = 31;
            button1.Text = "    Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // frChamCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 635);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvChamCong);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frChamCong";
            Text = "Chấm công";
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            ResumeLayout(false);
            PerformLayout();

            // Tạo một đối tượng TextEdit Control
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvChamCong;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}