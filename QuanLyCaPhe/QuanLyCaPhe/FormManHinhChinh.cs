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
        BanAn banan = null;

        public FormManHinhChinh()
        {
            InitializeComponent();
            banan = new BanAn();
            LoadTable();
        }

        private void LoadTable()
        {
            List<Ban> lBanAn = banan.DanhsachBan();

            foreach(Ban ban in lBanAn)
            {
                Button btn = new Button() { Width = (int)BanAn.ChieuRongBan, Height = (int)BanAn.ChieuDaiBan };
                btn.Text = ban.TenBan + Environment.NewLine + ban.TinhTrang;

                //Tình trạng phụ thuộc theo màu
                if (ban.TinhTrang == "Trống")
                    btn.BackColor = Color.BlueViolet;
                else btn.BackColor = Color.Pink;

                flpnlBanAn.Controls.Add(btn);
            }
        }

        #region Events
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
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
        }
        #endregion
    }
}
