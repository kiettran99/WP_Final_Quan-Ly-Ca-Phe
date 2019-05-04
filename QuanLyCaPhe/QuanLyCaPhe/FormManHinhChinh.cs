using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class FormManHinhChinh : Form
    {
        public FormManHinhChinh()
        {
            InitializeComponent();
        }

        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap formdangnhap = new FormDangNhap();
            formdangnhap.ShowDialog();
        }
    }
}
