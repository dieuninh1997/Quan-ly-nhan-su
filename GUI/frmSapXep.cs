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
    public partial class frmSapXep : Form
    {
        const int SHORT_HEIGHT = 140;
        const int LONG_HEIGHT = 550;
        public frmSapXep()
        {
            InitializeComponent();
        }

        private void frmSapXep_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Height = SHORT_HEIGHT;
        }

        private void cboxChuyenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCM = cboxChuyenMon.SelectedItem.ToString();
            switch (selectedCM)
            {
                case "CEO":
                    txtMaChuyenMon.Text = "CM001";
                    break;
                case "Quản Lý":
                    txtMaChuyenMon.Text = "CM002";
                    break;
                case "Bán Hàng":
                    txtMaChuyenMon.Text = "CM003";
                    break;
                case "Kế Toán":
                    txtMaChuyenMon.Text = "CM004";
                    break;
            }
            
            this.Height = LONG_HEIGHT;
            string querySelectCM = "SELECT MaNV, TenNV, ChuyenMon FROM tblTTNhanVien WHERE ChuyenMon=N'" + cboxChuyenMon.Text + "'";
            DataTable dt = Conn.getDataTable(querySelectCM);
            dataHienThiCM.DataSource = dt;
            int count = dataHienThiCM.Rows.Count - 1;
            txtTongSo.Text = count.ToString();
        }

        private void btnXoaCM_Click(object sender, EventArgs e)
        {
            string queryDeleteTTNV = "DELETE FROM tbl_nhanvien WHERE MaNV='" + lbMaNV.Text + "'";
            try
            {
                Conn.executeQuery(queryDeleteTTNV);
                string querySelectCM = "SELECT MaNV, TenNV, ChuyenMon FROM tbl_nhanvien WHERE ChuyenMon=N'" + cboxChuyenMon.Text + "'";
                DataTable dt = Conn.getDataTable(querySelectCM);
                dataHienThiCM.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        private void btnSuaCM_Click(object sender, EventArgs e)
        {
            string queryUpdateCM = "UPDATE tbl_nhanvien SET ChuyenMon=N'" + cboxChuyenMon.Text + "'WHERE(MaNV='" + lbMaNV.Text + "')";
            try
            {
                DataTable dt = Conn.getDataTable(queryUpdateCM);
                dataHienThiCM.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            string queryDeleteTTNV = "DELETE FROM tbl_nhanvien WHERE MaNV='" + lbMaNV.Text + "'";
            try
            {
                Conn.executeQuery(queryDeleteTTNV);
                string querySelectDV = "SELECT MaNV, TenNV, ChuyenMon FROM tbl_nhanvien WHERE MaDonVi=N'" + txtMaDV.Text + "'";
                DataTable dt = Conn.getDataTable(querySelectDV);
                dataHienThiDV.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        private void cboxTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDV = cboxTenDV.SelectedItem.ToString();
            switch (selectedDV)
            {
                case "Văn Phòng":
                    txtMaDV.Text = "DV001";
                    break;
                case "Phòng Tổ chức lao động":
                    txtMaDV.Text = "DV002";
                    break;
                case "Phòng Vật tư":
                    txtMaDV.Text = "DV004";
                    break;
                case "Phòng Kế hoạch - Tiêu thụ":
                    txtMaDV.Text = "DV005";
                    break;
                case "Phòng Điều hành sản xuất":
                    txtMaDV.Text = "DV006";
                    break;
                case "Phòng Thanh tra BVQS":
                    txtMaDV.Text = "DV007";
                    break;
            }
           
            this.Height = LONG_HEIGHT;
            string querySelectDV = "SELECT MaNV, TenNV FROM tbl_nhanvien WHERE MaDonVi=N'" + txtMaDV.Text + "'";
            DataTable dt = Conn.getDataTable(querySelectDV);
            dataHienThiDV.DataSource = dt;
            int count = dataHienThiDV.Rows.Count - 1;
            txtTongSo.Text = count.ToString();

        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            string queryUpdateDV = "UPDATE tbl_nhanvien SET MaDonVi=N'" + txtMaDV.Text + "' WHERE(MaNV='" + lbMaNV.Text + "')";
            try
            {
                DataTable dt = Conn.getDataTable(queryUpdateDV);
                dataHienThiDV.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        private void cboxTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Height = LONG_HEIGHT;
            string querySelectTD = "SELECT MaNV, TenNV FROM tbl_nhanvien WHERE TDHV=N'" + cboxTrinhDo.Text + "'";
            DataTable dt = Conn.getDataTable(querySelectTD);
            dataTrinhDo.DataSource = dt;
            int count = dataTrinhDo.Rows.Count - 1;
            txtTongSo.Text = count.ToString();
        }

        private void btnSuaTD_Click(object sender, EventArgs e)
        {
            string queryUpdateTD = "UPDATE tbl_nhanvien SET TDHV=N'" + cboxTrinhDo.Text + "' WHERE(MaNV='" + lbMaNV.Text + "')";
            try
            {
                DataTable dt = Conn.getDataTable(queryUpdateTD);
                dataTrinhDo.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        private void btnXoaTD_Click(object sender, EventArgs e)
        {
            string queryDeleteTTNV = "DELETE FROM tbl_nhanvien WHERE MaNV='" + lbMaNV.Text + "'";
            try
            {
                Conn.executeQuery(queryDeleteTTNV);
                string querySelectTD = "SELECT MaNV, TenNV FROM tbl_nhanvien WHERE TDHV=N'" + cboxTrinhDo.Text + "'";
                DataTable dt = Conn.getDataTable(querySelectTD);
                dataTrinhDo.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        private void dataTrinhDo_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lbMaNV.Text = dataTrinhDo.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void dataHienThiDV_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lbMaNV.Text = dataHienThiDV.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void dataHienThiCM_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lbMaNV.Text = dataHienThiCM.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
