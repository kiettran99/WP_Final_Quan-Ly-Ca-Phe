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
    public partial class FormAdmin : Form
    {
        #region Properties TabNhanVien
        DataTable dataTable = null;
        NhanVien BLNV = new NhanVien();
        ThucAn BLTA = new ThucAn();
        LoaiThucAn BTLTA = new LoaiThucAn();
        BanAn BTLBA = new BanAn();
      
        string err;
        string tk, mk;
        private string error;
        #endregion

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Chọn tab nhân viên, sẽ load dữ liệu lên.
            switch (tabControl.SelectedIndex)
            {
                case 1:
                    LoadDataF();

                    break;
                case 5:
                    LoadDataNV();
                    break;
            }
        }

        #region TabNhanVien

        /// <summary>
        /// Load dữ liệu nhân viên.
        /// </summary>
        private void LoadDataNV()
        {
            try
            {
                dataTable = new DataTable();
                dataTable.Clear();
                DataSet ds = BLNV.LayNhanVien();
                dataTable = ds.Tables[0];
                // đưa dữ liệu vào dataGridView
                dgvNhanVien.DataSource = dataTable;
            }
            catch (Exception errr)
            {
                MessageBox.Show(errr.Message);
            }
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtHoNV.ResetText();
            txtDiaChi.ResetText();
            txtDienThoai.ResetText();
            txtHoNV.ResetText();
            dtbNgayNV.ResetText();
            dtbNgaySinh.ResetText();
            // không cho thao tác trên các nút lưu/hủy
            btnHuyNV.Enabled = false;
            btnLuuNV.Enabled = false;

            btnReloadNV.Enabled = true;
            btnThemNV.Enabled = true;
            btnXoaNV.Enabled = true;
        }
        private void LoadDataF()
        {
            try
            {
                dataTable = new DataTable();
                dataTable.Clear();
                DataSet ds = BLTA.LayThucAn();
                dataTable = ds.Tables[0];
                // đưa dữ liệu vào dataGridView
                dgvThucAn.DataSource = dataTable;
            }
            catch (Exception errr)
            {
                MessageBox.Show(errr.Message);
            }
            txtFID.ResetText();
            txtFName.ResetText();
            txtSFname.ResetText();
            txtGiaF.ResetText();
            // không cho thao tác trên các nút lưu/hủy
            btnHuyF.Enabled = false;
            btnLuuF.Enabled = false;
            btnThemF.Enabled = true;
            btnXoaF.Enabled = true;
            btnSuaF.Enabled = true;
            dgvThucAn_CellClick(null, null);
        }




        private void btnThemNV_Click(object sender, EventArgs e)
        {
            btnThemNV.Enabled = false;

            btnReloadNV.Enabled = false;

            btnLuuNV.Enabled = true;
            btnHuyNV.Enabled = true;

            txtMaNV.ResetText();
            txtMaNV.Enabled = false;
            txtTenNV.ResetText();
            txtHoNV.ResetText();
            txtDiaChi.ResetText();
            txtDienThoai.ResetText();
            txtHoNV.ResetText();
            dtbNgayNV.ResetText();
            dtbNgaySinh.ResetText();

            Random rd = new Random();
            txtMaNV.Text = rd.Next(0, 50000).ToString();

            dgvNhanVien_CellClick(null, null);
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {

            BLNV.ThemNhanVien(txtMaNV.Text, txtHoNV.Text.Trim(), txtTenNV.Text.Trim(), rdbNu.Checked, dtbNgayNV.Value,
                dtbNgaySinh.Value, txtDiaChi.Text.Trim(), txtDienThoai.Text.Trim(), ref err);
            // Load lại DataGridView
            LoadDataNV();
            // THông Báo
            MessageBox.Show(err);

        }

        private void btnReloadNV_Click(object sender, EventArgs e)
        {
            LoadDataNV();
        }

        private void btnHuyNV_Click(object sender, EventArgs e)
        {
            txtMaNV.ResetText();
            dgvNhanVien_CellClick(null, null);

            btnLuuNV.Enabled = false;
            btnHuyNV.Enabled = false;
            btnReloadNV.Enabled = true;
            btnThemNV.Enabled = true;
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    BLNV.XoaNhanVien(txtMaNV.Text, ref err);
                    LoadDataNV();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvNhanVien.CurrentCell.RowIndex;
                txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                rdbNu.Checked = (bool)dgvNhanVien.Rows[r].Cells[3].Value;
                dtbNgayNV.Text = dgvNhanVien.Rows[r].Cells[7].Value.ToString();
                dtbNgayNV.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
                txtHoNV.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
                txtDienThoai.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        #endregion

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = new DialogResult();
            kq = MessageBox.Show("Bạn thật sự muốn thoát", "Thông báo", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {

        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }






        #region tabthucan
        private void btnThemF_Click(object sender, EventArgs e)
        {
            btnThemF.Enabled = false;
            btnXoaF.Enabled = false;
            btnSuaF.Enabled = false;
            btnXemF.Enabled = false;
            btnLuuF.Enabled = true;
            btnHuyF.Enabled = true;
            txtFID.ResetText();
            txtFName.ResetText();
            txtSFname.ResetText();
            cmbDanhMucF.ResetText();
             txtGiaF.ResetText();
            Random rd = new Random();
            txtFID.Text = rd.Next(0, 10000).ToString();

        }

        private void dgvThucAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvThucAn.CurrentCell.RowIndex;
                txtFID.Text = dgvThucAn.Rows[r].Cells[0].Value.ToString();
                txtFName.Text = dgvThucAn.Rows[r].Cells[1].Value.ToString();
                cmbDanhMucF.Text = dgvThucAn.Rows[r].Cells[2].Value.ToString();
                txtGiaF.Text = dgvThucAn.Rows[r].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }


        private void btnHuyF_Click(object sender, EventArgs e)
        {
            btnThemF.Enabled = false;
            btnXoaF.Enabled = true;
            btnSuaF.Enabled = true;
            btnXemF.Enabled = false;
            btnLuuF.Enabled = true;
            btnHuyF.Enabled = false;
            dgvThucAn_CellClick(null, null);
        }

        private void btnXoaF_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    BLTA.XoaThucAn(txtFID.Text, ref err);
                    LoadDataF();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void btnLuuF_Click(object sender, EventArgs e)
        {
            BLTA.ThemThucAn(txtFID.Text, txtFName.Text.Trim(),txtGiaF.Text.Trim(),
               cmbDanhMucF.Text.Trim(), ref err);
            // Load lại DataGridView
            LoadDataNV();
            // THông Báo
            MessageBox.Show(err);
        }
        private void btnSuaF_Click(object sender, EventArgs e)
        {
            txtFID.ResetText();
            txtFName.ResetText();
            cmbDanhMucF.ResetText();
            txtGiaF.ResetText();
            btnSuaF.Enabled = false;
            btnXoaF.Enabled = false;
            btnLuuF.Enabled = true;
            btnXemF.Enabled = false;
            btnHuyF.Enabled = true;
            dgvThucAn_CellClick(null, null);
        }


        private void btnXemF_Click(object sender, EventArgs e)
        {
            LoadDataF();
        }
        #endregion
        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        #region tabDanhmuc
        private void LoadDataDM()
        {
            try
            {
                dataTable = new DataTable();
                dataTable.Clear();
                DataSet ds = BTLTA.LayDanhMuc();
                dataTable = ds.Tables[0];
                // đưa dữ liệu vào dataGridView
                dgvDanhMuc.DataSource = dataTable;
            }
            catch (Exception errr)
            {
                MessageBox.Show(errr.Message);
            }
            txtLoaiThucAn.ResetText();
            txtIDdm.ResetText();
            // không cho thao tác trên các nút lưu/hủy
            btnThem.Enabled = false;
            btnLuu.Enabled = false;
              btnXem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            dgvDanhMuc_CellClick(null, null);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXem.Enabled = false;
            btnLuu.Enabled = true;
            txtIDdm.ResetText();
            txtLoaiThucAn.ResetText();
            Random rd = new Random();
            txtIDdm.Text = rd.Next(0, 100000).ToString();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    BTLTA.XoaDanhMuc(txtFID.Text, ref err);
                    LoadDataDM();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            BTLTA.ThemDanhMuc(txtIDdm.Text, txtLoaiThucAn.Text, ref err);
            // Load lại DataGridView
            LoadDataDM();
            // THông Báo
            MessageBox.Show(err);
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvDanhMuc.CurrentCell.RowIndex;
                 txtIDdm.Text = dgvDanhMuc.Rows[r].Cells[0].Value.ToString();
                txtLoaiThucAn.Text = dgvDanhMuc.Rows[r].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDataDM();
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            txtLoaiThucAn.ResetText();
            btnSua.Enabled = false;
            btnXem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            dgvDanhMuc_CellClick(null, null);
        }
        #endregion
        #region tabBanAn
        private void LoadDataBanAn()
        {
            try
            {
                dataTable = new DataTable();
                dataTable.Clear();
                DataSet ds = BTLBA.LayBanAn();
                dataTable = ds.Tables[0];
                // đưa dữ liệu vào dataGridView
               dgvBanAn.DataSource = dataTable;
            }
            catch (Exception errr)
            {
                MessageBox.Show(errr.Message);
            }
           txtIDB.ResetText();
            txtTenBanAn.ResetText();
            txtTrangThai.ResetText();
            // không cho thao tác trên các nút lưu/hủy
            btnThemB.Enabled = true;
           btnSuaB.Enabled =true;
            btnXoaB.Enabled = true;
           btnLuuB.Enabled = false;
            btnXemB.Enabled = true;
            dgvDanhMuc_CellClick(null, null);
        }

        private void dgvBanAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvBanAn.CurrentCell.RowIndex;
                txtIDB.Text = dgvBanAn.Rows[r].Cells[0].Value.ToString();
                txtTenBanAn.Text = dgvBanAn.Rows[r].Cells[1].Value.ToString();
                txtTrangThai.Text = dgvBanAn.Rows[r].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThemB_Click(object sender, EventArgs e)
        {
            btnThemB.Enabled = false;
            btnSuaB.Enabled = false;
            btnXemB.Enabled = false;
            btnLuuB.Enabled = true;
            txtTrangThai.ResetText();
            txtIDB.ResetText();
            txtTenBanAn.ResetText();
            Random rd = new Random();
            txtIDB.Text = rd.Next(0, 100000).ToString();

        }
        private void btnXoaB_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    BTLBA.XoaBanAn(txtFID.Text, ref err);
                   LoadDataBanAn();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void btnSuaB_Click(object sender, EventArgs e)
        {
            txtIDB.ResetText();
            txtTenBanAn.ResetText();
            txtTrangThai.ResetText();
            btnSuaB.Enabled = false;
            btnXemB.Enabled = false;
            btnXoaB.Enabled = false;
            btnLuuB.Enabled = true;
            dgvBanAn_CellClick(null, null);
        }

        private void btnXemB_Click(object sender, EventArgs e)
        {
            LoadDataBanAn();
        }

        private void btnLuuB_Click(object sender, EventArgs e)
        {
            BTLBA.ThemBanAn(txtIDB.Text, txtTenBanAn.Text,txtTrangThai.Text, ref err);
            // Load lại DataGridView
           LoadDataBanAn();
            // THông Báo
            MessageBox.Show(err);
        }



        #endregion

        private void txtIDdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
