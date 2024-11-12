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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void HoaDon_Load(object sender, EventArgs e)
        {
            getData();
        }
        private void getData()
        {
            string query = "select * from HoaDon";
            DataSet ds = kn.LayDuLieu(query);
            dgvhoadon.DataSource = ds.Tables[0];
        }
        public void clearText()
        {

            txtmahoadon.Text = "";
            txtngaylap.Text = "";
            txtmakhachhang.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into HoaDon VALUES('{0}', '{1}', '{2}')",
                txtmahoadon.Text,
                txtngaylap.Text,
                txtmakhachhang.Text
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm mới thành công!");
                clearText();
                getData();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string query = string.Format(
               "update HoaDon set NgayLap = '{1}',MaKhachHang = '{2}' where MaHoaDon = '{0}'",
               txtmahoadon.Text,
               txtngaylap.Text,
               txtmakhachhang.Text
           );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công!");
                clearText();
                getData();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "delete from HoaDon where MaHoaDon = '{0}'",
                txtmahoadon.Text
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Xóa thành công!");
                clearText();
                getData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {

                txtmahoadon.Text = dgvhoadon.Rows[r].Cells["MaHoaDon"].Value.ToString();
                txtngaylap.Text = dgvhoadon.Rows[r].Cells["NgayLap"].Value.ToString();
                txtmakhachhang.Text = dgvhoadon.Rows[r].Cells["MaKhachHang"].Value.ToString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from HoaDon where MaHoaDon= '{0}'",
                txttimkiem.Text

            );
            DataSet ds = kn.LayDuLieu(query);
            dgvhoadon.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }
    }
}
