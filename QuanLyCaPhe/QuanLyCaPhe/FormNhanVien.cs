using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCaPhe.BSLayer;
namespace QuanLyCaPhe
{
    public partial class FormNhanVien : Form
    {
        DataTable dataTable = null;
        NhanVien BLNV = new NhanVien();
        string err;
        public FormNhanVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
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
                catch
                {
                    MessageBox.Show("Load khong thanh cong");
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
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;              
                // cho phép thao tác trên thêm/sửa/xóa/thoát
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi không Load được");
            }
        }
        bool them;
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReLoad.Enabled = false;
            btnThoat.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtHoNV.ResetText();
            txtDiaChi.ResetText();
            txtDienThoai.ResetText();
            txtHoNV.ResetText();
            dtbNgayNV.ResetText();
            dtbNgaySinh.ResetText();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {            
            LoadData();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {

                //thuc hiện lệnh
                NhanVien blnv = new NhanVien();
                blnv.ThemNhanVien(txtMaNV.Text, txtHoNV.Text.Trim(), txtTenNV.Text.Trim(), rdbNu.Checked, dtbNgayNV.Value,
                    dtbNgaySinh.Value, txtDiaChi.Text.Trim(), txtDienThoai.Text.Trim(), ref err);
                // Load lại DataGridView
                LoadData();
                // THông Báo
                MessageBox.Show(err);

            }
            else
            {

                //thuc hiện lệnh
                NhanVien blnv = new NhanVien();
                blnv.SuaNhanVien(txtMaNV.Text, txtHoNV.Text.Trim(), txtTenNV.Text.Trim(), rdbNu.Checked, dtbNgayNV.Value,
                    dtbNgaySinh.Value, txtDiaChi.Text.Trim(), txtDienThoai.Text.Trim(), ref err);
                // Load lại DataGridView
                LoadData();
                // THông Báo
                MessageBox.Show(err);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them =false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReLoad.Enabled = false;
            btnThoat.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaNV.ResetText();
            txtMaNV.Enabled = false;
            txtTenNV.ResetText();
            txtHoNV.ResetText();
            txtDiaChi.ResetText();
            txtDienThoai.ResetText();
            txtHoNV.ResetText();
            dtbNgayNV.ResetText();
            dtbNgaySinh.ResetText();

            dgvNhanVien_CellClick(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
           
            DialogResult kq = new DialogResult();
            kq=MessageBox.Show("Bạn thực sự muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.OK)
            {
                
                    BLNV.Xoa(ref err, txtMaNV.Text);
                    // load dữ liệu
                    LoadData();
              
                MessageBox.Show(err);
            }
            else
                dgvNhanVien.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvNhanVien_CellClick(null, null);
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnReLoad.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = new DialogResult();
            kq = MessageBox.Show("Bạn thật sự muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
