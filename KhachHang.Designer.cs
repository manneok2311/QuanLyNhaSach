﻿namespace QuanLyNhaSach
{
    partial class KhachHang
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
            dgvkhachhang = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvkhachhang).BeginInit();
            SuspendLayout();
            // 
            // dgvkhachhang
            // 
            dgvkhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvkhachhang.Location = new Point(113, 97);
            dgvkhachhang.Name = "dgvkhachhang";
            dgvkhachhang.RowHeadersWidth = 51;
            dgvkhachhang.Size = new Size(605, 188);
            dgvkhachhang.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 63);
            label1.Name = "label1";
            label1.Size = new Size(199, 31);
            label1.TabIndex = 1;
            label1.Text = "Bảng khách hàng";
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvkhachhang);
            Name = "KhachHang";
            Text = "KhachHang";
            Load += KhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvkhachhang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvkhachhang;
        private Label label1;
    }
}