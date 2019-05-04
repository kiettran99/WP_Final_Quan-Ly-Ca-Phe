namespace QuanLyCaPhe
{
    partial class FormKhachHang
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
            this.BtXoa = new System.Windows.Forms.Button();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbHKH = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbHo = new System.Windows.Forms.Label();
            this.lbNS = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.tbMKH = new System.Windows.Forms.TextBox();
            this.lbKH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvKH = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // BtXoa
            // 
            this.BtXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtXoa.Image = global::QuanLyCaPhe.Properties.Resources._3Xoa;
            this.BtXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtXoa.Location = new System.Drawing.Point(622, 357);
            this.BtXoa.Name = "BtXoa";
            this.BtXoa.Size = new System.Drawing.Size(81, 41);
            this.BtXoa.TabIndex = 0;
            this.BtXoa.Text = "Xóa";
            this.BtXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtXoa.UseVisualStyleBackColor = true;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(479, 90);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtNgaySinh.TabIndex = 17;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(479, 162);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(232, 22);
            this.tbDiaChi.TabIndex = 12;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(188, 162);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(161, 22);
            this.tbTen.TabIndex = 13;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(479, 130);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(205, 22);
            this.tbSDT.TabIndex = 14;
            // 
            // tbHKH
            // 
            this.tbHKH.Location = new System.Drawing.Point(187, 124);
            this.tbHKH.Name = "tbHKH";
            this.tbHKH.Size = new System.Drawing.Size(161, 22);
            this.tbHKH.TabIndex = 15;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(63, 165);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(119, 17);
            this.lbTen.TabIndex = 6;
            this.lbTen.Text = "Tên Khách Hàng:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(371, 165);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(53, 17);
            this.lbDiaChi.TabIndex = 7;
            this.lbDiaChi.Tag = "";
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(371, 130);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(102, 17);
            this.lbSDT.TabIndex = 8;
            this.lbSDT.Tag = "";
            this.lbSDT.Text = "Số Điện Thoại:";
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Location = new System.Drawing.Point(63, 130);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(112, 17);
            this.lbHo.TabIndex = 9;
            this.lbHo.Text = "Họ Khách Hàng:";
            // 
            // lbNS
            // 
            this.lbNS.AutoSize = true;
            this.lbNS.Location = new System.Drawing.Point(371, 90);
            this.lbNS.Name = "lbNS";
            this.lbNS.Size = new System.Drawing.Size(77, 17);
            this.lbNS.TabIndex = 10;
            this.lbNS.Tag = "";
            this.lbNS.Text = "Ngày Sinh:";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(63, 90);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(117, 17);
            this.lbMaKH.TabIndex = 11;
            this.lbMaKH.Text = "Mã Khách Hàng: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvKH);
            this.panel2.Controls.Add(this.BtXoa);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btLuu);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Controls.Add(this.tbMKH);
            this.panel2.Location = new System.Drawing.Point(39, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 418);
            this.panel2.TabIndex = 4;
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::QuanLyCaPhe.Properties.Resources._2Sua;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(463, 357);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(74, 41);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Image = global::QuanLyCaPhe.Properties.Resources.Luu;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(305, 357);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(80, 41);
            this.btLuu.TabIndex = 0;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::QuanLyCaPhe.Properties.Resources._1Them;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(119, 357);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(99, 41);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tbMKH
            // 
            this.tbMKH.Location = new System.Drawing.Point(149, 14);
            this.tbMKH.Name = "tbMKH";
            this.tbMKH.Size = new System.Drawing.Size(161, 22);
            this.tbMKH.TabIndex = 16;
            this.tbMKH.Text = "1";
            // 
            // lbKH
            // 
            this.lbKH.AutoSize = true;
            this.lbKH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKH.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbKH.Location = new System.Drawing.Point(190, 10);
            this.lbKH.Name = "lbKH";
            this.lbKH.Size = new System.Drawing.Size(351, 33);
            this.lbKH.TabIndex = 0;
            this.lbKH.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbKH);
            this.panel1.Location = new System.Drawing.Point(39, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 52);
            this.panel1.TabIndex = 5;
            // 
            // DgvKH
            // 
            this.DgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKH.Location = new System.Drawing.Point(27, 184);
            this.DgvKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvKH.Name = "DgvKH";
            this.DgvKH.RowTemplate.Height = 28;
            this.DgvKH.Size = new System.Drawing.Size(782, 146);
            this.DgvKH.TabIndex = 18;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 522);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbHKH);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbHo);
            this.Controls.Add(this.lbNS);
            this.Controls.Add(this.lbMaKH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.TextBox tbHKH;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.Label lbNS;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbKH;
        private System.Windows.Forms.TextBox tbMKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvKH;
    }
}