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
    public partial class LoaiSach : Form
    {
        public LoaiSach()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void LoaiSach_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            string query = "select * from LoaiSach";
            DataSet ds = kn.LayDuLieu(query);
            dgvLoaiSach.DataSource = ds.Tables[0];
        }
    }
}
