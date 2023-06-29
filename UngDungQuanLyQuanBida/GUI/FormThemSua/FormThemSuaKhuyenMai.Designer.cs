namespace GUI.FormThemSua
{
    partial class FormThemSuaKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemSuaKhuyenMai));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panLoiNgay = new System.Windows.Forms.Panel();
            this.lblLoiNgay = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panLoiMoTa = new System.Windows.Forms.Panel();
            this.lblLoiMoTa = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panLoiKhuyenMai = new System.Windows.Forms.Panel();
            this.lblLoiKhuyenMai = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panLoiNgay.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panLoiMoTa.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panLoiKhuyenMai.SuspendLayout();
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
            this.panel4.Controls.Add(this.dtpNgay);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 60);
            this.panel4.TabIndex = 11;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(204, 26);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(396, 27);
            this.dtpNgay.TabIndex = 1;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "* Ngày:";
            // 
            // panLoiNgay
            // 
            this.panLoiNgay.Controls.Add(this.lblLoiNgay);
            this.panLoiNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiNgay.Location = new System.Drawing.Point(0, 160);
            this.panLoiNgay.Name = "panLoiNgay";
            this.panLoiNgay.Size = new System.Drawing.Size(800, 40);
            this.panLoiNgay.TabIndex = 12;
            // 
            // lblLoiNgay
            // 
            this.lblLoiNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiNgay.AutoSize = true;
            this.lblLoiNgay.ForeColor = System.Drawing.Color.Red;
            this.lblLoiNgay.Location = new System.Drawing.Point(200, 3);
            this.lblLoiNgay.Name = "lblLoiNgay";
            this.lblLoiNgay.Size = new System.Drawing.Size(72, 20);
            this.lblLoiNgay.TabIndex = 0;
            this.lblLoiNgay.Text = "Lỗi ngày";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMoTa);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 100);
            this.panel3.TabIndex = 13;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMoTa.Location = new System.Drawing.Point(200, 26);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(400, 67);
            this.txtMoTa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Mô tả:";
            // 
            // panLoiMoTa
            // 
            this.panLoiMoTa.Controls.Add(this.lblLoiMoTa);
            this.panLoiMoTa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiMoTa.Location = new System.Drawing.Point(0, 300);
            this.panLoiMoTa.Name = "panLoiMoTa";
            this.panLoiMoTa.Size = new System.Drawing.Size(800, 40);
            this.panLoiMoTa.TabIndex = 14;
            // 
            // lblLoiMoTa
            // 
            this.lblLoiMoTa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiMoTa.AutoSize = true;
            this.lblLoiMoTa.ForeColor = System.Drawing.Color.Red;
            this.lblLoiMoTa.Location = new System.Drawing.Point(200, 3);
            this.lblLoiMoTa.Name = "lblLoiMoTa";
            this.lblLoiMoTa.Size = new System.Drawing.Size(79, 20);
            this.lblLoiMoTa.TabIndex = 0;
            this.lblLoiMoTa.Text = "Lỗi mô tả";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtKhuyenMai);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 340);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 60);
            this.panel6.TabIndex = 16;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKhuyenMai.Location = new System.Drawing.Point(200, 26);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(400, 27);
            this.txtKhuyenMai.TabIndex = 1;
            this.txtKhuyenMai.TextChanged += new System.EventHandler(this.txtKhuyenMai_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "* Khuyến mãi (%):";
            // 
            // panLoiKhuyenMai
            // 
            this.panLoiKhuyenMai.Controls.Add(this.lblLoiKhuyenMai);
            this.panLoiKhuyenMai.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiKhuyenMai.Location = new System.Drawing.Point(0, 400);
            this.panLoiKhuyenMai.Name = "panLoiKhuyenMai";
            this.panLoiKhuyenMai.Size = new System.Drawing.Size(800, 40);
            this.panLoiKhuyenMai.TabIndex = 17;
            // 
            // lblLoiKhuyenMai
            // 
            this.lblLoiKhuyenMai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiKhuyenMai.AutoSize = true;
            this.lblLoiKhuyenMai.ForeColor = System.Drawing.Color.Red;
            this.lblLoiKhuyenMai.Location = new System.Drawing.Point(200, 3);
            this.lblLoiKhuyenMai.Name = "lblLoiKhuyenMai";
            this.lblLoiKhuyenMai.Size = new System.Drawing.Size(121, 20);
            this.lblLoiKhuyenMai.TabIndex = 0;
            this.lblLoiKhuyenMai.Text = "Lỗi khuyến mãi";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnHuy);
            this.panel8.Controls.Add(this.btnLuu);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 440);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(800, 130);
            this.panel8.TabIndex = 18;
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
            // FormThemSuaKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panLoiKhuyenMai);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panLoiMoTa);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panLoiNgay);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormThemSuaKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemSuaKhuyenMai";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormThemSuaKhuyenMai_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panLoiNgay.ResumeLayout(false);
            this.panLoiNgay.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panLoiMoTa.ResumeLayout(false);
            this.panLoiMoTa.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panLoiKhuyenMai.ResumeLayout(false);
            this.panLoiKhuyenMai.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panLoiNgay;
        private System.Windows.Forms.Label lblLoiNgay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panLoiMoTa;
        private System.Windows.Forms.Label lblLoiMoTa;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panLoiKhuyenMai;
        private System.Windows.Forms.Label lblLoiKhuyenMai;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}