namespace GUI.FormLevel1
{
    partial class Form1Ban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Ban));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnKhuVuc = new System.Windows.Forms.Button();
            this.btnLoaiBan = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 2;
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panMenu.Controls.Add(this.btnKhuVuc);
            this.panMenu.Controls.Add(this.btnLoaiBan);
            this.panMenu.Controls.Add(this.btnBan);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.Location = new System.Drawing.Point(0, 5);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(1000, 50);
            this.panMenu.TabIndex = 3;
            // 
            // btnKhuVuc
            // 
            this.btnKhuVuc.AutoSize = true;
            this.btnKhuVuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhuVuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKhuVuc.FlatAppearance.BorderSize = 0;
            this.btnKhuVuc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnKhuVuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnKhuVuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhuVuc.ForeColor = System.Drawing.Color.White;
            this.btnKhuVuc.Location = new System.Drawing.Point(143, 0);
            this.btnKhuVuc.Name = "btnKhuVuc";
            this.btnKhuVuc.Size = new System.Drawing.Size(86, 50);
            this.btnKhuVuc.TabIndex = 17;
            this.btnKhuVuc.Text = "Khu vực";
            this.btnKhuVuc.UseVisualStyleBackColor = true;
            this.btnKhuVuc.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnLoaiBan
            // 
            this.btnLoaiBan.AutoSize = true;
            this.btnLoaiBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoaiBan.FlatAppearance.BorderSize = 0;
            this.btnLoaiBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnLoaiBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLoaiBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiBan.ForeColor = System.Drawing.Color.White;
            this.btnLoaiBan.Location = new System.Drawing.Point(52, 0);
            this.btnLoaiBan.Name = "btnLoaiBan";
            this.btnLoaiBan.Size = new System.Drawing.Size(91, 50);
            this.btnLoaiBan.TabIndex = 16;
            this.btnLoaiBan.Text = "Loại bàn";
            this.btnLoaiBan.UseVisualStyleBackColor = true;
            this.btnLoaiBan.Click += new System.EventHandler(this.btnChucNang_Click);
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
            this.btnBan.Location = new System.Drawing.Point(0, 0);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(52, 50);
            this.btnBan.TabIndex = 15;
            this.btnBan.Text = "Bàn";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // panChinh
            // 
            this.panChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panChinh.Location = new System.Drawing.Point(0, 55);
            this.panChinh.Name = "panChinh";
            this.panChinh.Size = new System.Drawing.Size(1000, 507);
            this.panChinh.TabIndex = 4;
            // 
            // Form1Ban
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
            this.Name = "Form1Ban";
            this.Text = "Form1Ban";
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnKhuVuc;
        private System.Windows.Forms.Button btnLoaiBan;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Panel panChinh;
    }
}