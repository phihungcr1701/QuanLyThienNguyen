using QuanLyThienNguyen.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class ThanhVienDVUHView
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

        public ThanhVienDVUHView() { }
        public ThanhVienDVUHView(string ma, string ten, bool gt, string cccd, string dc, string sdt)
        {
            this.MaDVUH = ma;
            this.HoTen = ten;
            this.GioiTinh = gt;
            this.CCCD = cccd;
            this.DiaChi = dc;
            this.SDT = sdt;
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
        public static ThanhVienDVUH ToChange(ThanhVienDVUHView item)
        {
            return new ThanhVienDVUH
            {
                MaDVUH = item.MaDVUH,
                HoTen = item.HoTen,
                GioiTinh = item.GioiTinh,
                CCCD = item.CCCD,
                DiaChi = item.DiaChi,
                SDT = item.SDT
            };
        }
    }
}