using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            else
                if (txtPass.Text != txtRePass.Text)
                MessageBox.Show("Hai mật khẩu không khớp!");
            else
            {
                string queryAddUser = @"INSERT INTO tbl_user(ID,Password,PhanQuyen) VALUES('" + txtID.Text + "','" + txtPass.Text + "','3')";
                Conn.executeQuery(queryAddUser);
                MessageBox.Show("Bạn đã đăng kí thành công!");
                this.Hide();
                Form DN = new frmDangNhap();
                DN.Show();

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
