using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaPhe.BSLayer;

namespace QuanLyCaPhe
{
    public partial class FormManHinhChinh : Form
    {
        string error;
        BanAn banan = null;
        ChiTietHoaDon chitiethd = null;
        LoaiThucAn loaita = null;
        ThucAn thucan = null;
        HoaDon hoadon = null;
        int idBan;
        float TongTienGoc = 0;

        public FormManHinhChinh()
        {
            InitializeComponent();
            banan = new BanAn();
            chitiethd = new ChiTietHoaDon();
            loaita = new LoaiThucAn();
            thucan = new ThucAn();
            hoadon = new HoaDon();
            LoadTable();
        }

        #region Method

        private void LoadCategory()
        {
            //Load dữ liệu combobox
            cmbdanhmucmonan.DataSource = loaita.LayLoaiThucAn().Tables[0];
            cmbdanhmucmonan.DisplayMember = "TenLoaiThucAn";
        }

        private void LoadFoodByCategory(string tenLoaiThucAn)
        {
            //cmbdanhmucmonan.GetItemText(cmbdanhmucmonan.SelectedItem)
            cmbmonan.DataSource = thucan.LayThucAnTheoLoai(tenLoaiThucAn).Tables[0];
            cmbmonan.DisplayMember = "TenThucAn";
        }

        private void LoadTable()
        {
            //Load Dữ liệu bàn
            List<Ban> lBanAn = banan.DanhsachBan();

            foreach (Ban ban in lBanAn)
            {
                Button btn = new Button() { Width = (int)BanAn.ChieuRongBan, Height = (int)BanAn.ChieuDaiBan };
                btn.Text = ban.TenBan + Environment.NewLine + ban.TinhTrang;
                btn.Click += Btn_Click;
                btn.Tag = ban;

                //Tình trạng phụ thuộc theo màu
                if (ban.TinhTrang == "Trống")
                    btn.BackColor = Color.BlueViolet;
                else btn.BackColor = Color.Pink;

                flpnlBanAn.Controls.Add(btn);
            }

            LoadCategory();
            LoadFoodByCategory(cmbdanhmucmonan.GetItemText(cmbdanhmucmonan.SelectedItem));
        }

        private void HienThiHoaDon(int idBan)
        {
            dgvhoadon.DataSource = chitiethd.LayChiTietHoaDon(idBan).Tables[0];

            //Tính toán thành tiền
            float TongTien = 0;

            for (int i = 0; i < dgvhoadon.Rows.Count; i++)
            {
                try
                {
                    float soluong = float.Parse(dgvhoadon.Rows[i].Cells[2].Value.ToString());
                    float giatien = float.Parse(dgvhoadon.Rows[i].Cells[3].Value.ToString());
                    dgvhoadon.Rows[i].Cells[0].Value = soluong * giatien;
                    TongTien += soluong * giatien;
                }
                catch { }
            }
            TongTienGoc = TongTien;
            txtTongtien.Text = TongTien.ToString();
        }
        #endregion

        private void Btn_Click(object sender, EventArgs e)
        {
            idBan = (((sender as Button).Tag) as Ban).Id;
            dgvhoadon.Tag = (sender as Button).Tag;
            HienThiHoaDon(idBan);

        }

        /// <summary>
        /// Phương thức này sẽ thêm danh sách món ăn vào trong hóa đơn.
        /// </summary>
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            Ban ban = dgvhoadon.Tag as Ban;

            //Lấy ID Hóa đơn của bàn
            int idHoaDon = hoadon.LayIDHoaDonTheoBan(ban.Id);
            int idFood = thucan.TimIDThucAn(cmbmonan.GetItemText(cmbmonan.SelectedItem), ref error);
            int count = (int)nudThemmon.Value;

            //Kiểm tra xem đã có sẵn hóa đơn chưa, nếu mới tạo thêm hóa đơn
            if (idHoaDon == -1)
            {
                hoadon.ThemHoaDonTheoBan(ban.Id, ref error);
                chitiethd.ThemChiTietHD(hoadon.MaxIDHoaDon(ref error), idFood, count, ref error);
                banan.ThayDoiTinhTrang(ban.Id, true, ref error);
                flpnlBanAn.Controls.Clear();
                LoadTable();
                HienThiHoaDon(ban.Id);
            }
            else
            {
                chitiethd.ThemChiTietHD(hoadon.MaxIDHoaDon(ref error), idFood, count, ref error);
                HienThiHoaDon(ban.Id);
            }
        }

        #region Events

        private void cmbdanhmucmonan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFoodByCategory(cmbdanhmucmonan.GetItemText(cmbdanhmucmonan.SelectedItem));
        }

        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap formdangnhap = new FormDangNhap();
            formdangnhap.ShowDialog();
        }

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien nv = new FormNhanVien();
            nv.ShowDialog();
        }

        private void menuBanHang_Click(object sender, EventArgs e)
        {

        }

        private void menuAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin ad = new FormAdmin();
            ad.ShowDialog();
        }

        private void menuHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon hd = new FormHoaDon();
            hd.ShowDialog();
        }

        private void menuThanhPho_Click(object sender, EventArgs e)
        {
            FormThanhPho tp = new FormThanhPho();
            tp.ShowDialog();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void FormManHinhChinh_Load(object sender, EventArgs e)
        {
            //panel1.Enabled = false;
            //panel2.Enabled = false;
            //panel3.Enabled = false;
        }
        #endregion

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            int IDBill = hoadon.LayIDHoaDonTheoBan(idBan);
            if (IDBill != 1)
            {
                if (MessageBox.Show("Bạn thật sự muốn thanh toán hóa đơn cho bàn " + idBan, "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    hoadon.CheckOut(IDBill, (int)nudgiamgia.Value, float.Parse(txtTongtien.Text));
                    banan.ThayDoiTinhTrang((dgvhoadon.Tag as Ban).Id, false, ref error);
                    flpnlBanAn.Controls.Clear();
                    LoadTable();
                    HienThiHoaDon((dgvhoadon.Tag as Ban).Id);
                }
            }
        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            float tongtien = TongTienGoc;
            if (nudgiamgia.Value >= 0)
                tongtien -= tongtien * (float)nudgiamgia.Value / 100;
            txtTongtien.Text = tongtien.ToString();
        }
    }
}
