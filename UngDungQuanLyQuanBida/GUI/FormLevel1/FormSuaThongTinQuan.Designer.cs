namespace GUI.FormLevel1
{
    partial class FormSuaThongTinQuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuaThongTinQuan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTenQuan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panLoiTenQuan = new System.Windows.Forms.Panel();
            this.lblLoiTenQuan = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panLoiDiaChi = new System.Windows.Forms.Panel();
            this.lblLoiDiaChi = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panLoiSoDienThoai = new System.Windows.Forms.Panel();
            this.lblLoiSoDienThoai = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.panel4.SuspendLayout();
            this.panLoiTenQuan.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panLoiDiaChi.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panLoiSoDienThoai.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.panel2.Controls.Add(this.btnChonAnh);
            this.panel2.Controls.Add(this.picHinhAnh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 250);
            this.panel2.TabIndex = 9;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChonAnh.Location = new System.Drawing.Point(406, 176);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(194, 50);
            this.btnChonAnh.TabIndex = 3;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hình ảnh (png, jpg, jpeg):";
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHinhAnh.Image = global::GUI.Properties.Resources.ZImageDefault;
            this.picHinhAnh.Location = new System.Drawing.Point(200, 26);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(200, 200);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 1;
            this.picHinhAnh.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTenQuan);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 60);
            this.panel4.TabIndex = 10;
            // 
            // txtTenQuan
            // 
            this.txtTenQuan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenQuan.Location = new System.Drawing.Point(200, 26);
            this.txtTenQuan.Name = "txtTenQuan";
            this.txtTenQuan.Size = new System.Drawing.Size(400, 27);
            this.txtTenQuan.TabIndex = 1;
            this.txtTenQuan.TextChanged += new System.EventHandler(this.txtTenQuan_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "* Tên quán:";
            // 
            // panLoiTenQuan
            // 
            this.panLoiTenQuan.Controls.Add(this.lblLoiTenQuan);
            this.panLoiTenQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiTenQuan.Location = new System.Drawing.Point(0, 410);
            this.panLoiTenQuan.Name = "panLoiTenQuan";
            this.panLoiTenQuan.Size = new System.Drawing.Size(800, 40);
            this.panLoiTenQuan.TabIndex = 11;
            // 
            // lblLoiTenQuan
            // 
            this.lblLoiTenQuan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiTenQuan.AutoSize = true;
            this.lblLoiTenQuan.ForeColor = System.Drawing.Color.Red;
            this.lblLoiTenQuan.Location = new System.Drawing.Point(200, 3);
            this.lblLoiTenQuan.Name = "lblLoiTenQuan";
            this.lblLoiTenQuan.Size = new System.Drawing.Size(101, 20);
            this.lblLoiTenQuan.TabIndex = 0;
            this.lblLoiTenQuan.Text = "Lỗi tên quán";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDiaChi);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 100);
            this.panel3.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.Location = new System.Drawing.Point(200, 26);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(400, 67);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Địa chỉ:";
            // 
            // panLoiDiaChi
            // 
            this.panLoiDiaChi.Controls.Add(this.lblLoiDiaChi);
            this.panLoiDiaChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiDiaChi.Location = new System.Drawing.Point(0, 550);
            this.panLoiDiaChi.Name = "panLoiDiaChi";
            this.panLoiDiaChi.Size = new System.Drawing.Size(800, 40);
            this.panLoiDiaChi.TabIndex = 13;
            // 
            // lblLoiDiaChi
            // 
            this.lblLoiDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiDiaChi.AutoSize = true;
            this.lblLoiDiaChi.ForeColor = System.Drawing.Color.Red;
            this.lblLoiDiaChi.Location = new System.Drawing.Point(200, 3);
            this.lblLoiDiaChi.Name = "lblLoiDiaChi";
            this.lblLoiDiaChi.Size = new System.Drawing.Size(86, 20);
            this.lblLoiDiaChi.TabIndex = 0;
            this.lblLoiDiaChi.Text = "Lỗi địa chỉ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSoDienThoai);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 590);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 60);
            this.panel6.TabIndex = 14;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoDienThoai.Location = new System.Drawing.Point(200, 26);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(400, 27);
            this.txtSoDienThoai.TabIndex = 1;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSoDienThoai_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "* Số điện thoại:";
            // 
            // panLoiSoDienThoai
            // 
            this.panLoiSoDienThoai.Controls.Add(this.lblLoiSoDienThoai);
            this.panLoiSoDienThoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiSoDienThoai.Location = new System.Drawing.Point(0, 650);
            this.panLoiSoDienThoai.Name = "panLoiSoDienThoai";
            this.panLoiSoDienThoai.Size = new System.Drawing.Size(800, 40);
            this.panLoiSoDienThoai.TabIndex = 15;
            // 
            // lblLoiSoDienThoai
            // 
            this.lblLoiSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiSoDienThoai.AutoSize = true;
            this.lblLoiSoDienThoai.ForeColor = System.Drawing.Color.Red;
            this.lblLoiSoDienThoai.Location = new System.Drawing.Point(200, 3);
            this.lblLoiSoDienThoai.Name = "lblLoiSoDienThoai";
            this.lblLoiSoDienThoai.Size = new System.Drawing.Size(132, 20);
            this.lblLoiSoDienThoai.TabIndex = 0;
            this.lblLoiSoDienThoai.Text = "Lỗi số điện thoại";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnHuy);
            this.panel8.Controls.Add(this.btnLuu);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 690);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(800, 130);
            this.panel8.TabIndex = 16;
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
            // FormSuaThongTinQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 853);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panLoiSoDienThoai);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panLoiDiaChi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panLoiTenQuan);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSuaThongTinQuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSuaThongTinQuan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSuaThongTinQuan_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panLoiTenQuan.ResumeLayout(false);
            this.panLoiTenQuan.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panLoiDiaChi.ResumeLayout(false);
            this.panLoiDiaChi.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panLoiSoDienThoai.ResumeLayout(false);
            this.panLoiSoDienThoai.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTenQuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panLoiTenQuan;
        private System.Windows.Forms.Label lblLoiTenQuan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panLoiDiaChi;
        private System.Windows.Forms.Label lblLoiDiaChi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panLoiSoDienThoai;
        private System.Windows.Forms.Label lblLoiSoDienThoai;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}