using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCaPhe.DBLayer;
using System.Data;
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
        public bool ThemNhanVien(string MaNV, string Ho, string TenNV, bool Nu, DateTime NgayNV, DateTime NgaySinh, string DiaChi, string SDT, ref string error)
        {
            string sqlString;
            try
            {
                 sqlString = "Insert Into NhanVien Values(" + "'" + MaNV + "',N'" + Ho + "',N'" + TenNV + "',N'" + Nu + "',N'" + NgaySinh + "',N'" + SDT + "',N'" + DiaChi + "',N'" + NgayNV + "')";
            }
            catch (Exception)
            {
                error = "Thêm Không được";
                return false;
            }
            error = "Thêm thành công";
            return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
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
            catch(Exception)
            {
                error = "Sửa không được";
                return false;
            }
            error = "Sửa thành công";
            return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public bool Xoa(ref string error, string MaNV)
        {
            string sqlString;
            try
            {
                sqlString = "Delete From NhanVien Where MaNV='" + MaNV + "'";
            }
            catch (Exception)
            {
                error = "Xóa không được";
                return false;
            }
            error = "Xóa thành công";
            return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }




    }
}
