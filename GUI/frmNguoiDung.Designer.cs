namespace GUI
{
    partial class frmNguoiDung
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
            this.cboxPhanQuyen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataNguoiDung = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboxPhanQuyen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTaiKhoan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 145);
            this.panel1.TabIndex = 0;
            // 
            // cboxPhanQuyen
            // 
            this.cboxPhanQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPhanQuyen.FormattingEnabled = true;
            this.cboxPhanQuyen.Location = new System.Drawing.Point(103, 93);
            this.cboxPhanQuyen.Name = "cboxPhanQuyen";
            this.cboxPhanQuyen.Size = new System.Drawing.Size(288, 21);
            this.cboxPhanQuyen.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Phân quyền";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(103, 56);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(288, 20);
            this.txtMatKhau.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(103, 19);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(288, 20);
            this.txtTaiKhoan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tài khoản";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(86, 178);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(103, 23);
            this.btnDoiMK.TabIndex = 1;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(238, 178);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Phân quyền";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataNguoiDung);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 252);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản";
            // 
            // dataNguoiDung
            // 
            this.dataNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataNguoiDung.Location = new System.Drawing.Point(6, 19);
            this.dataNguoiDung.Name = "dataNguoiDung";
            this.dataNguoiDung.ReadOnly = true;
            this.dataNguoiDung.RowTemplate.Height = 24;
            this.dataNguoiDung.Size = new System.Drawing.Size(407, 224);
            this.dataNguoiDung.TabIndex = 1;
            this.dataNguoiDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNguoiDung_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Tài Khoản";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Password";
            this.Column2.HeaderText = "Mật Khẩu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PhanQuyen";
            this.Column3.HeaderText = "Phân Quyền";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.panel1);
            this.Name = "frmNguoiDung";
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxPhanQuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}