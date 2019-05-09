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
    class DangNhap
    {
        DBMain dbMain = null;
        public DangNhap()
        {
            dbMain = new DBMain();
        }

        public bool KiemTra(string tk,string mk,ref string err,ref string MaNV)
        {            
                string sqlstring = "Select Count(*) From DangNhap Where TaiKhoan = '" + tk + "'";
            if (dbMain.CheckThongTin(sqlstring, CommandType.Text, ref err) == false)
            {
                err = "Thất Bại";
                return false;
            }
            else
            {
                err = "Thành Công";
                sqlstring = "Select MaNV From DangNhap where TaiKhoan='" + tk + "'";
                dbMain.LayMa(sqlstring, CommandType.Text,ref  MaNV);

            }

            return true;
        }
       
    }
}
