namespace GUI.FormLevel1
{
    partial class Form1DichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1DichVu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnLoaiDichVu = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 4;
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panMenu.Controls.Add(this.btnLoaiDichVu);
            this.panMenu.Controls.Add(this.btnDichVu);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.Location = new System.Drawing.Point(0, 5);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(1000, 50);
            this.panMenu.TabIndex = 5;
            // 
            // btnLoaiDichVu
            // 
            this.btnLoaiDichVu.AutoSize = true;
            this.btnLoaiDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiDichVu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoaiDichVu.FlatAppearance.BorderSize = 0;
            this.btnLoaiDichVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnLoaiDichVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLoaiDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiDichVu.ForeColor = System.Drawing.Color.White;
            this.btnLoaiDichVu.Location = new System.Drawing.Point(83, 0);
            this.btnLoaiDichVu.Name = "btnLoaiDichVu";
            this.btnLoaiDichVu.Size = new System.Drawing.Size(121, 50);
            this.btnLoaiDichVu.TabIndex = 16;
            this.btnLoaiDichVu.Text = "Loại dịch vụ";
            this.btnLoaiDichVu.UseVisualStyleBackColor = true;
            this.btnLoaiDichVu.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.AutoSize = true;
            this.btnDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDichVu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDichVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.ForeColor = System.Drawing.Color.White;
            this.btnDichVu.Location = new System.Drawing.Point(0, 0);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(83, 50);
            this.btnDichVu.TabIndex = 15;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // panChinh
            // 
            this.panChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panChinh.Location = new System.Drawing.Point(0, 55);
            this.panChinh.Name = "panChinh";
            this.panChinh.Size = new System.Drawing.Size(1000, 507);
            this.panChinh.TabIndex = 6;
            // 
            // Form1DichVu
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
            this.Name = "Form1DichVu";
            this.Text = "Form1DichVu";
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnLoaiDichVu;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Panel panChinh;
    }
}