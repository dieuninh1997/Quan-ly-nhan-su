namespace GUI
{
    partial class frmSapXep
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataHienThiCM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaCM = new System.Windows.Forms.Button();
            this.btnXoaCM = new System.Windows.Forms.Button();
            this.cboxChuyenMon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaChuyenMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.cboxTenDV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataHienThiDV = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataTrinhDo = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaTD = new System.Windows.Forms.Button();
            this.btnXoaTD = new System.Windows.Forms.Button();
            this.cboxTrinhDo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThiCM)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThiDV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrinhDo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataHienThiCM);
            this.tabPage1.Controls.Add(this.btnSuaCM);
            this.tabPage1.Controls.Add(this.btnXoaCM);
            this.tabPage1.Controls.Add(this.cboxChuyenMon);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMaChuyenMon);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chuyên môn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataHienThiCM
            // 
            this.dataHienThiCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHienThiCM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataHienThiCM.Location = new System.Drawing.Point(3, 83);
            this.dataHienThiCM.Name = "dataHienThiCM";
            this.dataHienThiCM.ReadOnly = true;
            this.dataHienThiCM.RowTemplate.Height = 24;
            this.dataHienThiCM.Size = new System.Drawing.Size(594, 339);
            this.dataHienThiCM.TabIndex = 6;
            this.dataHienThiCM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataHienThiCM_MouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Tên NV";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ChuyenMon";
            this.Column3.HeaderText = "Chuyên môn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 121;
            // 
            // btnSuaCM
            // 
            this.btnSuaCM.Location = new System.Drawing.Point(377, 31);
            this.btnSuaCM.Name = "btnSuaCM";
            this.btnSuaCM.Size = new System.Drawing.Size(75, 23);
            this.btnSuaCM.TabIndex = 5;
            this.btnSuaCM.Text = "Sửa";
            this.btnSuaCM.UseVisualStyleBackColor = true;
            this.btnSuaCM.Click += new System.EventHandler(this.btnSuaCM_Click);
            // 
            // btnXoaCM
            // 
            this.btnXoaCM.Location = new System.Drawing.Point(482, 31);
            this.btnXoaCM.Name = "btnXoaCM";
            this.btnXoaCM.Size = new System.Drawing.Size(75, 23);
            this.btnXoaCM.TabIndex = 4;
            this.btnXoaCM.Text = "Xóa";
            this.btnXoaCM.UseVisualStyleBackColor = true;
            this.btnXoaCM.Click += new System.EventHandler(this.btnXoaCM_Click);
            // 
            // cboxChuyenMon
            // 
            this.cboxChuyenMon.FormattingEnabled = true;
            this.cboxChuyenMon.Location = new System.Drawing.Point(117, 49);
            this.cboxChuyenMon.Name = "cboxChuyenMon";
            this.cboxChuyenMon.Size = new System.Drawing.Size(184, 21);
            this.cboxChuyenMon.TabIndex = 3;
            this.cboxChuyenMon.SelectedIndexChanged += new System.EventHandler(this.cboxChuyenMon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên chuyên môn";
            // 
            // txtMaChuyenMon
            // 
            this.txtMaChuyenMon.Location = new System.Drawing.Point(117, 16);
            this.txtMaChuyenMon.Name = "txtMaChuyenMon";
            this.txtMaChuyenMon.Size = new System.Drawing.Size(184, 20);
            this.txtMaChuyenMon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chuyên môn";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSuaDV);
            this.tabPage2.Controls.Add(this.btnXoaDV);
            this.tabPage2.Controls.Add(this.cboxTenDV);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtMaDV);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataHienThiDV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đơn vị";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.Location = new System.Drawing.Point(372, 26);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDV.TabIndex = 11;
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.Location = new System.Drawing.Point(477, 26);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDV.TabIndex = 10;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.UseVisualStyleBackColor = true;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // cboxTenDV
            // 
            this.cboxTenDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTenDV.FormattingEnabled = true;
            this.cboxTenDV.Location = new System.Drawing.Point(77, 44);
            this.cboxTenDV.Name = "cboxTenDV";
            this.cboxTenDV.Size = new System.Drawing.Size(219, 21);
            this.cboxTenDV.TabIndex = 9;
            this.cboxTenDV.SelectedIndexChanged += new System.EventHandler(this.cboxTenDV_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên đơn vị";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(77, 11);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(219, 20);
            this.txtMaDV.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã đơn vị";
            // 
            // dataHienThiDV
            // 
            this.dataHienThiDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHienThiDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.dataHienThiDV.Location = new System.Drawing.Point(3, 83);
            this.dataHienThiDV.Name = "dataHienThiDV";
            this.dataHienThiDV.ReadOnly = true;
            this.dataHienThiDV.RowTemplate.Height = 24;
            this.dataHienThiDV.Size = new System.Drawing.Size(597, 339);
            this.dataHienThiDV.TabIndex = 4;
            this.dataHienThiDV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataHienThiDV_MouseClick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaNV";
            this.Column4.HeaderText = "Mã NV";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HoTen";
            this.Column5.HeaderText = "Họ Tên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 251;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataTrinhDo);
            this.tabPage3.Controls.Add(this.btnSuaTD);
            this.tabPage3.Controls.Add(this.btnXoaTD);
            this.tabPage3.Controls.Add(this.cboxTrinhDo);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(603, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trình độ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataTrinhDo
            // 
            this.dataTrinhDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrinhDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7});
            this.dataTrinhDo.Location = new System.Drawing.Point(2, 83);
            this.dataTrinhDo.Name = "dataTrinhDo";
            this.dataTrinhDo.RowTemplate.Height = 24;
            this.dataTrinhDo.Size = new System.Drawing.Size(599, 339);
            this.dataTrinhDo.TabIndex = 14;
            this.dataTrinhDo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataTrinhDo_MouseClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaNV";
            this.Column6.HeaderText = "Mã NV";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "HoTen";
            this.Column7.HeaderText = "Họ Tên";
            this.Column7.Name = "Column7";
            this.Column7.Width = 251;
            // 
            // btnSuaTD
            // 
            this.btnSuaTD.Location = new System.Drawing.Point(368, 19);
            this.btnSuaTD.Name = "btnSuaTD";
            this.btnSuaTD.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTD.TabIndex = 13;
            this.btnSuaTD.Text = "Sửa";
            this.btnSuaTD.UseVisualStyleBackColor = true;
            this.btnSuaTD.Click += new System.EventHandler(this.btnSuaTD_Click);
            // 
            // btnXoaTD
            // 
            this.btnXoaTD.Location = new System.Drawing.Point(473, 19);
            this.btnXoaTD.Name = "btnXoaTD";
            this.btnXoaTD.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTD.TabIndex = 12;
            this.btnXoaTD.Text = "Xóa";
            this.btnXoaTD.UseVisualStyleBackColor = true;
            this.btnXoaTD.Click += new System.EventHandler(this.btnXoaTD_Click);
            // 
            // cboxTrinhDo
            // 
            this.cboxTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTrinhDo.FormattingEnabled = true;
            this.cboxTrinhDo.Location = new System.Drawing.Point(84, 21);
            this.cboxTrinhDo.Name = "cboxTrinhDo";
            this.cboxTrinhDo.Size = new System.Drawing.Size(219, 21);
            this.cboxTrinhDo.TabIndex = 11;
            this.cboxTrinhDo.SelectedIndexChanged += new System.EventHandler(this.cboxTrinhDo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên trình độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng số";
            // 
            // txtTongSo
            // 
            this.txtTongSo.Location = new System.Drawing.Point(64, 470);
            this.txtTongSo.Name = "txtTongSo";
            this.txtTongSo.Size = new System.Drawing.Size(99, 20);
            this.txtTongSo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã NV:";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(236, 473);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(35, 13);
            this.lbMaNV.TabIndex = 9;
            this.lbMaNV.Text = "label8";
            // 
            // frmSapXep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 508);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongSo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmSapXep";
            this.Text = "frmSapXep";
            this.Load += new System.EventHandler(this.frmSapXep_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThiCM)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThiDV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrinhDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cboxChuyenMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaChuyenMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataHienThiCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnSuaCM;
        private System.Windows.Forms.Button btnXoaCM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataHienThiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.ComboBox cboxTenDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataTrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnSuaTD;
        private System.Windows.Forms.Button btnXoaTD;
        private System.Windows.Forms.ComboBox cboxTrinhDo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMaNV;
    }
}