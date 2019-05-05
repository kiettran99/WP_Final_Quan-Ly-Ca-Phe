namespace QuanLyCaPhe
{
    partial class FormNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbChiTiet = new System.Windows.Forms.GroupBox();
            this.dtbNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtbNgayNV = new System.Windows.Forms.DateTimePicker();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtHoNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTongQuat = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.gbChiTiet.SuspendLayout();
            this.gbTongQuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Sitka Small", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(236, 30);
=======
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(374, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Nhân Viên";
            // 
<<<<<<< HEAD
            // gbChiTiet
            // 
            this.gbChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbChiTiet.Controls.Add(this.dtbNgaySinh);
            this.gbChiTiet.Controls.Add(this.label9);
            this.gbChiTiet.Controls.Add(this.dtbNgayNV);
            this.gbChiTiet.Controls.Add(this.rdbNu);
            this.gbChiTiet.Controls.Add(this.txtDienThoai);
            this.gbChiTiet.Controls.Add(this.txtDiaChi);
            this.gbChiTiet.Controls.Add(this.txtTenNV);
            this.gbChiTiet.Controls.Add(this.txtHoNV);
            this.gbChiTiet.Controls.Add(this.txtMaNV);
            this.gbChiTiet.Controls.Add(this.label7);
            this.gbChiTiet.Controls.Add(this.label6);
            this.gbChiTiet.Controls.Add(this.label5);
            this.gbChiTiet.Controls.Add(this.label4);
            this.gbChiTiet.Controls.Add(this.label3);
            this.gbChiTiet.Controls.Add(this.label2);
            this.gbChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChiTiet.Location = new System.Drawing.Point(198, 137);
            this.gbChiTiet.Name = "gbChiTiet";
            this.gbChiTiet.Size = new System.Drawing.Size(635, 162);
            this.gbChiTiet.TabIndex = 1;
            this.gbChiTiet.TabStop = false;
            this.gbChiTiet.Text = "Thông tin chi tiết";
            // 
            // dtbNgaySinh
            // 
            this.dtbNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbNgaySinh.Location = new System.Drawing.Point(345, 120);
            this.dtbNgaySinh.Name = "dtbNgaySinh";
            this.dtbNgaySinh.Size = new System.Drawing.Size(133, 22);
            this.dtbNgaySinh.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ngày Sinh :";
=======
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtbNgayNV);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtHoNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(310, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1030, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            // 
            // dtbNgayNV
            // 
            this.dtbNgayNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
<<<<<<< HEAD
            this.dtbNgayNV.Location = new System.Drawing.Point(372, 61);
=======
            this.dtbNgayNV.Location = new System.Drawing.Point(615, 114);
            this.dtbNgayNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.dtbNgayNV.Name = "dtbNgayNV";
            this.dtbNgayNV.Size = new System.Drawing.Size(198, 30);
            this.dtbNgayNV.TabIndex = 14;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(477, 40);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNu.Name = "rdbNu";
<<<<<<< HEAD
            this.rdbNu.Size = new System.Drawing.Size(45, 20);
=======
            this.rdbNu.Size = new System.Drawing.Size(62, 29);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.rdbNu.TabIndex = 13;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
<<<<<<< HEAD
            this.txtDienThoai.Location = new System.Drawing.Point(490, 26);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(140, 22);
=======
            this.txtDienThoai.Location = new System.Drawing.Point(747, 34);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(272, 30);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.txtDienThoai.TabIndex = 12;
            // 
            // txtDiaChi
            // 
<<<<<<< HEAD
            this.txtDiaChi.Location = new System.Drawing.Point(345, 92);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(285, 22);
=======
            this.txtDiaChi.Location = new System.Drawing.Point(615, 178);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(404, 30);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(136, 183);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(234, 30);
            this.txtTenNV.TabIndex = 10;
            // 
            // txtHoNV
            // 
            this.txtHoNV.Location = new System.Drawing.Point(136, 114);
            this.txtHoNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(234, 30);
            this.txtHoNV.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(226, 38);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(144, 30);
            this.txtMaNV.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
<<<<<<< HEAD
            this.label7.Size = new System.Drawing.Size(91, 16);
=======
            this.label7.Size = new System.Drawing.Size(118, 25);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.label7.TabIndex = 7;
            this.label7.Text = "Điện Thoại :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
<<<<<<< HEAD
            this.label6.Location = new System.Drawing.Point(254, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
=======
            this.label6.Location = new System.Drawing.Point(418, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày Nhận Việc :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
<<<<<<< HEAD
            this.label5.Location = new System.Drawing.Point(283, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
=======
            this.label5.Location = new System.Drawing.Point(496, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa Chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
<<<<<<< HEAD
            this.label4.Size = new System.Drawing.Size(43, 16);
=======
            this.label4.Size = new System.Drawing.Size(58, 25);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
<<<<<<< HEAD
            this.label3.Size = new System.Drawing.Size(40, 16);
=======
            this.label3.Size = new System.Drawing.Size(53, 25);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
=======
            this.label2.Location = new System.Drawing.Point(42, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Nhân Viên :";
            // 
            // gbTongQuat
            // 
<<<<<<< HEAD
            this.gbTongQuat.Controls.Add(this.dgvNhanVien);
            this.gbTongQuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTongQuat.Location = new System.Drawing.Point(12, 326);
            this.gbTongQuat.Name = "gbTongQuat";
            this.gbTongQuat.Size = new System.Drawing.Size(846, 171);
            this.gbTongQuat.TabIndex = 2;
            this.gbTongQuat.TabStop = false;
            this.gbTongQuat.Text = "Thông tin tổng quát";
=======
            this.groupBox2.Controls.Add(this.dgvNhanVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 418);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1648, 222);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tổng quát";
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column6,
<<<<<<< HEAD
            this.Column7,
            this.Column8,
            this.Column5,
            this.column2,
            this.Column3});
            this.dgvNhanVien.Location = new System.Drawing.Point(2, 21);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(846, 135);
=======
            this.Column7});
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 32);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1638, 208);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "ID NV";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Nu";
            this.Column4.HeaderText = "Nữ";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.HeaderText = "SDT";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DiaChi";
            this.Column7.HeaderText = "Địa Chỉ";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NgayBD";
            this.Column8.HeaderText = "Ngày NV";
            this.Column8.Name = "Column8";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgaySinh";
            this.Column5.HeaderText = "Ngày Sinh";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column2
            // 
            this.column2.DataPropertyName = "HoNV";
            this.column2.HeaderText = "Họ";
            this.column2.Name = "column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenNV";
            this.Column3.HeaderText = "Tên";
            this.Column3.Name = "Column3";
            // 
            // btnThem
            // 
