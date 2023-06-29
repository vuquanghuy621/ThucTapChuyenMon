namespace GUI.FormLevel1
{
    partial class Form1KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1KhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnHangKhachHang = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.panChinh = new System.Windows.Forms.Panel();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 5);
            this.panel1.TabIndex = 1;
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panMenu.Controls.Add(this.btnHangKhachHang);
            this.panMenu.Controls.Add(this.btnKhachHang);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.Location = new System.Drawing.Point(0, 5);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(1000, 50);
            this.panMenu.TabIndex = 2;
            // 
            // btnHangKhachHang
            // 
            this.btnHangKhachHang.AutoSize = true;
            this.btnHangKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHangKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHangKhachHang.FlatAppearance.BorderSize = 0;
            this.btnHangKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnHangKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnHangKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnHangKhachHang.Location = new System.Drawing.Point(117, 0);
            this.btnHangKhachHang.Name = "btnHangKhachHang";
            this.btnHangKhachHang.Size = new System.Drawing.Size(164, 50);
            this.btnHangKhachHang.TabIndex = 16;
            this.btnHangKhachHang.Text = "Hạng khách hàng";
            this.btnHangKhachHang.UseVisualStyleBackColor = true;
            this.btnHangKhachHang.Click += new System.EventHandler(this.btnChucNang_Click);
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
            this.btnKhachHang.Location = new System.Drawing.Point(0, 0);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(117, 50);
            this.btnKhachHang.TabIndex = 15;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // panChinh
            // 
            this.panChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panChinh.Location = new System.Drawing.Point(0, 55);
            this.panChinh.Name = "panChinh";
            this.panChinh.Size = new System.Drawing.Size(1000, 507);
            this.panChinh.TabIndex = 3;
            // 
            // Form1KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.panChinh);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1KhachHang";
            this.Text = "Form1KhachHang";
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnHangKhachHang;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Panel panChinh;
    }
}