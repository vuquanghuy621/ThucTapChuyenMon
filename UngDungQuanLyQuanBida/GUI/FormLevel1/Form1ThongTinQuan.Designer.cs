namespace GUI.FormLevel1
{
    partial class Form1ThongTinQuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1ThongTinQuan));
            this.btnSua = new System.Windows.Forms.Button();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.lblThongTinQuan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(22, 246);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(956, 50);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa thông tin quán";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Image = global::GUI.Properties.Resources.ZImageDefault;
            this.picHinhAnh.Location = new System.Drawing.Point(22, 40);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(200, 200);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 15;
            this.picHinhAnh.TabStop = false;
            // 
            // lblThongTinQuan
            // 
            this.lblThongTinQuan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThongTinQuan.Location = new System.Drawing.Point(228, 40);
            this.lblThongTinQuan.Name = "lblThongTinQuan";
            this.lblThongTinQuan.Size = new System.Drawing.Size(750, 200);
            this.lblThongTinQuan.TabIndex = 0;
            this.lblThongTinQuan.Text = "Thông tin quán";
            this.lblThongTinQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1ThongTinQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.lblThongTinQuan);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.picHinhAnh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1ThongTinQuan";
            this.Text = "Form1ThongTinQuan";
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Label lblThongTinQuan;
    }
}