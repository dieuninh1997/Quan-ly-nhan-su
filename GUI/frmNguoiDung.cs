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
    public partial class frmNguoiDung : Form
    {
        string username, password;
        public frmNguoiDung(string user, string pass)
        {
            InitializeComponent();
            username = user;
            password = pass;
        }

        private void dataNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Load_data()
        {
            string str = "select * from tbl_user";
            System.Data.DataTable dt = KiemTraKetNoi.getDatatable(str, "tbl_user");
            dataNguoiDung.DataSource = dt;
        }
        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Load_data();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string update = "update tbl_user set Password='" + txtMatKhau.Text + "' where(ID=N'" + txtTaiKhoan.Text + "')";
            Conn.executeQuery(update);
            Load_data();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string phanQuyen = "";
            switch (cboxPhanQuyen.Text)
            {
                case "Quản Trị":
                    phanQuyen = "1";
                    break;
                case "VIP":
                    phanQuyen = "2";
                    break;
                case "Thành Viên":
                    phanQuyen = "3";
                    break;
            }
           
            string update = "update tbl_user set PhanQuyen=N'" + phanQuyen + "' where(ID=N'" + txtTaiKhoan.Text + "')";
            Conn.executeQuery(update);
            Load_data();

        }
    }
}
