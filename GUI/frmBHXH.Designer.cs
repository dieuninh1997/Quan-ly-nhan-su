namespace GUI
{
    partial class frmBHXH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtNoiDKKCB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiCap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dateNgayCap = new System.Windows.Forms.DateTimePicker();
            this.txtMaSBH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataBaoHiem = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSoBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDKKCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaoHiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.txtNoiDKKCB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNoiCap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.dateNgayCap);
            this.panel1.Controls.Add(this.txtMaSBH);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 191);
            this.panel1.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(414, 75);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(201, 98);
            this.txtGhiChu.TabIndex = 65;
            // 
            // txtNoiDKKCB
            // 
            this.txtNoiDKKCB.Location = new System.Drawing.Point(414, 45);
            this.txtNoiDKKCB.Name = "txtNoiDKKCB";
            this.txtNoiDKKCB.Size = new System.Drawing.Size(201, 20);
            this.txtNoiDKKCB.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Nơi ĐK KCB";
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.Location = new System.Drawing.Point(414, 16);
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.Size = new System.Drawing.Size(201, 20);
            this.txtNoiCap.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Nơi cấp";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkRed;
            this.label20.Location = new System.Drawing.Point(299, 19);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 13);
            this.label20.TabIndex = 59;
            this.label20.Text = "(*)";
            // 
            // dateNgayCap
            // 
            this.dateNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayCap.Location = new System.Drawing.Point(93, 75);
            this.dateNgayCap.Name = "dateNgayCap";
            this.dateNgayCap.Size = new System.Drawing.Size(201, 20);
            this.dateNgayCap.TabIndex = 58;
            // 
            // txtMaSBH
            // 
            this.txtMaSBH.Location = new System.Drawing.Point(93, 45);
            this.txtMaSBH.Name = "txtMaSBH";
            this.txtMaSBH.Size = new System.Drawing.Size(201, 20);
            this.txtMaSBH.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Ngày cấp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Mã số BH";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(93, 16);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(201, 20);
            this.txtMaNV.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Mã nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMoi);
            this.panel2.Controls.Add(this.btnXuatExcel);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(12, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 65);
            this.panel2.TabIndex = 1;
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(467, 19);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(75, 23);
            this.btnMoi.TabIndex = 9;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(330, 19);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(105, 23);
            this.btnXuatExcel.TabIndex = 8;
            this.btnXuatExcel.Text = "Xuất file Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(224, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(121, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(18, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataBaoHiem
            // 
            this.dataBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaoHiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.MaSoBH,
            this.NgayCap,
            this.NoiCap,
            this.NoiDKKCB,
            this.GhiChu});
            this.dataBaoHiem.Location = new System.Drawing.Point(12, 280);
            this.dataBaoHiem.Name = "dataBaoHiem";
            this.dataBaoHiem.Size = new System.Drawing.Size(632, 222);
            this.dataBaoHiem.TabIndex = 2;
            this.dataBaoHiem.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataBaoHiem_CellMouseClick);
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // MaSoBH
            // 
            this.MaSoBH.HeaderText = "Mã số BH";
            this.MaSoBH.Name = "MaSoBH";
            // 
            // NgayCap
            // 
            this.NgayCap.HeaderText = "Ngày cấp";
            this.NgayCap.Name = "NgayCap";
            // 
            // NoiCap
            // 
            this.NoiCap.HeaderText = "Nơi cấp";
            this.NoiCap.Name = "NoiCap";
            // 
            // NoiDKKCB
            // 
            this.NoiDKKCB.HeaderText = "Nơi ĐK khám CB";
            this.NoiDKKCB.Name = "NoiDKKCB";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // frmBHXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 512);
            this.Controls.Add(this.dataBaoHiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBHXH";
            this.Text = "Bảo hiểm xã hội";
            this.Load += new System.EventHandler(this.frmBHXH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaoHiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateNgayCap;
        private System.Windows.Forms.TextBox txtMaSBH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataBaoHiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDKKCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.TextBox txtNoiDKKCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGhiChu;
    }
}