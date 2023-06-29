namespace GUI.FormLevel1
{
    partial class Form1TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1TaiKhoan));
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnDoiTenDangNhap = new System.Windows.Forms.Button();
            this.btnSuaThongTinCaNhan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtLoaiNhanVien = new System.Windows.Forms.TextBox();
            this.txtNgayThem = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(132, 362);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(736, 50);
            this.btnDoiMatKhau.TabIndex = 12;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnDoiTenDangNhap
            // 
            this.btnDoiTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDoiTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnDoiTenDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiTenDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDoiTenDangNhap.Location = new System.Drawing.Point(132, 306);
            this.btnDoiTenDangNhap.Name = "btnDoiTenDangNhap";
            this.btnDoiTenDangNhap.Size = new System.Drawing.Size(736, 50);
            this.btnDoiTenDangNhap.TabIndex = 11;
            this.btnDoiTenDangNhap.Text = "Đổi tên đăng nhập";
            this.btnDoiTenDangNhap.UseVisualStyleBackColor = false;
            this.btnDoiTenDangNhap.Click += new System.EventHandler(this.btnDoiTenDangNhap_Click);
            // 
            // btnSuaThongTinCaNhan
            // 
            this.btnSuaThongTinCaNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaThongTinCaNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnSuaThongTinCaNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaThongTinCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThongTinCaNhan.ForeColor = System.Drawing.Color.White;
            this.btnSuaThongTinCaNhan.Location = new System.Drawing.Point(132, 250);
            this.btnSuaThongTinCaNhan.Name = "btnSuaThongTinCaNhan";
            this.btnSuaThongTinCaNhan.Size = new System.Drawing.Size(736, 50);
            this.btnSuaThongTinCaNhan.TabIndex = 10;
            this.btnSuaThongTinCaNhan.Text = "Sửa thông tin cá nhân";
            this.btnSuaThongTinCaNhan.UseVisualStyleBackColor = false;
            this.btnSuaThongTinCaNhan.Click += new System.EventHandler(this.btnSuaThongTinCaNhan_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng thái:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày thêm:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại nhân viên:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Image = global::GUI.Properties.Resources.ZImageDefault;
            this.picHinhAnh.Location = new System.Drawing.Point(132, 40);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(200, 200);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 16;
            this.picHinhAnh.TabStop = false;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDangNhap.Location = new System.Drawing.Point(468, 37);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(400, 27);
            this.txtTenDangNhap.TabIndex = 5;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoVaTen.Location = new System.Drawing.Point(468, 82);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.ReadOnly = true;
            this.txtHoVaTen.Size = new System.Drawing.Size(400, 27);
            this.txtHoVaTen.TabIndex = 6;
            // 
            // txtLoaiNhanVien
            // 
            this.txtLoaiNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLoaiNhanVien.Location = new System.Drawing.Point(468, 127);
            this.txtLoaiNhanVien.Name = "txtLoaiNhanVien";
            this.txtLoaiNhanVien.ReadOnly = true;
            this.txtLoaiNhanVien.Size = new System.Drawing.Size(400, 27);
            this.txtLoaiNhanVien.TabIndex = 7;
            // 
            // txtNgayThem
            // 
            this.txtNgayThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgayThem.Location = new System.Drawing.Point(468, 172);
            this.txtNgayThem.Name = "txtNgayThem";
            this.txtNgayThem.ReadOnly = true;
            this.txtNgayThem.Size = new System.Drawing.Size(400, 27);
            this.txtNgayThem.TabIndex = 8;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTrangThai.Location = new System.Drawing.Point(468, 217);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(400, 27);
            this.txtTrangThai.TabIndex = 9;
            // 
            // Form1TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 753);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtNgayThem);
            this.Controls.Add(this.txtLoaiNhanVien);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.btnDoiTenDangNhap);
            this.Controls.Add(this.btnSuaThongTinCaNhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHinhAnh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1TaiKhoan";
            this.Text = "Form1TaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnDoiTenDangNhap;
        private System.Windows.Forms.Button btnSuaThongTinCaNhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtLoaiNhanVien;
        private System.Windows.Forms.TextBox txtNgayThem;
        private System.Windows.Forms.TextBox txtTrangThai;
    }
}