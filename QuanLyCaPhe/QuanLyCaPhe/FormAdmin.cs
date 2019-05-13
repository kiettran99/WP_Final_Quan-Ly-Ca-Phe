﻿using System;
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
        ThucAn ta = null;
        string err;
<<<<<<< HEAD
      
=======
        string tk, mk;
        private string error;
>>>>>>> cb4ebb89b2c32d73a8c6da35a4fa58cb13cbbd7f
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
            kq = MessageBox.Show("Bạn thật sự muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
