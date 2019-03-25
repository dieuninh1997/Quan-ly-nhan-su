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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtTimKiem.Text = "Nhân viên nào có lương cao nhất?";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtTimKiem.Text = "Nhân viên nào có lương thấp nhất?";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (radMaNV.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE MaNV='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTenNV.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE TenNV LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiSinh.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE NoiSinh LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radDiaChi.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE DiaChi LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radChuyenMon.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE ChuyenMon LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTDHV.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE TDHV LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radDanToc.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE DanToc LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radTonGiao.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE TonGiao LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radQuocTich.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE QuocTich LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radLuongCB.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_luong WHERE LuongCoBan='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radDonVi.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE MaDonVi='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiCapBHXH.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_baohiemxh WHERE NoiCap LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNoiDKKCB.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_baohiemxh WHERE NoiDKKCB LIKE N'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radGioiTinh.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE GioiTinh=N'" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radSDT.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE SDT LIKE'%" + txtTimKiem.Text + "%'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radEmail.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE Email='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgaySinh.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_nhanvien WHERE NgaySinh='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_nhanvien");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgayNhapLuong.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_luong WHERE NgayNhap='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_luong");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgaySuaLuong.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_luong WHERE NgaySua='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_luong");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (radNgayCapBHXH.Checked == true)
                {
                    string Search = "SELECT * FROM tbl_baohiemxh WHERE NgayCap='" + txtTimKiem.Text + "'";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_baohiemxh");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (txtTimKiem.Text == "Nhân viên nào có lương cao nhất?" || txtTimKiem.Text == "nhân viên nào có lương cao nhất?" || txtTimKiem.Text == "lương cao nhất?")
                {
                    string Search = "SELECT * FROM tbl_luong  where LuongCoBan = (select max(LuongCoBan) from tbl_luong )";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_luong");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //
                if (txtTimKiem.Text == "Nhân viên nào có lương thấp nhất?" || txtTimKiem.Text == "nhân viên nào có lương thấp nhất?" || txtTimKiem.Text == "lương thấp nhất?")
                {
                    string Search = "SELECT * FROM tbl_luong  where LuongCoBan = (select min(LuongCoBan) from tbl_luong )";
                    System.Data.DataTable dt = KiemTraKetNoi.getDatatable(Search, "tbl_luong");
                    dataTimKiem.DataSource = dt;
                    int count = dataTimKiem.Rows.Count - 1;
                    txtKQTimKiem.Text = count.ToString();
                }
                //

            }
            catch (Exception)
            { }
        }
    }
}
