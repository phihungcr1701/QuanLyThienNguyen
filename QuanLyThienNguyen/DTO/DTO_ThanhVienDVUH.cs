using QuanLyThienNguyen.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class DTO_ThanhVienDVUH
    {
        public string MaTVDVUH { get; set; }
        public string MaDVUH { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }

        public static List<string> items = new List<string>(new string[]
        {
            "Mã thành viên đơn vị ủng hộ", "Mã đơn vị ủng hộ", "Họ tên", "Giới tính", "Căn cước công dân", "Địa chỉ", "Số điện thoại"
        });
        public static string RenameNameTable_FromDataGridViewToSql(string namecolumn)
        {
            if (namecolumn == "Mã thành viên đơn vị ủng hộ")
                return "MaTVDVUH";
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