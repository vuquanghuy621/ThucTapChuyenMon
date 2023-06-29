namespace GUI
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.panLoiMatKhau = new System.Windows.Forms.Panel();
            this.lblLoiMatKhau = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnHienMatKhau = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panLoiTenDangNhap = new System.Windows.Forms.Panel();
            this.lblLoiTenDangNhap = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblThongTinQuan = new System.Windows.Forms.Label();
            this.picHinhAnhQuan = new System.Windows.Forms.PictureBox();
            this.lblTenQuan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panLoiMatKhau.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panLoiTenDangNhap.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnhQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panLoiMatKhau);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panLoiTenDangNhap);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(482, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 653);
            this.panel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnDangNhap);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 500);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(700, 70);
            this.panel8.TabIndex = 7;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(150, 10);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(400, 50);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // panLoiMatKhau
            // 
            this.panLoiMatKhau.Controls.Add(this.lblLoiMatKhau);
            this.panLoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiMatKhau.Location = new System.Drawing.Point(0, 460);
            this.panLoiMatKhau.Name = "panLoiMatKhau";
            this.panLoiMatKhau.Size = new System.Drawing.Size(700, 40);
            this.panLoiMatKhau.TabIndex = 6;
            // 
            // lblLoiMatKhau
            // 
            this.lblLoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiMatKhau.AutoSize = true;
            this.lblLoiMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblLoiMatKhau.Location = new System.Drawing.Point(150, 3);
            this.lblLoiMatKhau.Name = "lblLoiMatKhau";
            this.lblLoiMatKhau.Size = new System.Drawing.Size(105, 20);
            this.lblLoiMatKhau.TabIndex = 0;
            this.lblLoiMatKhau.Text = "Lỗi mật khẩu";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnHienMatKhau);
            this.panel6.Controls.Add(this.txtMatKhau);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 400);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(700, 60);
            this.panel6.TabIndex = 5;
            // 
            // btnHienMatKhau
            // 
            this.btnHienMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHienMatKhau.Image = global::GUI.Properties.Resources.Show_24;
            this.btnHienMatKhau.Location = new System.Drawing.Point(520, 24);
            this.btnHienMatKhau.Name = "btnHienMatKhau";
            this.btnHienMatKhau.Size = new System.Drawing.Size(30, 30);
            this.btnHienMatKhau.TabIndex = 2;
            this.btnHienMatKhau.UseVisualStyleBackColor = true;
            this.btnHienMatKhau.Click += new System.EventHandler(this.btnHienMatKhau_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatKhau.Location = new System.Drawing.Point(150, 26);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(364, 27);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "* Mật khẩu:";
            // 
            // panLoiTenDangNhap
            // 
            this.panLoiTenDangNhap.Controls.Add(this.lblLoiTenDangNhap);
            this.panLoiTenDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiTenDangNhap.Location = new System.Drawing.Point(0, 360);
            this.panLoiTenDangNhap.Name = "panLoiTenDangNhap";
            this.panLoiTenDangNhap.Size = new System.Drawing.Size(700, 40);
            this.panLoiTenDangNhap.TabIndex = 4;
            // 
            // lblLoiTenDangNhap
            // 
            this.lblLoiTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiTenDangNhap.AutoSize = true;
            this.lblLoiTenDangNhap.ForeColor = System.Drawing.Color.Red;
            this.lblLoiTenDangNhap.Location = new System.Drawing.Point(150, 3);
            this.lblLoiTenDangNhap.Name = "lblLoiTenDangNhap";
            this.lblLoiTenDangNhap.Size = new System.Drawing.Size(142, 20);
            this.lblLoiTenDangNhap.TabIndex = 0;
            this.lblLoiTenDangNhap.Text = "Lỗi tên đăng nhập";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTenDangNhap);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 60);
            this.panel4.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDangNhap.Location = new System.Drawing.Point(150, 26);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(400, 27);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "* Tên đăng nhập:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 100);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trước tiên bạn hãy đăng nhập!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblThongTinQuan);
            this.panel2.Controls.Add(this.picHinhAnhQuan);
            this.panel2.Controls.Add(this.lblTenQuan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 200);
            this.panel2.TabIndex = 1;
            // 
            // lblThongTinQuan
            // 
            this.lblThongTinQuan.Location = new System.Drawing.Point(13, 100);
            this.lblThongTinQuan.Name = "lblThongTinQuan";
            this.lblThongTinQuan.Size = new System.Drawing.Size(672, 80);
            this.lblThongTinQuan.TabIndex = 2;
            this.lblThongTinQuan.Text = "Thông tin quán";
            // 
            // picHinhAnhQuan
            // 
            this.picHinhAnhQuan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picHinhAnhQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnhQuan.Image = global::GUI.Properties.Resources.ZImageDefault;
            this.picHinhAnhQuan.Location = new System.Drawing.Point(13, 21);
            this.picHinhAnhQuan.Name = "picHinhAnhQuan";
            this.picHinhAnhQuan.Size = new System.Drawing.Size(70, 70);
            this.picHinhAnhQuan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnhQuan.TabIndex = 1;
            this.picHinhAnhQuan.TabStop = false;
            // 
            // lblTenQuan
            // 
            this.lblTenQuan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenQuan.Location = new System.Drawing.Point(89, 31);
            this.lblTenQuan.Name = "lblTenQuan";
            this.lblTenQuan.Size = new System.Drawing.Size(598, 50);
            this.lblTenQuan.TabIndex = 0;
            this.lblTenQuan.Text = "Tên quán";
            this.lblTenQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.ZBackgroundImage;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDangNhap_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panLoiMatKhau.ResumeLayout(false);
            this.panLoiMatKhau.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panLoiTenDangNhap.ResumeLayout(false);
            this.panLoiTenDangNhap.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnhQuan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Panel panLoiMatKhau;
        private System.Windows.Forms.Label lblLoiMatKhau;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnHienMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panLoiTenDangNhap;
        private System.Windows.Forms.Label lblLoiTenDangNhap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblThongTinQuan;
        private System.Windows.Forms.PictureBox picHinhAnhQuan;
        private System.Windows.Forms.Label lblTenQuan;
    }
}