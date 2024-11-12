namespace QuanLyNhaSach
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ten = txtUser.Text;
            string pass = txtPass.Text;
            if (ten == "admin" && pass == "1234")
            {
                MessageBox.Show("Đăng nhập thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HeThong frm = new HeThong();
                frm.ShowDialog();   
                return;
            }
            MessageBox.Show("Đăng nhập không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
