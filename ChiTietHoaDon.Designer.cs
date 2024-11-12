namespace QuanLyNhaSach
{
    partial class ChiTietHoaDon
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
            dgvcthoadon = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvcthoadon).BeginInit();
            SuspendLayout();
            // 
            // dgvcthoadon
            // 
            dgvcthoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcthoadon.Location = new Point(106, 126);
            dgvcthoadon.Name = "dgvcthoadon";
            dgvcthoadon.RowHeadersWidth = 51;
            dgvcthoadon.Size = new Size(515, 188);
            dgvcthoadon.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 92);
            label1.Name = "label1";
            label1.Size = new Size(245, 31);
            label1.TabIndex = 1;
            label1.Text = "Bảng chi tiết hóa đơn";
            // 
            // ChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvcthoadon);
            Name = "ChiTietHoaDon";
            Text = "ChiTietHoaDon";
            Load += ChiTietHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvcthoadon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvcthoadon;
        private Label label1;
    }
}