<<<<<<< HEAD
            this.btnThem.BackColor = System.Drawing.Color.Red;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(2, 47);
=======
            this.btnThem.Location = new System.Drawing.Point(80, 668);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 77);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
<<<<<<< HEAD
            this.btnSua.BackColor = System.Drawing.Color.Red;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(89, 47);
=======
            this.btnSua.Location = new System.Drawing.Point(210, 668);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 77);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
<<<<<<< HEAD
            this.btnLuu.BackColor = System.Drawing.Color.Aqua;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(2, 173);
=======
            this.btnLuu.Location = new System.Drawing.Point(518, 668);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(122, 77);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
<<<<<<< HEAD
            this.btnHuy.BackColor = System.Drawing.Color.Aqua;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(89, 176);
=======
            this.btnHuy.Location = new System.Drawing.Point(648, 668);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(122, 77);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
<<<<<<< HEAD
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(2, 107);
=======
            this.btnXoa.Location = new System.Drawing.Point(962, 668);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 77);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReLoad
            // 
<<<<<<< HEAD
            this.btnReLoad.BackColor = System.Drawing.Color.Lime;
            this.btnReLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(89, 115);
=======
            this.btnReLoad.Location = new System.Drawing.Point(1089, 668);
            this.btnReLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(122, 77);
            this.btnReLoad.TabIndex = 8;
            this.btnReLoad.Text = "Reload";
            this.btnReLoad.UseVisualStyleBackColor = false;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnThoat
            // 
<<<<<<< HEAD
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(34, 232);
=======
            this.btnThoat.Location = new System.Drawing.Point(1485, 668);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 77);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
<<<<<<< HEAD
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnReLoad);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(14, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 290);
            this.panel1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(34, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Các Chức Năng";
=======
            this.btnThoat.UseVisualStyleBackColor = true;
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(866, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbTongQuat);
            this.Controls.Add(this.gbChiTiet);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
=======
            this.ClientSize = new System.Drawing.Size(1716, 769);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 4341a04b000b908bf5aa038b7740cd1cd94b3826
            this.Name = "FormNhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.gbChiTiet.ResumeLayout(false);
            this.gbChiTiet.PerformLayout();
            this.gbTongQuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbChiTiet;
        private System.Windows.Forms.DateTimePicker dtbNgayNV;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtHoNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTongQuat;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtbNgaySinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}