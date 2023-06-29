namespace GUI.FormThemSua
{
    partial class FormChuyenBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuyenBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBanHienTai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cboBanMoi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panLoiBanMoi = new System.Windows.Forms.Panel();
            this.lblLoiBanMoi = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panLoiBanMoi.SuspendLayout();
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
            this.panel1.TabIndex = 5;
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
            this.panel2.Controls.Add(this.txtBanHienTai);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 13;
            // 
            // txtBanHienTai
            // 
            this.txtBanHienTai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBanHienTai.Location = new System.Drawing.Point(200, 26);
            this.txtBanHienTai.Name = "txtBanHienTai";
            this.txtBanHienTai.ReadOnly = true;
            this.txtBanHienTai.Size = new System.Drawing.Size(400, 27);
            this.txtBanHienTai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bàn hiện tại:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cboBanMoi);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 160);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 60);
            this.panel6.TabIndex = 17;
            // 
            // cboBanMoi
            // 
            this.cboBanMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboBanMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanMoi.FormattingEnabled = true;
            this.cboBanMoi.Location = new System.Drawing.Point(200, 26);
            this.cboBanMoi.Name = "cboBanMoi";
            this.cboBanMoi.Size = new System.Drawing.Size(400, 28);
            this.cboBanMoi.TabIndex = 1;
            this.cboBanMoi.SelectedIndexChanged += new System.EventHandler(this.cboBanMoi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "* Bàn mới (đang trống):";
            // 
            // panLoiBanMoi
            // 
            this.panLoiBanMoi.Controls.Add(this.lblLoiBanMoi);
            this.panLoiBanMoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiBanMoi.Location = new System.Drawing.Point(0, 220);
            this.panLoiBanMoi.Name = "panLoiBanMoi";
            this.panLoiBanMoi.Size = new System.Drawing.Size(800, 40);
            this.panLoiBanMoi.TabIndex = 18;
            // 
            // lblLoiBanMoi
            // 
            this.lblLoiBanMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiBanMoi.AutoSize = true;
            this.lblLoiBanMoi.ForeColor = System.Drawing.Color.Red;
            this.lblLoiBanMoi.Location = new System.Drawing.Point(200, 3);
            this.lblLoiBanMoi.Name = "lblLoiBanMoi";
            this.lblLoiBanMoi.Size = new System.Drawing.Size(96, 20);
            this.lblLoiBanMoi.TabIndex = 0;
            this.lblLoiBanMoi.Text = "Lỗi bàn mới";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnHuy);
            this.panel11.Controls.Add(this.btnLuu);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 260);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(800, 130);
            this.panel11.TabIndex = 22;
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
            // FormChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panLoiBanMoi);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChuyenBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChuyenBan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChuyenBan_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panLoiBanMoi.ResumeLayout(false);
            this.panLoiBanMoi.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBanHienTai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cboBanMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panLoiBanMoi;
        private System.Windows.Forms.Label lblLoiBanMoi;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}