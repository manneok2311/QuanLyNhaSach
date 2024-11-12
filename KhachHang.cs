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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void KhachHang_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            string query = "select * from KhachHang";
            DataSet ds = kn.LayDuLieu(query);
            dgvkhachhang.DataSource = ds.Tables[0];
        }
    }
}
