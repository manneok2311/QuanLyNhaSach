namespace QuanLyNhaSach
{
    partial class Sach
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
            dgvsach = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtmasach = new TextBox();
            txttensach = new TextBox();
            txttacgia = new TextBox();
            txtgiaban = new TextBox();
            txtsoluong = new TextBox();
            txtmota = new TextBox();
            txtmaloaisach = new TextBox();
            btnthem = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            label9 = new Label();
            txttimkiem = new TextBox();
            btntimkiem = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvsach).BeginInit();
            SuspendLayout();
            // 
            // dgvsach
            // 
            dgvsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsach.Location = new Point(65, 61);
            dgvsach.Name = "dgvsach";
            dgvsach.RowHeadersWidth = 51;
            dgvsach.Size = new Size(782, 188);
            dgvsach.TabIndex = 0;
            dgvsach.CellClick += dgvsach_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 27);
            label1.Name = "label1";
            label1.Size = new Size(122, 31);
            label1.TabIndex = 1;
            label1.Text = "Bảng sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(78, 323);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(71, 359);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên sách:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(84, 398);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 4;
            label4.Text = "Tác giả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(79, 439);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 5;
            label5.Text = "Giá bán:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(492, 323);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 6;
            label6.Text = "Số lượng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(515, 359);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 7;
            label7.Text = "Mô tả:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(465, 398);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 8;
            label8.Text = "Mã loại sách:";
            // 
            // txtmasach
            // 
            txtmasach.Location = new Point(169, 324);
            txtmasach.Name = "txtmasach";
            txtmasach.Size = new Size(140, 27);
            txtmasach.TabIndex = 9;
            // 
            // txttensach
            // 
            txttensach.Location = new Point(166, 360);
            txttensach.Name = "txttensach";
            txttensach.Size = new Size(140, 27);
            txttensach.TabIndex = 10;
            // 
            // txttacgia
            // 
            txttacgia.Location = new Point(169, 395);
            txttacgia.Name = "txttacgia";
            txttacgia.Size = new Size(140, 27);
            txttacgia.TabIndex = 11;
            // 
            // txtgiaban
            // 
            txtgiaban.Location = new Point(169, 436);
            txtgiaban.Name = "txtgiaban";
            txtgiaban.Size = new Size(140, 27);
            txtgiaban.TabIndex = 12;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(584, 320);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(140, 27);
            txtsoluong.TabIndex = 13;
            // 
            // txtmota
            // 
            txtmota.Location = new Point(583, 359);
            txtmota.Name = "txtmota";
            txtmota.Size = new Size(140, 27);
            txtmota.TabIndex = 14;
            // 
            // txtmaloaisach
            // 
            txtmaloaisach.Location = new Point(583, 398);
            txtmaloaisach.Name = "txtmaloaisach";
            txtmaloaisach.Size = new Size(140, 27);
            txtmaloaisach.TabIndex = 15;
            // 
            // btnthem
            // 
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(240, 483);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(106, 29);
            btnthem.TabIndex = 16;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnsua
            // 
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(461, 483);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(106, 29);
            btnsua.TabIndex = 17;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnxoa.Location = new Point(687, 484);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(106, 29);
            btnxoa.TabIndex = 18;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(69, 278);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 19;
            label9.Text = "Tìm kiếm:";
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txttimkiem.Location = new Point(163, 275);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.PlaceholderText = "Nhập mã loại sách cần tìm kiếm";
            txttimkiem.Size = new Size(258, 27);
            txttimkiem.TabIndex = 20;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(436, 275);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(106, 29);
            btntimkiem.TabIndex = 21;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(65, 483);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Sach
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 524);
            Controls.Add(button1);
            Controls.Add(btntimkiem);
            Controls.Add(txttimkiem);
            Controls.Add(label9);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txtmaloaisach);
            Controls.Add(txtmota);
            Controls.Add(txtsoluong);
            Controls.Add(txtgiaban);
            Controls.Add(txttacgia);
            Controls.Add(txttensach);
            Controls.Add(txtmasach);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvsach);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Sach";
            Text = "Sach";
            Load += Sach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvsach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvsach;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtmasach;
        private TextBox txttensach;
        private TextBox txttacgia;
        private TextBox txtgiaban;
        private TextBox txtsoluong;
        private TextBox txtmota;
        private TextBox txtmaloaisach;
        private Button btnthem;
        private Button btnsua;
        private Button btnxoa;
        private Label label9;
        private TextBox txttimkiem;
        private Button btntimkiem;
        private Button button1;
    }
}