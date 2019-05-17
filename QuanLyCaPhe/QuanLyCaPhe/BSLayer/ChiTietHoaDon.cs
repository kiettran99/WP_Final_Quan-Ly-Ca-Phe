﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCaPhe.DBLayer;
using System.Data;

namespace QuanLyCaPhe.BSLayer
{
    class ChiTietHoaDon
    {
        DBMain db = null;

        public ChiTietHoaDon()
        {
            db = new DBMain();
        }

        /// <summary>
        /// Lấy hóa đơn từ 1 bàn
        /// </summary>
        /// <param name="idBan"></param>
        public DataSet LayChiTietHoaDon(int idBan)
        {
            string strSQL = $"Select TenThucAn, SoLuong, Gia from ChiTietHoaDon join HoaDon on ChiTietHoaDon.IDHoaDon = HoaDon.IDHoaDon join ThucAn on ThucAn.IDThucAn = ChiTietHoaDon.IDThucAn join BanAn on BanAn.IDBanAn = HoaDon.IDBanAn where BanAn.IDBanAn = {idBan} and HoaDon.TinhTrang = 0";
            return db.ExecuteQueryDataSet(strSQL, CommandType.Text);
        }

        public void ThemChiTietHD(int idHoaDon, int idThucAn, int count, ref string error)
        {
            string strSQL = $"Insert into ChiTietHoaDon(IDHoaDon, IDThucAn, SoLuong) values({idHoaDon}, {idThucAn}, {count})";
            db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error);
        }

        public void ThemChiTietHDTonTai(int idHoaDon, int idThucAn, int count, ref string error)
        {
            string strSQL = $"Insert into ChiTietHoaDon(IDHoaDon, IDThucAn, SoLuong) values({idHoaDon}, {idThucAn}, {count})";
            db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error);
        }
    }
}
