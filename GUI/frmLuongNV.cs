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
    public partial class frmLuongNV : Form
    {
        public frmLuongNV()
        {
            InitializeComponent();
        }
        public void Load_data()
        {
            string query = "select * from tbl_user";
            DataTable dt = KiemTraKetNoi.getDatatable(query, "tbl_user");
            dataLuong.DataSource = dt;
        }
        private void frmLuongNV_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            pn.Enabled = false;

            Load_data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!","Lỗi");
            }
            else
            {
                try
                {
                    string queryAddLuong = @"INSERT INTO tbl_luong(MaLuong, MaNV, TenNV, MaChuyenMon, LuongCoBan, PCChucVu, NgayNhap, LuongCBMoi, NgaySua, LyDo) VALUES ("
                        + "'" + txtMaLuong.Text + "',"
                        + "'" + txtMaNV.Text + "',"
                        +"N'" + txtHoTen.Text + "',"
                        +"'" + cboxMaCM.Text + "',"
                        +"'" + txtLuongCB.Text + "',"
                        +"'" + txtPCCV.Text + "',"
                        +"'" + dateNgayNhap.Text + "',"
                        +"'" + txtLuongCBMoi.Text + "',"
                        +"'" + dateNgaySua.Text + "',"
                        +"N'" + txtLyDo.Text + "')";

                    string queryAddLuongBangNV = @"INSERT INTO tbl_nhanvien (MaNV,TenNV,MaLuong) VALUES("
                        + "'"+ txtMaNV.Text + "',"
                        +"N'" + txtHoTen.Text + "',"
                        +"'" + txtMaLuong.Text + "')";

                    string queryAddLuongBangBHXH = @"INSERT INTO tbl_baohiemxh (MaNV) VALUES('" + txtMaNV.Text + "')";

                    string queryAddLuongBangThue = @"INSERT INTO tbl_thuetncn (MaNV,MaLuong) VALUES('" + txtMaNV.Text + "','" + txtMaLuong.Text + "')";

                    Conn.executeQuery(queryAddLuong);
                    Conn.executeQuery(queryAddLuongBangNV);
                    Conn.executeQuery(queryAddLuongBangBHXH);
                    Conn.executeQuery(queryAddLuongBangThue);

                    txtMaNV.Enabled = false;
                    btnThem.Enabled = true;
                    btnCapNhat.Enabled = true;
                    btnExport.Enabled = true;
                    btnXoa.Enabled = true;
                    btnMoi.Enabled = true;

                    Load_data();
                }
                catch (Exception)
                {

                }
            }
            btnThem.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string chuyenMon = "";
            switch (cboxMaCM.Text)
            {
                case "CM001":
                    chuyenMon = "CEO";
                    break;
                case "CM002":
                    chuyenMon = "Quản Lý";
                    break;
                case "CM003":
                    chuyenMon = "Bán Hàng";
                    break;
                case "CM004":
                    chuyenMon = "Kế Toán";
                    break;
            }
            
            string queryUpdateLuong = "UPDATE tbl_luong SET TenNV=N'" + txtHoTen.Text + "',MaLuong='" + txtMaLuong.Text + "',MaChuyenMon='" + cboxMaCM.Text + "',LuongCoBan='" + txtLuongCB.Text + "',PCChucVu='" + txtPCCV.Text + "',NgayNhap='" + dateNgayNhap.Text + "',LuongCBMoi='" + txtLuongCBMoi.Text + "',NgaySua='" + dateNgaySua.Text + "',LyDo=N'" + txtLyDo.Text + "' WHERE(MaNV=N'" + txtMaNV.Text + "')";
            string queryUpdateLuongBangNV = "UPDATE tbl_nhanvien SET MaNV='" + txtMaNV.Text + "',TenNV=N'" + txtHoTen.Text + "',MaLuong='" + txtMaLuong.Text + "',ChuyenMon='" + chuyenMon + "' WHERE (MaNV='" + txtMaNV.Text + "')";
            string queryUpdateLuongBangThue = "UPDATE tbl_thuetncn SET MaNV='" + txtMaNV.Text + "',MaLuong='" + txtMaLuong.Text + "' WHERE MaNV='" + txtMaNV.Text + "'";

            Conn.executeQuery(queryUpdateLuong);
            Conn.executeQuery(queryUpdateLuongBangNV);
            Conn.executeQuery(queryUpdateLuongBangThue);

            Load_data();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string queryDeleteLuong = "DELETE FROM tbl_nhanvien WHERE MaNV='" + txtMaNV.Text + "'";
            string queryDeleteLuongBangNV = "DELETE FROM tbl_nhanvien WHERE MaNV='" + txtMaNV.Text + "'";
            string queryDeleteLuongBangBH = "DELETE FROM tbl_baohiemxh WHERE MaNV='" + txtMaNV.Text + "'";
            string queryDeleteLuongBangThue = "DELETE FROM tbl_thuetncn WHERE MaNV='" + txtMaNV.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa lương nhân viên: " + txtMaNV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {

                    Conn.executeQuery(queryDeleteLuong);
                    Conn.executeQuery(queryDeleteLuongBangNV);
                    Conn.executeQuery(queryDeleteLuongBangBH);
                    Conn.executeQuery(queryDeleteLuongBangThue);

                    Load_data();
                }
                catch (Exception)
                {
                }
            }
        }
       
        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.exprotExcel(dataLuong, @"D:\", "LuongNhanVien");
            DialogResult dialog = MessageBox.Show("Xuất thành công! Bạn có muốn mở thư mục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
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

            txtMaNV.Text = "";
            txtHoTen.Text = "";
            cboxMaCM.Text = "";
            txtLuongCB.Text = "";
            txtPCCV.Text = "";
            dateNgayNhap.Text = "1/1/2016";
            txtLuongCBMoi.Text = "";
            dateNgaySua.Text = "1/1/2016";
            txtLyDo.Text = "";

            txtMaNV.Enabled = true;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtMaLuong.Text = "L" + txtMaNV.Text;
        }

        private void dataLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
