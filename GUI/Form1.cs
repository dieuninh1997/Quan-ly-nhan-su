using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace GUI
{
    public partial class Form1 : Form
    {
        string username;
        string password;
        public Form1(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void đăngXuấtCtrlQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Form login = new frmDangNhap();
                login.ShowDialog();
            }
           
        }

        private void ngườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NguoiDung = new frmNguoiDung(this.username, this.password);
            NguoiDung.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DMK = new frmDoiMatKhau(this.username, this.password);
            DMK.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool backUpStatus = true;
            Cursor.Current = Cursors.WaitCursor;
            if (Directory.Exists(@"c:\SQLBackup"))
            {
                if (File.Exists(@"c:\SQLBackup\QLNSu.bak"))
                {
                    if (MessageBox.Show(@"Bạn có muốn thay thế nó?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(@"c:\SQLBackup\QLNS.bak");
                    }
                    else
                    {
                        backUpStatus = false;

                    }
                }
            }else
            {
                Directory.CreateDirectory(@"c:\SQLBackup");
            }

            if (backUpStatus)
            {
                //Connect to DB
                SqlConnection connect;
                string con = KiemTraKetNoi.connstring;
                connect = new SqlConnection(con);
                connect.Open();
                //----------------------------------------------------------------------------------------------------

                //Execute SQL---------------
                string excBackup = @"backup database QLNSu to disk ='c:\SQLBackup\QLNS.bak' with init,stats=10";
                SqlCommand command;
                command = new SqlCommand(excBackup, connect);
                command.ExecuteNonQuery();
                //-------------------------------------------------------------------------------------------------------------------------------

                connect.Close();

                MessageBox.Show("Backup dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (File.Exists(@"c:\SQLBackup\QLNS.bak"))
                {
                    if (MessageBox.Show("Bạn có muốn khôi phục?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Connect SQL-----------
                        SqlConnection connect;
                        string con = KiemTraKetNoi.connstring;
                        connect = new SqlConnection(con);
                        connect.Open();
                        //-----------------------------------------------------------------------------------------

                        //Excute SQL----------------
                        SqlCommand command;
                        command = new SqlCommand("use master", connect);
                        command.ExecuteNonQuery();
                        string excRestore = @"restore database QLNSu from disk = 'c:\SQLBackup\QLNS.bak'";
                        command = new SqlCommand(excRestore, connect);
                        command.ExecuteNonQuery();
                        //--------------------------------------------------------------------------------------------------------
                        connect.Close();

                        MessageBox.Show("Khôi phục dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(@"Không thực hiện bất kỳ sự chứng thực ở trên (hoặc không có trong đường dẫn chính xác )", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NV = new frmTTNhanVien(this.username);
            NV.ShowDialog();
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ThietLap = new frmCaiDat();
            ThietLap.ShowDialog();
        }

        private void bảoHiểmXHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form BHXH = new frmBHXH();
            BHXH.ShowDialog();
        }

        private void thuếTNCNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Thue = new frmThueTNCN();
            Thue.ShowDialog();
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Luong = new frmLuongNV();
            Luong.ShowDialog();
        }

        private void chuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form QuanLy = new frmSapXep();
            QuanLy.ShowDialog();
        }

        private void đơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form QuanLy = new frmSapXep();
            QuanLy.ShowDialog();
        }

        private void trìnhĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form QuanLy = new frmSapXep();
            QuanLy.ShowDialog();
        }

        private void giớiThiệuPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form GioiThieu = new frmGioiThieu();
            GioiThieu.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form TimKiem = new frmTimKiem();
            TimKiem.ShowDialog();
        }

        private void bảoHiểmXãHộiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form BH = new frmBaoCaoBHXH();
          //  BH.ShowDialog();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form TT = new frmBaoCaoTTNV();
           // TT.ShowDialog();
        }

        private void thuếThuNhậpCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Thue = new frmThueTNCN();
            Thue.ShowDialog();
        }

        private void lươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form Lg = new frmBaoCaoLuong();
           // Lg.ShowDialog();
        }
    }
}
