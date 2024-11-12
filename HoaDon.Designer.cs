namespace QuanLyNhaSach
{
    partial class HoaDon
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
            dgvhoadon = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtmahoadon = new TextBox();
            txtngaylap = new TextBox();
            txtmakhachhang = new TextBox();
            btnthem = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            label5 = new Label();
            txttimkiem = new TextBox();
            btntimkiem = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).BeginInit();
            SuspendLayout();
            // 
            // dgvhoadon
            // 
            dgvhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadon.Location = new Point(163, 78);
            dgvhoadon.Name = "dgvhoadon";
            dgvhoadon.RowHeadersWidth = 51;
            dgvhoadon.Size = new Size(456, 188);
            dgvhoadon.TabIndex = 0;
            dgvhoadon.CellClick += dgvhoadon_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 44);
            label1.Name = "label1";
            label1.Size = new Size(164, 31);
            label1.TabIndex = 1;
            label1.Text = "Bảng hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(85, 290);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã hóa đơn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(106, 325);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 3;
            label3.Text = "Ngày lập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(62, 363);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 4;
            label4.Text = "Mã khách hàng:";
            // 
            // txtmahoadon
            // 
            txtmahoadon.Location = new Point(187, 287);
            txtmahoadon.Name = "txtmahoadon";
            txtmahoadon.Size = new Size(155, 27);
            txtmahoadon.TabIndex = 5;
            // 
            // txtngaylap
            // 
            txtngaylap.Location = new Point(187, 325);
            txtngaylap.Name = "txtngaylap";
            txtngaylap.Size = new Size(155, 27);
            txtngaylap.TabIndex = 6;
            // 
            // txtmakhachhang
            // 
            txtmakhachhang.Location = new Point(187, 363);
            txtmakhachhang.Name = "txtmakhachhang";
            txtmakhachhang.Size = new Size(155, 27);
            txtmakhachhang.TabIndex = 7;
            // 
            // btnthem
            // 
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(220, 409);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 8;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnsua
            // 
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(440, 409);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 9;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnxoa.Location = new Point(640, 409);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 10;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(385, 300);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 11;
            label5.Text = "Tìm kiếm:";
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(459, 300);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.PlaceholderText = " Nhập mã hóa đơn cần tìm";
            txttimkiem.Size = new Size(190, 27);
            txttimkiem.TabIndex = 12;
            txttimkiem.TextChanged += textBox1_TextChanged;
            // 
            // btntimkiem
            // 
            btntimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btntimkiem.Location = new Point(555, 354);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 29);
            btntimkiem.TabIndex = 13;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(29, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btntimkiem);
            Controls.Add(txttimkiem);
            Controls.Add(label5);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txtmakhachhang);
            Controls.Add(txtngaylap);
            Controls.Add(txtmahoadon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvhoadon);
            Name = "HoaDon";
            Text = "HoaDon";
            Load += HoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvhoadon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtmahoadon;
        private TextBox txtngaylap;
        private TextBox txtmakhachhang;
        private Button btnthem;
        private Button btnsua;
        private Button btnxoa;
        private Label label5;
        private TextBox txttimkiem;
        private Button btntimkiem;
        private Button button1;
    }
}