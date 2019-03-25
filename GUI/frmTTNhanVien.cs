using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace GUI
{
    public partial class frmTTNhanVien : Form
    {
        string username;
        public frmTTNhanVien()
        {
            InitializeComponent();
        }
        public frmTTNhanVien(string user)
        {
            InitializeComponent();
            username = user;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Load_data()
        {
            string query = "select * from tbl_nhanvien";
            DataTable dt = KiemTraKetNoi.getDatatable(query, "tbl_nhanvien");
            dataNhanVien.DataSource = dt;
        }
        private void frmTTNhanVien_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Load_data();
            btnThem.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Không thể thêm nhân viên!", "Lỗi");
            }
            else
            {
                try
                {
                    string gioiTinh = radNam.Checked ? "Nam" : "Nu";
                    string queryAddNhanVien = @"INSERT INTO tbl_nhanvien (MaNV, TenNV,  GioiTinh, NgaySinh, NoiSinh, CMND, DiaChi, SDT,Email, TDHV,  MaDanToc, MaTonGiao, QuocTich, ChuyenMon, MaDonVi, MaThue, MaLuong, MaBHXH , GhiChu) VALUES ("
                        + "'" + txtMaNV.Text + "'," 
                        + "N'" + txtHoTen.Text + "',"
                        + "N'" + gioiTinh + "',"
                        + "'" + dateNgaySinh.Text + "',"
                        + "N'" + txtNoiSinh.Text + "',"
                        + "'" + txtCMND.Text +"',"
                        + "N'" + txtDiaChi.Text + "'," 
                        + "'" + txtSDT.Text +"',"
                        + "'" + txtEmail.Text + "',"
                        + "N'" + txtTDHV.Text + "',"
                        + "N'" + cboxDanToc.Text + "',"
                        + "N'" + cboxTonGiao.Text + "',"
                        + "N'" + cboxQuocTich.Text + "'"
                        + "N'" + cboxChuyenMon.Text + "',"
                        + "'" + cboxMaDV.Text + "',"
                        + "'" + txtMaThue.Text + "',"
                        + "'" + txtMaLuong.Text + "',"
                        + "'" + txtMaBHXH.Text + "',"
                        + "N'" + txtGhiChu.Text + "')";

                    string queryAddNVBangLuong = @"insert into tbl_luong (MaLuong,MaNV, TenNV) values("
                        +"'"+txtMaLuong.Text+"',"
                        +"'"+txtMaNV.Text+"',"
                        +"N'"+txtHoTen.Text+"')";

                    string queryAddNVBangBHXH = @"insert into tbl_baohiemxh (MaSoBH,MaNV) values("
                        + "'" + txtMaBHXH.Text + "',"
                        + "'" + txtMaNV.Text + "')";

                    string queryAddNVBangThue = @"insert into tbl_thuetncn (MaThue,MaNV, MaLuong) values("
                        + "'" + txtMaThue.Text + "',"
                        + "'" + txtMaNV.Text + "',"
                        + "'" + txtMaLuong.Text + "')";

                    Conn.executeQuery(queryAddNhanVien);
                    Conn.executeQuery(queryAddNVBangLuong);
                    Conn.executeQuery(queryAddNVBangBHXH);
                    Conn.executeQuery(queryAddNVBangThue);

                    btnCapNhat.Enabled = true;
                    btnXoa.Enabled = true;
                    btnExport.Enabled = true;
                    btnMoi.Enabled = true;

                    Load_data();
                }
                catch(Exception)
                {

                }
                btnThem.Enabled = false;
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string queryUpdateNV = @"update tbl_nhanvien set "
                        + "TenNV=N'" + txtHoTen.Text + "',"
                        + "GioiTinh =N'" + gioiTinh + "',"
                        + " NgaySinh='" + dateNgaySinh.Text + "',"
                        + "NoiSinh=N'" + txtNoiSinh.Text + "',"
                        + "CMND='" + txtCMND.Text + "',"
                        + "DiaChi=N'" + txtDiaChi.Text + "',"
                        + "SDT='" + txtSDT.Text + "',"
                        + "Email='" + txtEmail.Text + "',"
                        + "TDHV=N'" + txtTDHV.Text + "',"
                        + "MaDanToc=N'" + cboxDanToc.Text + "',"
                        + "MaTonGiao=N'" + cboxTonGiao.Text + "',"
                        + "QuocTich=N'" + cboxQuocTich.Text + "'"
                        + "ChuyenMon=N'" + cboxChuyenMon.Text + "',"
                        + "MaDonVi='" + cboxMaDV.Text + "',"
                        + "MaThue='" + txtMaThue.Text + "',"
                        + "MaLuong='" + txtMaLuong.Text + "',"
                        + "MaBHXH='" + txtMaBHXH.Text + "',"
                        + "GhiChu=N'" + txtGhiChu.Text + "'"
                        +" where (MaNV=N'"+txtMaNV.Text+"')";

            string queryUpdateNVBangLuong = @"update tbl_luong set "
                        + "TenNV=N'" + txtHoTen.Text + "')"
                        + "MaLuong='" + txtMaLuong.Text + "',"
                        + " where (MaNV='" + txtMaNV.Text + "')";

            string queryUpdateNVBangBHXH = @"update tbl_baohiemxh set "
                + "MaSoBH='" + txtMaBHXH.Text + "'"
                + " where (MaNV='" + txtMaNV.Text + "')";

            string queryUpdateNVBangThue = @"update tbl_thuetncn set "
                + "MaThue='" + txtMaThue.Text + "',"
                + "MaLuong='" + txtMaLuong.Text + "'"
                + " where MaNV='" + txtMaNV.Text + "'";

            Conn.executeQuery(queryUpdateNV);
            Conn.executeQuery(queryUpdateNVBangLuong);
            Conn.executeQuery(queryUpdateNVBangBHXH);
            Conn.executeQuery(queryUpdateNVBangThue);

            Load_data();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string queryDeleteNV = "delete from tbl_nhanvien where MaNV='" + txtMaNV.Text + "'";
            string queryDeleteNVBangLuong = "delete from tbl_luong where MaNV='" + txtMaNV.Text + "'";
            string queryDeleteNVBangBHXH = "delete from tbl_baohiemxh where MaNV='" + txtMaNV.Text + "'";
            string queryDeleteNVBangThue = "delete from tbl_thuetncn where MaNV='" + txtMaNV.Text + "'";

            DialogResult dg = MessageBox.Show("Bạn có muốn xóa nhân viên: " + txtMaNV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                try
                {
                    Conn.executeQuery(queryDeleteNV);
                    Conn.executeQuery(queryDeleteNVBangLuong);
                    Conn.executeQuery(queryDeleteNVBangBHXH);
                    Conn.executeQuery(queryDeleteNVBangThue);

                    Load_data();
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.exprotExcel(dataNhanVien, @"D:\", "ThongTinNhanVien");
            DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở file Exel?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) { 
                System.Diagnostics.Process.Start(@"D:\");
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            btnExport.Enabled = false;
            btnMoi.Enabled = false;

            Load_data();
            txtMaNV.Enabled = true;
            txtMaLuong.Enabled = true;
            txtMaThue.Enabled = true;
            txtMaBHXH.Enabled = true;

            txtMaNV.Text = "";
            radNam.Checked = true;
            txtCMND.Text = "";
            txtTDHV.Text = "";
            txtMaLuong.Text = "";
            txtMaBHXH.Text = "";
            txtEmail.Text = "";

            txtHoTen.Text = "";
            dateNgaySinh.Text = "1/1/1997";
            txtNoiSinh.Text = "";
            txtDiaChi.Text = "";
            cboxMaDV.Text = "";
            txtMaThue.Text = "";

            cboxQuocTich.Text = "";
            cboxTonGiao.Text = "";
            cboxDanToc.Text = "";
            txtSDT.Text = "";
            cboxChuyenMon.Text = "";
            txtGhiChu.Text = "";

            txtMaNV.Focus();
        }

        private void btnThemMaLuong_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtMaLuong.Text = "L" + txtMaNV.Text;
            txtMaBHXH.Text = "BH" + txtMaNV.Text;
            txtMaThue.Text = "T" + txtMaNV.Text;
        }

        private void dataNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataNhanVien.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    radNam.Checked = true;
                    radNu.Checked = false;
                }
                else
                {
                    radNu.Checked = true;
                    radNam.Checked = false;
                }
                dateNgaySinh.Text = row.Cells[3].Value.ToString();
                txtNoiSinh.Text = row.Cells[4].Value.ToString();
                txtCMND.Text = row.Cells[5].Value.ToString();
                txtDiaChi.Text = row.Cells[6].Value.ToString();
                txtSDT.Text = row.Cells[7].Value.ToString();
                txtEmail.Text = row.Cells[8].Value.ToString();
                txtTDHV.Text = row.Cells[9].Value.ToString();
                cboxDanToc.Text = row.Cells[10].Value.ToString();
                cboxTonGiao.Text = row.Cells[11].Value.ToString();
                cboxQuocTich.Text = row.Cells[12].Value.ToString();
                cboxChuyenMon.Text = row.Cells[13].Value.ToString();
                cboxMaDV.Text = row.Cells[14].Value.ToString();
                txtMaThue.Text = row.Cells[15].Value.ToString();
                txtMaLuong.Text = row.Cells[16].Value.ToString();
                txtMaBHXH.Text = row.Cells[17].Value.ToString();
                txtGhiChu.Text = row.Cells[18].Value.ToString();

                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                btnExport.Enabled = true;
                btnMoi.Enabled = true;
            }
            catch (Exception)
            {

            }

        }
    }
}
