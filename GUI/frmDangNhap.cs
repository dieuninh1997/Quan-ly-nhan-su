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
    public partial class frmDangNhap : Form
    {
        const int SIGNIN_HEIGHT = 270;
        const int SIGNIN_SIGNUP_HEIGHT = 502;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtID.Text=="" || txtPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập và mật khẩu!", "Thông báo");
                return;
            }
            string query = "select * from tbl_user where ID = '"+txtID.Text+"' and Password = '"+txtPass.Text+"'";
            DataTable dt = KiemTraKetNoi.getDatatable(query, "tbl_user");
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Xin chào " + txtID.Text + "! Bạn đã đăng nhập thành công!", "Thông báo");
                this.Hide();
                Form main = new Form1(txtID.Text, txtPass.Text);
                main.Show();
            }else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                txtID.Clear();
                txtPass.Clear();
                txtID.Focus();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Height = SIGNIN_HEIGHT;
            txtID.Focus();
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Height = SIGNIN_SIGNUP_HEIGHT;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoanDK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if (txtMatKhauDK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            else
                if (txtMatKhauDK.Text != txtReMatKhauDK.Text)
                MessageBox.Show("Hai mật khẩu không khớp!");
            else
            {
                string queryAddUser = @"INSERT INTO tblUser(ID,Password,PhanQuyen) VALUES('" + txtTaiKhoanDK.Text + "','" + txtMatKhauDK.Text + "','3')";
                Conn.executeQuery(queryAddUser);
                MessageBox.Show("Bạn đã đăng kí thành công!");
                this.Height = SIGNIN_HEIGHT;

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Height = SIGNIN_HEIGHT;
            txtID.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
