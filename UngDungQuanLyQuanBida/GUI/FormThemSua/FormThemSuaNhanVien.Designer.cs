namespace GUI.FormThemSua
{
    partial class FormThemSuaNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemSuaNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panLoiTenDangNhap = new System.Windows.Forms.Panel();
            this.lblLoiTenDangNhap = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panLoiHoVaTen = new System.Windows.Forms.Panel();
            this.lblLoiHoVaTen = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cboLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panLoiLoaiNhanVien = new System.Windows.Forms.Panel();
            this.lblLoiLoaiNhanVien = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picHinhAnhNhanVien = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radKhongConLamViec = new System.Windows.Forms.RadioButton();
            this.radConLamViec = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panLoiTrangThai = new System.Windows.Forms.Panel();
            this.lblLoiTrangThai = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panLoiTenDangNhap.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panLoiHoVaTen.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panLoiLoaiNhanVien.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnhNhanVien)).BeginInit();
            this.panel9.SuspendLayout();
            this.panLoiTrangThai.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(200, 25);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(550, 50);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Tiêu đề";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenDangNhap);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 11;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDangNhap.Location = new System.Drawing.Point(200, 26);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(400, 27);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Tên đăng nhập:";
            // 
            // panLoiTenDangNhap
            // 
            this.panLoiTenDangNhap.Controls.Add(this.lblLoiTenDangNhap);
            this.panLoiTenDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiTenDangNhap.Location = new System.Drawing.Point(0, 160);
            this.panLoiTenDangNhap.Name = "panLoiTenDangNhap";
            this.panLoiTenDangNhap.Size = new System.Drawing.Size(800, 40);
            this.panLoiTenDangNhap.TabIndex = 12;
            // 
            // lblLoiTenDangNhap
            // 
            this.lblLoiTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiTenDangNhap.AutoSize = true;
            this.lblLoiTenDangNhap.ForeColor = System.Drawing.Color.Red;
            this.lblLoiTenDangNhap.Location = new System.Drawing.Point(200, 3);
            this.lblLoiTenDangNhap.Name = "lblLoiTenDangNhap";
            this.lblLoiTenDangNhap.Size = new System.Drawing.Size(142, 20);
            this.lblLoiTenDangNhap.TabIndex = 0;
            this.lblLoiTenDangNhap.Text = "Lỗi tên đăng nhập";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtHoVaTen);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 60);
            this.panel3.TabIndex = 13;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoVaTen.Location = new System.Drawing.Point(200, 26);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(400, 27);
            this.txtHoVaTen.TabIndex = 1;
            this.txtHoVaTen.TextChanged += new System.EventHandler(this.txtHoVaTen_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "* Họ và tên:";
            // 
            // panLoiHoVaTen
            // 
            this.panLoiHoVaTen.Controls.Add(this.lblLoiHoVaTen);
            this.panLoiHoVaTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiHoVaTen.Location = new System.Drawing.Point(0, 260);
            this.panLoiHoVaTen.Name = "panLoiHoVaTen";
            this.panLoiHoVaTen.Size = new System.Drawing.Size(800, 40);
            this.panLoiHoVaTen.TabIndex = 14;
            // 
            // lblLoiHoVaTen
            // 
            this.lblLoiHoVaTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiHoVaTen.AutoSize = true;
            this.lblLoiHoVaTen.ForeColor = System.Drawing.Color.Red;
            this.lblLoiHoVaTen.Location = new System.Drawing.Point(200, 3);
            this.lblLoiHoVaTen.Name = "lblLoiHoVaTen";
            this.lblLoiHoVaTen.Size = new System.Drawing.Size(105, 20);
            this.lblLoiHoVaTen.TabIndex = 0;
            this.lblLoiHoVaTen.Text = "Lỗi họ và tên";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cboLoaiNhanVien);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 300);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 60);
            this.panel6.TabIndex = 15;
            // 
            // cboLoaiNhanVien
            // 
            this.cboLoaiNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiNhanVien.FormattingEnabled = true;
            this.cboLoaiNhanVien.Location = new System.Drawing.Point(200, 26);
            this.cboLoaiNhanVien.Name = "cboLoaiNhanVien";
            this.cboLoaiNhanVien.Size = new System.Drawing.Size(400, 28);
            this.cboLoaiNhanVien.TabIndex = 1;
            this.cboLoaiNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboLoaiNhanVien_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "* Loại nhân viên:";
            // 
            // panLoiLoaiNhanVien
            // 
            this.panLoiLoaiNhanVien.Controls.Add(this.lblLoiLoaiNhanVien);
            this.panLoiLoaiNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiLoaiNhanVien.Location = new System.Drawing.Point(0, 360);
            this.panLoiLoaiNhanVien.Name = "panLoiLoaiNhanVien";
            this.panLoiLoaiNhanVien.Size = new System.Drawing.Size(800, 40);
            this.panLoiLoaiNhanVien.TabIndex = 16;
            // 
            // lblLoiLoaiNhanVien
            // 
            this.lblLoiLoaiNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiLoaiNhanVien.AutoSize = true;
            this.lblLoiLoaiNhanVien.ForeColor = System.Drawing.Color.Red;
            this.lblLoiLoaiNhanVien.Location = new System.Drawing.Point(200, 3);
            this.lblLoiLoaiNhanVien.Name = "lblLoiLoaiNhanVien";
            this.lblLoiLoaiNhanVien.Size = new System.Drawing.Size(139, 20);
            this.lblLoiLoaiNhanVien.TabIndex = 0;
            this.lblLoiLoaiNhanVien.Text = "Lỗi loại nhân viên";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnChonAnh);
            this.panel8.Controls.Add(this.picHinhAnhNhanVien);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 400);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(800, 250);
            this.panel8.TabIndex = 17;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChonAnh.Location = new System.Drawing.Point(406, 176);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(194, 50);
            this.btnChonAnh.TabIndex = 2;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picHinhAnhNhanVien
            // 
            this.picHinhAnhNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picHinhAnhNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnhNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHinhAnhNhanVien.Image = global::GUI.Properties.Resources.ZImageDefault;
            this.picHinhAnhNhanVien.Location = new System.Drawing.Point(200, 26);
            this.picHinhAnhNhanVien.Name = "picHinhAnhNhanVien";
            this.picHinhAnhNhanVien.Size = new System.Drawing.Size(200, 200);
            this.picHinhAnhNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnhNhanVien.TabIndex = 1;
            this.picHinhAnhNhanVien.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hình ảnh (png, jpg, jpeg):";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.radKhongConLamViec);
            this.panel9.Controls.Add(this.radConLamViec);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 650);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(800, 84);
            this.panel9.TabIndex = 18;
            // 
            // radKhongConLamViec
            // 
            this.radKhongConLamViec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radKhongConLamViec.AutoSize = true;
            this.radKhongConLamViec.Location = new System.Drawing.Point(200, 54);
            this.radKhongConLamViec.Name = "radKhongConLamViec";
            this.radKhongConLamViec.Size = new System.Drawing.Size(176, 24);
            this.radKhongConLamViec.TabIndex = 2;
            this.radKhongConLamViec.TabStop = true;
            this.radKhongConLamViec.Text = "Không còn làm việc";
            this.radKhongConLamViec.UseVisualStyleBackColor = true;
            this.radKhongConLamViec.CheckedChanged += new System.EventHandler(this.radKhongConLamViec_CheckedChanged);
            // 
            // radConLamViec
            // 
            this.radConLamViec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radConLamViec.AutoSize = true;
            this.radConLamViec.Location = new System.Drawing.Point(200, 26);
            this.radConLamViec.Name = "radConLamViec";
            this.radConLamViec.Size = new System.Drawing.Size(127, 24);
            this.radConLamViec.TabIndex = 1;
            this.radConLamViec.TabStop = true;
            this.radConLamViec.Text = "Còn làm việc";
            this.radConLamViec.UseVisualStyleBackColor = true;
            this.radConLamViec.CheckedChanged += new System.EventHandler(this.radConLamViec_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "* Trạng thái:";
            // 
            // panLoiTrangThai
            // 
            this.panLoiTrangThai.Controls.Add(this.lblLoiTrangThai);
            this.panLoiTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiTrangThai.Location = new System.Drawing.Point(0, 734);
            this.panLoiTrangThai.Name = "panLoiTrangThai";
            this.panLoiTrangThai.Size = new System.Drawing.Size(800, 40);
            this.panLoiTrangThai.TabIndex = 19;
            // 
            // lblLoiTrangThai
            // 
            this.lblLoiTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiTrangThai.AutoSize = true;
            this.lblLoiTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lblLoiTrangThai.Location = new System.Drawing.Point(200, 3);
            this.lblLoiTrangThai.Name = "lblLoiTrangThai";
            this.lblLoiTrangThai.Size = new System.Drawing.Size(107, 20);
            this.lblLoiTrangThai.TabIndex = 0;
            this.lblLoiTrangThai.Text = "Lỗi trạng thái";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnHuy);
            this.panel11.Controls.Add(this.btnLuu);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 774);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(800, 130);
            this.panel11.TabIndex = 20;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(200, 68);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(400, 50);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(200, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(400, 50);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FormThemSuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 953);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panLoiTrangThai);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panLoiLoaiNhanVien);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panLoiHoVaTen);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panLoiTenDangNhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThemSuaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemSuaNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormThemSuaNhanVien_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panLoiTenDangNhap.ResumeLayout(false);
            this.panLoiTenDangNhap.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panLoiHoVaTen.ResumeLayout(false);
            this.panLoiHoVaTen.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panLoiLoaiNhanVien.ResumeLayout(false);
            this.panLoiLoaiNhanVien.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnhNhanVien)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panLoiTrangThai.ResumeLayout(false);
            this.panLoiTrangThai.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panLoiTenDangNhap;
        private System.Windows.Forms.Label lblLoiTenDangNhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panLoiHoVaTen;
        private System.Windows.Forms.Label lblLoiHoVaTen;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cboLoaiNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panLoiLoaiNhanVien;
        private System.Windows.Forms.Label lblLoiLoaiNhanVien;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.PictureBox picHinhAnhNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton radKhongConLamViec;
        private System.Windows.Forms.RadioButton radConLamViec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panLoiTrangThai;
        private System.Windows.Forms.Label lblLoiTrangThai;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}