namespace GUI.MyUserControl
{
    partial class UcBan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblThongTinBan = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThongTinBan
            // 
            this.lblThongTinBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblThongTinBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongTinBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinBan.Location = new System.Drawing.Point(0, 0);
            this.lblThongTinBan.Name = "lblThongTinBan";
            this.lblThongTinBan.Size = new System.Drawing.Size(350, 30);
            this.lblThongTinBan.TabIndex = 1;
            this.lblThongTinBan.Text = "Thông tin bàn";
            this.lblThongTinBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblThongTinBan.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.lblThongTinBan.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // lblGia
            // 
            this.lblGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(0, 118);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(350, 30);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGia.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.lblGia.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // lblTenBan
            // 
            this.lblTenBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTenBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBan.Location = new System.Drawing.Point(0, 30);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(350, 88);
            this.lblTenBan.TabIndex = 3;
            this.lblTenBan.Text = "Tên bàn";
            this.lblTenBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTenBan.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.lblTenBan.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // UcBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTenBan);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblThongTinBan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcBan";
            this.Size = new System.Drawing.Size(350, 148);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblThongTinBan;
        internal System.Windows.Forms.Label lblGia;
        internal System.Windows.Forms.Label lblTenBan;
    }
}
