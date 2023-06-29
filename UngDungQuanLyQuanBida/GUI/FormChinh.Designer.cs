namespace GUI
{
    partial class FormChinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinh));
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnKhuyenMai = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnSanh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picHinhAnhNhanVien = new System.Windows.Forms.PictureBox();
            this.panChinh = new System.Windows.Forms.Panel();
            this.mnuTaiKhoan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itmTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.itmThongTinQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.itmDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnhNhanVien)).BeginInit();
            this.mnuTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panMenu.Controls.Add(this.btnThongKe);
            this.panMenu.Controls.Add(this.btnHoaDon);
            this.panMenu.Controls.Add(this.btnKhuyenMai);
            this.panMenu.Controls.Add(this.btnDichVu);
            this.panMenu.Controls.Add(this.btnKhachHang);
            this.panMenu.Controls.Add(this.btnNhanVien);
            this.panMenu.Controls.Add(this.btnBan);
            this.panMenu.Controls.Add(this.btnSanh);
            this.panMenu.Controls.Add(this.panel3);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(1000, 50);
            this.panMenu.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoSize = true;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(629, 0);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(95, 50);
            this.btnThongKe.TabIndex = 22;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.AutoSize = true;
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(540, 0);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(89, 50);
            this.btnHoaDon.TabIndex = 21;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.AutoSize = true;
            this.btnKhuyenMai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhuyenMai.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKhuyenMai.FlatAppearance.BorderSize = 0;
            this.btnKhuyenMai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnKhuyenMai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnKhuyenMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnKhuyenMai.Location = new System.Drawing.Point(424, 0);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Size = new System.Drawing.Size(116, 50);
            this.btnKhuyenMai.TabIndex = 20;
            this.btnKhuyenMai.Text = "Khuyến mãi";
            this.btnKhuyenMai.UseVisualStyleBackColor = true;
            this.btnKhuyenMai.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.AutoSize = true;
            this.btnDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDichVu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDichVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.ForeColor = System.Drawing.Color.White;
            this.btnDichVu.Location = new System.Drawing.Point(341, 0);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(83, 50);
            this.btnDichVu.TabIndex = 19;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.AutoSize = true;
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(224, 0);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(117, 50);
            this.btnKhachHang.TabIndex = 18;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.AutoSize = true;
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(122, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(102, 50);
            this.btnNhanVien.TabIndex = 17;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnBan
            // 
            this.btnBan.AutoSize = true;
            this.btnBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBan.FlatAppearance.BorderSize = 0;
            this.btnBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.ForeColor = System.Drawing.Color.White;
            this.btnBan.Location = new System.Drawing.Point(61, 0);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(61, 50);
            this.btnBan.TabIndex = 16;
            this.btnBan.Text = "Bàn";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnSanh
            // 
            this.btnSanh.AutoSize = true;
            this.btnSanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSanh.FlatAppearance.BorderSize = 0;
            this.btnSanh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSanh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanh.ForeColor = System.Drawing.Color.White;
            this.btnSanh.Location = new System.Drawing.Point(0, 0);
            this.btnSanh.Name = "btnSanh";
            this.btnSanh.Size = new System.Drawing.Size(61, 50);
            this.btnSanh.TabIndex = 15;
            this.btnSanh.Text = "Sảnh";
            this.btnSanh.UseVisualStyleBackColor = true;
            this.btnSanh.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.picHinhAnhNhanVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(940, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 50);
            this.panel3.TabIndex = 14;
            // 
            // picHinhAnhNhanVien
            // 
            this.picHinhAnhNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnhNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHinhAnhNhanVien.Image = global::GUI.Properties.Resources.ZImageDefault;
            this.picHinhAnhNhanVien.Location = new System.Drawing.Point(10, 5);
            this.picHinhAnhNhanVien.Name = "picHinhAnhNhanVien";
            this.picHinhAnhNhanVien.Size = new System.Drawing.Size(40, 40);
            this.picHinhAnhNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnhNhanVien.TabIndex = 0;
            this.picHinhAnhNhanVien.TabStop = false;
            this.picHinhAnhNhanVien.Click += new System.EventHandler(this.picHinhAnhNhanVien_Click);
            // 
            // panChinh
            // 
            this.panChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panChinh.Location = new System.Drawing.Point(0, 50);
            this.panChinh.Name = "panChinh";
            this.panChinh.Size = new System.Drawing.Size(1000, 512);
            this.panChinh.TabIndex = 2;
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuTaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmTaiKhoan,
            this.itmThongTinQuan,
            this.itmDangXuat});
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(179, 76);
            // 
            // itmTaiKhoan
            // 
            this.itmTaiKhoan.Name = "itmTaiKhoan";
            this.itmTaiKhoan.Size = new System.Drawing.Size(178, 24);
            this.itmTaiKhoan.Text = "Tài khoản";
            this.itmTaiKhoan.Click += new System.EventHandler(this.itmTaiKhoan_Click);
            // 
            // itmThongTinQuan
            // 
            this.itmThongTinQuan.Name = "itmThongTinQuan";
            this.itmThongTinQuan.Size = new System.Drawing.Size(178, 24);
            this.itmThongTinQuan.Text = "Thông tin quán";
            this.itmThongTinQuan.Click += new System.EventHandler(this.itmThongTinQuan_Click);
            // 
            // itmDangXuat
            // 
            this.itmDangXuat.Name = "itmDangXuat";
            this.itmDangXuat.Size = new System.Drawing.Size(178, 24);
            this.itmDangXuat.Text = "Đăng xuất";
            this.itmDangXuat.Click += new System.EventHandler(this.itmDangXuat_Click);
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.panChinh);
            this.Controls.Add(this.panMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChinh";
            this.Text = "FormChinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnhNhanVien)).EndInit();
            this.mnuTaiKhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnKhuyenMai;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnSanh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picHinhAnhNhanVien;
        private System.Windows.Forms.Panel panChinh;
        private System.Windows.Forms.ContextMenuStrip mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem itmTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem itmThongTinQuan;
        private System.Windows.Forms.ToolStripMenuItem itmDangXuat;
    }
}