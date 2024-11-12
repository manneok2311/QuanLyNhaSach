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
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void Sach_Load(object sender, EventArgs e)
        {
            getData();

        }
        private void getData()
        {
            string query = "select * from Sach";
            DataSet ds = kn.LayDuLieu(query);
            dgvsach.DataSource = ds.Tables[0];
        }

        public void clearText()
        {

            txtmasach.Text = "";
            txttensach.Text = "";
            txttacgia.Text = "";
            txtgiaban.Text = "";
            txtsoluong.Text = "";
            txtmota.Text = "";
            txtmaloaisach.Text = "";

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into Sach VALUES('{0}', N'{1}', N'{2}', {3}, {4}, N'{5}', {6})",
                txtmasach.Text,
                txttensach.Text,
                txttacgia.Text,
                txtgiaban.Text,
                txtsoluong.Text,
                txtmota.Text,
                txtmaloaisach.Text
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
                "update Sach set TenSach = N'{1}',TacGia = N'{2}', GiaBan = {3}, SoLuong = {4}, MoTa = N'{5}', MaLoaiSach = '{6}' where MaSach = '{0}'",
                txtmasach.Text,
                txttensach.Text,
                txttacgia.Text,
                txtgiaban.Text,
                txtsoluong.Text,
                txtmota.Text,
                txtmaloaisach.Text
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
                "delete from Sach where MaSach = '{0}'",
                txtmasach.Text
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

        private void dgvsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {

                txtmasach.Text = dgvsach.Rows[r].Cells["MaSach"].Value.ToString();
                txttensach.Text = dgvsach.Rows[r].Cells["TenSach"].Value.ToString();
                txttacgia.Text = dgvsach.Rows[r].Cells["TacGia"].Value.ToString();
                txtgiaban.Text = dgvsach.Rows[r].Cells["GiaBan"].Value.ToString();
                txtsoluong.Text = dgvsach.Rows[r].Cells["SoLuong"].Value.ToString();
                txtmota.Text = dgvsach.Rows[r].Cells["MoTa"].Value.ToString();
                txtmaloaisach.Text = dgvsach.Rows[r].Cells["MaLoaiSach"].Value.ToString();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from Sach where MaLoaiSach= '{0}'",
                txttimkiem.Text

            );
            DataSet ds = kn.LayDuLieu(query);
            dgvsach.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }
    }
}
