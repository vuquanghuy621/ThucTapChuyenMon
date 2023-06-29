namespace GUI.FormLevel1
{
    partial class Form1Sanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Sanh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.cboLoaiBan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTenDanhSach = new System.Windows.Forms.Label();
            this.panBottom = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panDanhSach = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblDoanhThuHomNay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboKhuVuc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnTaiLai);
            this.panel1.Controls.Add(this.cboLoaiBan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 70);
            this.panel1.TabIndex = 2;
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(372, 33);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(300, 28);
            this.cboKhuVuc.TabIndex = 4;
            this.cboKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cboKhuVuc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xem theo khu vực:";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnTaiLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.ForeColor = System.Drawing.Color.White;
            this.btnTaiLai.Image = global::GUI.Properties.Resources.Refresh_24;
            this.btnTaiLai.Location = new System.Drawing.Point(10, 10);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(50, 50);
            this.btnTaiLai.TabIndex = 0;
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // cboLoaiBan
            // 
            this.cboLoaiBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiBan.FormattingEnabled = true;
            this.cboLoaiBan.Location = new System.Drawing.Point(66, 33);
            this.cboLoaiBan.Name = "cboLoaiBan";
            this.cboLoaiBan.Size = new System.Drawing.Size(300, 28);
            this.cboLoaiBan.TabIndex = 2;
            this.cboLoaiBan.SelectedIndexChanged += new System.EventHandler(this.cboLoaiBan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xem theo loại bàn:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTrangThai);
            this.panel2.Controls.Add(this.lblTenDanhSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 60);
            this.panel2.TabIndex = 3;
            // 
            // lblTenDanhSach
            // 
            this.lblTenDanhSach.AutoSize = true;
            this.lblTenDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDanhSach.Location = new System.Drawing.Point(10, 16);
            this.lblTenDanhSach.Name = "lblTenDanhSach";
            this.lblTenDanhSach.Size = new System.Drawing.Size(171, 29);
            this.lblTenDanhSach.TabIndex = 0;
            this.lblTenDanhSach.Text = "Tên danh sách";
            // 
            // panBottom
            // 
            this.panBottom.Controls.Add(this.lblDoanhThuHomNay);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 502);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(1164, 60);
            this.panBottom.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 372);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1154, 130);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 372);
            this.panel5.TabIndex = 8;
            // 
            // panDanhSach
            // 
            this.panDanhSach.AutoScroll = true;
            this.panDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDanhSach.Location = new System.Drawing.Point(10, 130);
            this.panDanhSach.Name = "panDanhSach";
            this.panDanhSach.Size = new System.Drawing.Size(1144, 372);
            this.panDanhSach.TabIndex = 9;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(452, 16);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(700, 29);
            this.lblTrangThai.TabIndex = 1;
            this.lblTrangThai.Text = "Trạng thái";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDoanhThuHomNay
            // 
            this.lblDoanhThuHomNay.AutoSize = true;
            this.lblDoanhThuHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuHomNay.ForeColor = System.Drawing.Color.Red;
            this.lblDoanhThuHomNay.Location = new System.Drawing.Point(10, 16);
            this.lblDoanhThuHomNay.Name = "lblDoanhThuHomNay";
            this.lblDoanhThuHomNay.Size = new System.Drawing.Size(217, 29);
            this.lblDoanhThuHomNay.TabIndex = 5;
            this.lblDoanhThuHomNay.Text = "Doanh thu hôm nay";
            this.lblDoanhThuHomNay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1Sanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 562);
            this.Controls.Add(this.panDanhSach);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1Sanh";
            this.Text = "Form1Sanh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.ComboBox cboLoaiBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTenDanhSach;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel panDanhSach;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblDoanhThuHomNay;
    }
}