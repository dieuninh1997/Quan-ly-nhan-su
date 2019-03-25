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
    public partial class frmBHXH : Form
    {
        public frmBHXH()
        {
            InitializeComponent();
        }
        public void Load_data()
        {
            string querySelectAllBHXH = "select * from tbl_baohiemxh";
            DataTable dt = KiemTraKetNoi.getDatatable(querySelectAllBHXH, "tbl_baohiemxh");
            dataBaoHiem.DataSource = dt;
        }
        private void frmBHXH_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            btnThem.Enabled = false;
            Load_data();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Common.exprotExcel(dataBaoHiem, @"D:\", "BaoHiemXaHoi");
            DialogResult dialog = MessageBox.Show("Xuất thành công. Bạn có muốn mở thư mục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"D:\");

            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mã NV không được để trống!","Lỗi");
            }
            else
            {
                try
                {
                    //
                    string queryAddBHXH = "INSERT INTO tbl_baohiemxh(MaNV, MaSoBH, NgayCap, NoiCap, NoiDKKCB, GhiChu) VALUES ('" + txtMaNV.Text + "','" + txtMaSBH.Text + "','" + dateNgayCap.Text + "',N'" + txtNoiCap.Text + "',N'" + txtNoiDKKCB.Text + "',N'" + txtGhiChu.Text + "')";
                    // Add nhân viên vào bảng TTNV
                    string queryAddBangNV = "INSERT INTO tbl_nhanvien(MaNV,MaBHXH) VALUES ('" + txtMaNV.Text + "','" + txtMaSBH.Text + "')";
                    // Add nhân viên vào bảng Lương
                    string queryAddBangLuong = "INSERT INTO tbl_luong(MaNV) VALUES ('" + txtMaNV.Text + "')";

                    Conn.executeQuery(queryAddBHXH);
                    Conn.executeQuery(queryAddBangNV);
                    Conn.executeQuery(queryAddBangLuong);

                    Load_data();

                    txtMaNV.Enabled = false;
                    btnThem.Enabled = true;
                    btnCapNhat.Enabled = true;
                    btnXuatExcel.Enabled = true;
                    btnMoi.Enabled = true;
                    btnXoa.Enabled = true;

                    txtMaNV.Enabled = false;
                }
                catch (Exception)
                {

                }
            }
            btnThem.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string queryUpdateBHXH = "UPDATE tbl_baohiemxh SET MaSoBH=N'" + txtMaSBH.Text + "',NgayCap='" + dateNgayCap.Text + "',NoiCap=N'" + txtNoiCap.Text + "',NoiDKKCB=N'" + txtNoiDKKCB.Text + "',GhiChu=N'" + txtGhiChu.Text + "' WHERE(MaNV=N'" + txtMaNV.Text + "')";
            string queryUpdateTTNV = "update tbl_nhanvien set MaBHXH='" + txtMaSBH.Text + "' where MaNV='" + txtMaNV.Text + "'";

            Conn.executeQuery(queryUpdateBHXH);
            Conn.executeQuery(queryUpdateTTNV);

            Load_data();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string queryDeleteBH = "DELETE FROM tbl_baohiemxh WHERE MaNV='" + txtMaNV.Text + "'";
            string queryDeleteTTNV = "DELETE FROM tbl_nhanvien WHERE MaNV='" + txtMaNV.Text + "'";
            string queryDeleteLuong = "DELETE FROM tbl_luong WHERE MaNV='" + txtMaNV.Text + "'";
            string queryDeleteThue = "delete from tbl_thuetncn where MaNV='" + txtMaNV.Text + "'";

            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa BHXH nhân viên: " + txtMaNV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Conn.executeQuery(queryDeleteBH);
                    Conn.executeQuery(queryDeleteTTNV);
                    Conn.executeQuery(queryDeleteLuong);
                    Conn.executeQuery(queryDeleteThue);

                    Load_data();
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXuatExcel.Enabled = false;
            btnMoi.Enabled = false;
            Load_data();
            txtMaNV.Text = "";
            txtMaSBH.Text = "BH";
            dateNgayCap.Text = "1/1/2016";
            txtNoiCap.Text = "";
            txtNoiDKKCB.Text = "";
            txtGhiChu.Text = "";
            txtMaNV.Enabled = true;
        }

        private void dataBaoHiem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataBaoHiem.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtMaSBH.Text = row.Cells[1].Value.ToString();
                dateNgayCap.Text = row.Cells[2].Value.ToString();
                txtNoiCap.Text = row.Cells[3].Value.ToString();
                txtNoiDKKCB.Text = row.Cells[4].Value.ToString();
                txtGhiChu.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception)
            { }
        }
    }
}
