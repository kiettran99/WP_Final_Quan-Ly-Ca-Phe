namespace QuanLyCaPhe
{
    partial class FormManHinhChinh
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThanhPho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinỨngDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinỨngDụngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nudThemmon = new System.Windows.Forms.NumericUpDown();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.nudgiamgia = new System.Windows.Forms.NumericUpDown();
            this.cmbdanhmucmonan = new System.Windows.Forms.ComboBox();
            this.cmbmonan = new System.Windows.Forms.ComboBox();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThemmon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudgiamgia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.quảnLýToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(752, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDangNhap,
            this.toolStripSeparator1,
            this.menuThoat});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 22);
            this.toolStripMenuItem1.Text = "Hệ thống";
            // 
            // menuDangNhap
            // 
            this.menuDangNhap.Name = "menuDangNhap";
            this.menuDangNhap.Size = new System.Drawing.Size(180, 22);
            this.menuDangNhap.Text = "Đăng nhập  Alt + X";
            this.menuDangNhap.Click += new System.EventHandler(this.menuDangNhap_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(180, 22);
            this.menuThoat.Text = "Thoát           Alt + Z";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBanHang,
            this.menuNhanVien,
            this.menuThanhPho,
            this.menuHoaDon,
            this.menuQuanLyTaiKhoan});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // menuBanHang
            // 
            this.menuBanHang.Name = "menuBanHang";
            this.menuBanHang.Size = new System.Drawing.Size(180, 22);
            this.menuBanHang.Text = "Quản lý bán hàng";
            this.menuBanHang.Click += new System.EventHandler(this.menuBanHang_Click);
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(180, 22);
            this.menuNhanVien.Text = "Quản lý nhân viên";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);
            // 
            // menuThanhPho
            // 
            this.menuThanhPho.Name = "menuThanhPho";
            this.menuThanhPho.Size = new System.Drawing.Size(180, 22);
            this.menuThanhPho.Text = "Quản lý thành phố";
            this.menuThanhPho.Click += new System.EventHandler(this.menuThanhPho_Click);
            // 
            // menuHoaDon
            // 
            this.menuHoaDon.Name = "menuHoaDon";
            this.menuHoaDon.Size = new System.Drawing.Size(180, 22);
            this.menuHoaDon.Text = "Quản lý hóa đơn";
            this.menuHoaDon.Click += new System.EventHandler(this.menuHoaDon_Click);
            // 
            // menuQuanLyTaiKhoan
            // 
            this.menuQuanLyTaiKhoan.Name = "menuQuanLyTaiKhoan";
            this.menuQuanLyTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.menuQuanLyTaiKhoan.Text = "Quản lí đăng nhập";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinỨngDụngToolStripMenuItem,
            this.thôngTinỨngDụngToolStripMenuItem1});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // thôngTinỨngDụngToolStripMenuItem
            // 
            this.thôngTinỨngDụngToolStripMenuItem.Name = "thôngTinỨngDụngToolStripMenuItem";
            this.thôngTinỨngDụngToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thôngTinỨngDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // thôngTinỨngDụngToolStripMenuItem1
            // 
            this.thôngTinỨngDụngToolStripMenuItem1.Name = "thôngTinỨngDụngToolStripMenuItem1";
            this.thôngTinỨngDụngToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.thôngTinỨngDụngToolStripMenuItem1.Text = "Thông tin ứng dụng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(466, 384);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvhoadon);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(465, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 385);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbmonan);
            this.panel2.Controls.Add(this.cmbdanhmucmonan);
            this.panel2.Controls.Add(this.nudThemmon);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 53);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nudgiamgia);
            this.panel3.Controls.Add(this.btnGiamGia);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(1, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 50);
            this.panel3.TabIndex = 1;
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Location = new System.Drawing.Point(2, 58);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.Size = new System.Drawing.Size(282, 277);
            this.dgvhoadon.TabIndex = 2;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(212, 0);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(72, 51);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm Món";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nudThemmon
            // 
            this.nudThemmon.Location = new System.Drawing.Point(238, 17);
            this.nudThemmon.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudThemmon.Name = "nudThemmon";
            this.nudThemmon.Size = new System.Drawing.Size(44, 20);
            this.nudThemmon.TabIndex = 2;
            this.nudThemmon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudThemmon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Location = new System.Drawing.Point(114, 3);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(75, 23);
            this.btnGiamGia.TabIndex = 1;
            this.btnGiamGia.Text = "Giảm Giá";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            // 
            // nudgiamgia
            // 
            this.nudgiamgia.Location = new System.Drawing.Point(116, 27);
            this.nudgiamgia.Name = "nudgiamgia";
            this.nudgiamgia.Size = new System.Drawing.Size(73, 20);
            this.nudgiamgia.TabIndex = 2;
            this.nudgiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbdanhmucmonan
            // 
            this.cmbdanhmucmonan.FormattingEnabled = true;
            this.cmbdanhmucmonan.Location = new System.Drawing.Point(3, 4);
            this.cmbdanhmucmonan.Name = "cmbdanhmucmonan";
            this.cmbdanhmucmonan.Size = new System.Drawing.Size(152, 21);
            this.cmbdanhmucmonan.TabIndex = 3;
            // 
            // cmbmonan
            // 
            this.cmbmonan.FormattingEnabled = true;
            this.cmbmonan.Location = new System.Drawing.Point(3, 29);
            this.cmbmonan.Name = "cmbmonan";
            this.cmbmonan.Size = new System.Drawing.Size(152, 21);
            this.cmbmonan.TabIndex = 4;
            // 
            // FormManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Chính";
            this.Load += new System.EventHandler(this.FormManHinhChinh_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThemmon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudgiamgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDangNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuBanHang;
        private System.Windows.Forms.ToolStripMenuItem menuThanhPho;
        private System.Windows.Forms.ToolStripMenuItem menuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem thôngTinỨngDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinỨngDụngToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvhoadon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nudgiamgia;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudThemmon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbmonan;
        private System.Windows.Forms.ComboBox cmbdanhmucmonan;
    }
}