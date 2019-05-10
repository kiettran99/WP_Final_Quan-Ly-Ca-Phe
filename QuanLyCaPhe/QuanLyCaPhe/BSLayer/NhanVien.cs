using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCaPhe.DBLayer;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCaPhe.BSLayer
{
    class NhanVien
    {
        DBMain dbMain = null;

        public NhanVien()
        {
            dbMain = new DBMain();
        }

        public DataSet LayNhanVien()
        {
            return dbMain.ExecuteQueryDataSet("select *from NhanVien", CommandType.Text);
        }
        public bool SuaNhanVien(string MaNV, string Ho, string TenNV, bool Nu, DateTime NgayNV, DateTime NgaySinh, string DiaChi, string SDT, ref string error)
        {
            string sqlString;
            try
            {
                    sqlString = "Update NhanVien Set HoNV=N'" + Ho + "',TenNV=N'" + TenNV +
                    "',Nu='" + Nu + "',NgayBD='" + NgayNV + "',NgaySinh='" + NgaySinh +
                    "',DiaChi=N'" + DiaChi + "',SDT='" + SDT + "' Where MaNV= '" + MaNV + "'";
            }
            catch(SqlException)
            {
                error = "Sửa không được";
                return false;
            }
            error = "Sửa thành công";
            return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public void LayTKMK(string MaNV,ref string TK,ref string MK)
        {
            string sqlString;
            sqlString = "Select TaiKhoan From DangNhap where MaNV = N'" + MaNV + "'";
            dbMain.LayMa(sqlString, CommandType.Text, ref TK);
            sqlString = "Select MatKhau From DangNhap where MaNV=N'" + MaNV + "'";
            dbMain.LayMa(sqlString, CommandType.Text,ref MK);
        }



    }
}
