using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class DTOThanhVienDVUH
    {
        private string _MaDVUH;
        private string _HoTen;
        private bool _GioiTinh;
        private string _CCCD;
        private string _DiaChi;
        private string _SDT;
        public string MaDVUH { get => _MaDVUH; set => _MaDVUH = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public bool GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string CCCD { get => _CCCD; set => _CCCD = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }

        public DTOThanhVienDVUH() { }
        public DTOThanhVienDVUH(string ma, string ten, bool gt, string cccd, string dc, string sdt)
        {
            this.MaDVUH = ma;
            this.HoTen = ten;
            this.GioiTinh = gt;
            this.CCCD = cccd;
            this.DiaChi = dc;
            this.SDT = sdt;
        }
        public DTOThanhVienDVUH(DataRow row)
        {
            this.MaDVUH = row["MaDVUH"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.GioiTinh = Convert.ToBoolean(row["GioiTinh"].ToString());
            this.CCCD = row["CCCD"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
        }

        public static List<string> items = new List<string>(new string[]
        {
            "Mã đơn vị ủng hộ", "Họ tên", "Giới tính", "Căn cước công dân", "Địa chỉ", "Số điện thoại"
        });
        public static string RenameNameTable_FromDataGridViewToSql(string namecolumn)
        {
            if (namecolumn == "Mã đơn vị ủng hộ")
                return "MaDVUH";
            if (namecolumn == "Họ tên")
                return "HoTen";
            if (namecolumn == "Giới tính")
                return "GioiTinh";
            if (namecolumn == "Căn cước công dân")
                return "CCCD";
            if (namecolumn == "Địa chỉ")
                return "DiaChi";
            if (namecolumn == "Số điện thoại")
                return "SDT";
            return namecolumn;
        }
    }
}