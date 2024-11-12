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
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            string query = "select * from ChiTietHoaDon";
            DataSet ds = kn.LayDuLieu(query);
            dgvcthoadon.DataSource = ds.Tables[0];
        }
    }
}
