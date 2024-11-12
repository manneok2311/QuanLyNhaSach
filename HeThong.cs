using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sach frm = new Sach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LoaiSach frm = new LoaiSach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            KhachHang frm = new KhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            HoaDon frm = new HoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon frm = new ChiTietHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
