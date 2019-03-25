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
    public partial class frmThueTNCN : Form
    {
        public frmThueTNCN()
        {
            InitializeComponent();
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
                    string MaBH = "BH" + txtMaNV.Text;

                    string queryAddThue = @"INSERT INTO tbl_thuetncn (MaThue, MaNV, MaLuong, CoQuanQuanLyThue, SoTien, NgayDangKi, GhiChu) VALUES(" 
                        +"'"+ txtMaThue.Text + "',"
                        +"'"+ txtMaNV.Text + "',"
                        +"N'" + txtCoQuanThue.Text + "',"
                        +"'" + txtMaLuong.Text + "',"
                        +"'" + txtSoTien.Text + "',"
                        +"'" + dateNgayDangKiThue.Text + "',"
                        +"N'" + txtGhiChu.Text + "')";

                    string queryAddThueBangLuong = @"INSERT INTO tbl_luong (MaNV,MaLuong) VALUES('" + txtMaNV.Text + "','" + txtMaLuong.Text + "')";

                    string queryAddThueBangBH = @"INSERT INTO tbl_baohiemxh (MaNV,MaSoBH) VALUES('" + txtMaNV.Text + "','" + MaBH + "')";

                    string queryAddThueBangNV = @"INSERT INTO tbl_nhanvien (MaNV,MaLuong,MaThue) VALUES('" + txtMaNV.Text + "','" + txtMaLuong.Text + "','" + txtMaThue.Text + "')";

                    Conn.executeQuery(queryAddThue);
                    Conn.executeQuery(queryAddThueBangLuong);
                    Conn.executeQuery(queryAddThueBangBH);
                    Conn.executeQuery(queryAddThueBangNV);

                    btnXoa.Enabled = true;
                    btnCapNhat.Enabled = true;
                    btnExport.Enabled = true;
                    btnMoi.Enabled = true;

                    Load_Thue();
                }
                catch (Exception)
                {

                }
            }
        }
        public void Load_Thue()
        {
            string str = "select * from tbl_thuetncn";
            DataTable dt = Conn.getDataTable(str);
            dataThue.DataSource = dt;
        }
        private void frmThueTNCN_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Load_Thue();

            btnThem.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string queryUpdateThue = "UPDATE tbl_thutncn SET MaThue='" + txtMaThue.Text + "',MaNV='" + txtMaNV.Text + "',CoQuanQuanLyThue=N'" + txtCoQuanThue.Text + "',MaLuong='" + txtMaLuong.Text + "',SoTien='" + txtSoTien.Text + "',NgayDangKi=N'" + dateNgayDangKiThue.Text + "',GhiChu=N'" + txtGhiChu.Text + "' WHERE(MaNV=N'" + txtMaNV.Text + "')";
            string queryUpdateThueBangNhanVien = "UPDATE tbl_nhanvien SET MaNV='" + txtMaNV.Text + "',MaLuong='" + txtMaLuong.Text + "' WHERE MaNV='" + txtMaNV.Text + "'";
            string queryUpdateThueBangLuong = "UPDATE tbl_luong SET MaNV='" + txtMaNV.Text + "',MaLuong='" + txtMaLuong.Text + "' WHERE MaNV='" + txtMaNV.Text + "'";

            Conn.executeQuery(queryUpdateThue);
            Conn.executeQuery(queryUpdateThueBangNhanVien);
            Conn.executeQuery(queryUpdateThueBangLuong);

            Load_Thue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string queryDeleteThue = "DELETE FROM tbl_thuetncn WHERE MaNV='" + txtMaNV.Text + "'";

            string queryDeleteThueBangNV = "DELETE FROM tbl_nhanvien WHERE MaNV='" + txtMaNV.Text + "'";

            string queryDeleteThueBangBH = "DELETE FROM tbl_baohiemxh WHERE MaNV='" + txtMaNV.Text + "'";

            string queryDeleteThueBangLuong = "DELETE FROM tbl_luong WHERE MaNV='" + txtMaNV.Text + "'";

            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa nhân viên:" + txtMaNV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Conn.executeQuery(queryDeleteThue);
                    Conn.executeQuery(queryDeleteThueBangNV);
                    Conn.executeQuery(queryDeleteThueBangBH);
                    Conn.executeQuery(queryDeleteThueBangLuong);

                    Load_Thue();
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.exprotExcel(dataThue, @"D:\", "ThueTHuNhapCaNhan");
            DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở file Exel?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            { 
                System.Diagnostics.Process.Start(@"D:\");
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            btnExport.Enabled = false;
            btnMoi.Enabled = false;

            Load_Thue();

            txtMaNV.Text = "";
            txtMaThue.Text = "";
            txtCoQuanThue.Text = "";
            txtMaLuong.Text = "";
            txtSoTien.Text = "";
            txtGhiChu.Text = "";

            txtMaNV.Focus();
        }
        public void TinhThue()
        {
            try
            {
                int TienPhaiNop = 0, ThuNhapTinhThue = 0, ThuNhapChiuThue = 0, CacKhoangGiamTru = 0, GiaDinh = 0, BaoHiem = 0;
                ThuNhapTinhThue = ThuNhapChiuThue - CacKhoangGiamTru;
                ThuNhapChiuThue = Int32.Parse(txtLuong.Text);

                if (checkGiaTruGiaDinh.Checked)
                    GiaDinh = 9000000; // 9 trieu
                if (checkBaoHiem.Checked)
                    BaoHiem = 950000; //9 tram ruoi

                CacKhoangGiamTru = (GiaDinh + BaoHiem);

                ThuNhapTinhThue = ThuNhapChiuThue - CacKhoangGiamTru;

                if (ThuNhapTinhThue <= 5000000)// duoi 5 trieu
                    TienPhaiNop = (ThuNhapChiuThue * 5) / 100; //5%

                if (ThuNhapTinhThue <= 10000000 && ThuNhapTinhThue > 5000000) //tu 5-10 trieu
                    TienPhaiNop = (ThuNhapChiuThue * 10) / 100 - 250000; //10% - 2 tram ruoi

                if (ThuNhapTinhThue <= 18000000 && ThuNhapTinhThue > 10000000) // tu 10-18 trieu
                    TienPhaiNop = (ThuNhapChiuThue * 15) / 100 - 750000;  //15% - 7 tram ruoi

                if (ThuNhapTinhThue <= 32000000 && ThuNhapTinhThue > 18000000) //tu 18-32 trieu
                    TienPhaiNop = (ThuNhapChiuThue * 20) / 100 - 1650000; // //20% - 1 trieu 6 tram ruoi

                if (ThuNhapTinhThue <= 52000000 && ThuNhapTinhThue > 32000000) // tu 32 -52 trieu
                    TienPhaiNop = (ThuNhapChiuThue * 25) / 100 - 3250000; //25% - 3 trieu 2 tram ruoi

                if (ThuNhapTinhThue <= 80000000 && ThuNhapTinhThue > 52000000)// tu 52 -80 trieu
                    TienPhaiNop = (ThuNhapChiuThue * 30) / 100 - 5850000;//30% - 5 trieu 8 tram ruoi

                if (ThuNhapTinhThue > 80000000)// tren 80 trieu
                    TienPhaiNop = (ThuNhapTinhThue * 35) / 100 - 9850000;//35% - 9 trieu 8 tram ruoi

                if (check10.Checked == true && check20.Checked == false) // khau tru 10%
                    TienPhaiNop = TienPhaiNop / 10 * 9;

                if (check20.Checked == true && check10.Checked == false)// khau tru 20%
                    TienPhaiNop = TienPhaiNop / 10 * 8;

                if (check20.Checked == true && check10.Checked == true) //// khau tru 10%, 20%
                    TienPhaiNop = TienPhaiNop / 10 * 7;

                txtSoTien.Text = TienPhaiNop.ToString();
            }
            catch (Exception)
            {
            }
        }
        private void btnTinhThue_Click(object sender, EventArgs e)
        {
            TinhThue();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtMaLuong.Text = "L" + txtMaNV.Text;
            txtMaThue.Text = "T" + txtMaNV.Text;
        }
        public void Load_Luong()
        {
            string str_ = "select LuongCoBan from tbl_luong where MaLuong='" + txtMaLuong.Text + "'";
            DataTable dt = Conn.getDataTable(str_);
            dataLuong.DataSource = dt;
        }
        private void dataThue_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataThue.Rows[e.RowIndex];

                txtMaThue.Text = row.Cells[0].Value.ToString();
                txtMaNV.Text = row.Cells[1].Value.ToString();
                txtCoQuanThue.Text = row.Cells[2].Value.ToString();
                txtMaLuong.Text = row.Cells[3].Value.ToString();
                dateNgayDangKiThue.Text = row.Cells[5].Value.ToString();
                txtSoTien.Text = row.Cells[4].Value.ToString();
                txtGhiChu.Text = row.Cells[6].Value.ToString();

                Load_Luong();
            }
            catch (Exception)
            { }
        }
    }
}
