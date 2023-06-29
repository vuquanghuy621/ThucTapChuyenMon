namespace GUI.FormThemSua
{
    partial class FormDoiTenDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiTenDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTenDangNhapMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panLoiTenDangNhapMoi = new System.Windows.Forms.Panel();
            this.lblLoiTenDangNhapMoi = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnHienMatKhau = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panLoiMatKhau = new System.Windows.Forms.Panel();
            this.lblLoiMatKhau = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panLoiTenDangNhapMoi.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panLoiMatKhau.SuspendLayout();
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
            this.panel1.TabIndex = 3;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTenDangNhapMoi);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 60);
            this.panel4.TabIndex = 11;
            // 
            // txtTenDangNhapMoi
            // 
            this.txtTenDangNhapMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDangNhapMoi.Location = new System.Drawing.Point(200, 26);
            this.txtTenDangNhapMoi.Name = "txtTenDangNhapMoi";
            this.txtTenDangNhapMoi.Size = new System.Drawing.Size(400, 27);
            this.txtTenDangNhapMoi.TabIndex = 1;
            this.txtTenDangNhapMoi.TextChanged += new System.EventHandler(this.txtTenDangNhapMoi_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "* Tên đăng nhập mới:";
            // 
            // panLoiTenDangNhapMoi
            // 
            this.panLoiTenDangNhapMoi.Controls.Add(this.lblLoiTenDangNhapMoi);
            this.panLoiTenDangNhapMoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiTenDangNhapMoi.Location = new System.Drawing.Point(0, 160);
            this.panLoiTenDangNhapMoi.Name = "panLoiTenDangNhapMoi";
            this.panLoiTenDangNhapMoi.Size = new System.Drawing.Size(800, 40);
            this.panLoiTenDangNhapMoi.TabIndex = 12;
            // 
            // lblLoiTenDangNhapMoi
            // 
            this.lblLoiTenDangNhapMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiTenDangNhapMoi.AutoSize = true;
            this.lblLoiTenDangNhapMoi.ForeColor = System.Drawing.Color.Red;
            this.lblLoiTenDangNhapMoi.Location = new System.Drawing.Point(200, 3);
            this.lblLoiTenDangNhapMoi.Name = "lblLoiTenDangNhapMoi";
            this.lblLoiTenDangNhapMoi.Size = new System.Drawing.Size(174, 20);
            this.lblLoiTenDangNhapMoi.TabIndex = 0;
            this.lblLoiTenDangNhapMoi.Text = "Lỗi tên đăng nhập mới";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnHienMatKhau);
            this.panel6.Controls.Add(this.txtMatKhau);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 60);
            this.panel6.TabIndex = 13;
            // 
            // btnHienMatKhau
            // 
            this.btnHienMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHienMatKhau.Image = global::GUI.Properties.Resources.Show_24;
            this.btnHienMatKhau.Location = new System.Drawing.Point(570, 24);
            this.btnHienMatKhau.Name = "btnHienMatKhau";
            this.btnHienMatKhau.Size = new System.Drawing.Size(30, 30);
            this.btnHienMatKhau.TabIndex = 2;
            this.btnHienMatKhau.UseVisualStyleBackColor = true;
            this.btnHienMatKhau.Click += new System.EventHandler(this.btnHienMatKhau_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatKhau.Location = new System.Drawing.Point(200, 26);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(364, 27);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "* Mật khẩu:";
            // 
            // panLoiMatKhau
            // 
            this.panLoiMatKhau.Controls.Add(this.lblLoiMatKhau);
            this.panLoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiMatKhau.Location = new System.Drawing.Point(0, 260);
            this.panLoiMatKhau.Name = "panLoiMatKhau";
            this.panLoiMatKhau.Size = new System.Drawing.Size(800, 40);
            this.panLoiMatKhau.TabIndex = 14;
            // 
            // lblLoiMatKhau
            // 
            this.lblLoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiMatKhau.AutoSize = true;
            this.lblLoiMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblLoiMatKhau.Location = new System.Drawing.Point(200, 3);
            this.lblLoiMatKhau.Name = "lblLoiMatKhau";
            this.lblLoiMatKhau.Size = new System.Drawing.Size(105, 20);
            this.lblLoiMatKhau.TabIndex = 0;
            this.lblLoiMatKhau.Text = "Lỗi mật khẩu";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnHuy);
            this.panel8.Controls.Add(this.btnLuu);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 300);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(800, 130);
            this.panel8.TabIndex = 17;
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
            // FormDoiTenDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panLoiMatKhau);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panLoiTenDangNhapMoi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDoiTenDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoiTenDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDoiTenDangNhap_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panLoiTenDangNhapMoi.ResumeLayout(false);
            this.panLoiTenDangNhapMoi.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panLoiMatKhau.ResumeLayout(false);
            this.panLoiMatKhau.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTenDangNhapMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panLoiTenDangNhapMoi;
        private System.Windows.Forms.Label lblLoiTenDangNhapMoi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnHienMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panLoiMatKhau;
        private System.Windows.Forms.Label lblLoiMatKhau;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}