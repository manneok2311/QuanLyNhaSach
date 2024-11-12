namespace QuanLyNhaSach
{
    partial class LoaiSach
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
            dgvLoaiSach = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSach).BeginInit();
            SuspendLayout();
            // 
            // dgvLoaiSach
            // 
            dgvLoaiSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiSach.Location = new Point(129, 96);
            dgvLoaiSach.Name = "dgvLoaiSach";
            dgvLoaiSach.RowHeadersWidth = 51;
            dgvLoaiSach.Size = new Size(515, 188);
            dgvLoaiSach.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 62);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 1;
            label1.Text = "Bảng loại sách";
            // 
            // LoaiSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvLoaiSach);
            Name = "LoaiSach";
            Text = "LoaiSach";
            Load += LoaiSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLoaiSach;
        private Label label1;
    }
}