namespace GUI.FormThemSua
{
    partial class FormThemSuaLoaiBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemSuaLoaiBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaLoaiBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenLoaiBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panLoiTenLoaiBan = new System.Windows.Forms.Panel();
            this.lblLoiTenLoaiBan = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panLoiTenLoaiBan.SuspendLayout();
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
            this.panel1.TabIndex = 4;
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
            this.panel4.Controls.Add(this.txtMaLoaiBan);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 60);
            this.panel4.TabIndex = 12;
            // 
            // txtMaLoaiBan
            // 
            this.txtMaLoaiBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaLoaiBan.Location = new System.Drawing.Point(200, 26);
            this.txtMaLoaiBan.Name = "txtMaLoaiBan";
            this.txtMaLoaiBan.ReadOnly = true;
            this.txtMaLoaiBan.Size = new System.Drawing.Size(400, 27);
            this.txtMaLoaiBan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "* Mã loại bàn:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTenLoaiBan);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 60);
            this.panel3.TabIndex = 15;
            // 
            // txtTenLoaiBan
            // 
            this.txtTenLoaiBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenLoaiBan.Location = new System.Drawing.Point(200, 26);
            this.txtTenLoaiBan.Name = "txtTenLoaiBan";
            this.txtTenLoaiBan.Size = new System.Drawing.Size(400, 27);
            this.txtTenLoaiBan.TabIndex = 1;
            this.txtTenLoaiBan.TextChanged += new System.EventHandler(this.txtTenLoaiBan_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "* Tên loại bàn:";
            // 
            // panLoiTenLoaiBan
            // 
            this.panLoiTenLoaiBan.Controls.Add(this.lblLoiTenLoaiBan);
            this.panLoiTenLoaiBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLoiTenLoaiBan.Location = new System.Drawing.Point(0, 220);
            this.panLoiTenLoaiBan.Name = "panLoiTenLoaiBan";
            this.panLoiTenLoaiBan.Size = new System.Drawing.Size(800, 40);
            this.panLoiTenLoaiBan.TabIndex = 16;
            // 
            // lblLoiTenLoaiBan
            // 
            this.lblLoiTenLoaiBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoiTenLoaiBan.AutoSize = true;
            this.lblLoiTenLoaiBan.ForeColor = System.Drawing.Color.Red;
            this.lblLoiTenLoaiBan.Location = new System.Drawing.Point(200, 3);
            this.lblLoiTenLoaiBan.Name = "lblLoiTenLoaiBan";
            this.lblLoiTenLoaiBan.Size = new System.Drawing.Size(123, 20);
            this.lblLoiTenLoaiBan.TabIndex = 0;
            this.lblLoiTenLoaiBan.Text = "Lỗi tên loại bàn";
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
            // FormThemSuaLoaiBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panLoiTenLoaiBan);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThemSuaLoaiBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemSuaLoaiBan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormThemSuaLoaiBan_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panLoiTenLoaiBan.ResumeLayout(false);
            this.panLoiTenLoaiBan.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMaLoaiBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenLoaiBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panLoiTenLoaiBan;
        private System.Windows.Forms.Label lblLoiTenLoaiBan;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}