using QuanLyThienNguyen.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class DTO_HoDan
    {
        public string MaHD { get; set; }
        public string HoTenChuHo { get; set; }
        public bool GioiTinh { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string DienGiaDinh { get; set; }

        public static List<string> items = new List<string>(new string[]
        {
            "Mã hộ dân", "Họ tên chủ hộ", "Giới tính", "Căn cước công dân", "Địa chỉ", "Số điện thoại", "Diện gia đình"
        });
        public static string RenameNameTable_FromDataGridViewToSql(string namecolumn)
        {
            if (namecolumn == "Mã hộ dân")
                return "MaHD";
            if (namecolumn == "Họ tên chủ hộ")
                return "HoTenChuHo";
            if (namecolumn == "Giới tính")
                return "GioiTinh";
            if (namecolumn == "Căn cước công dân")
                return "CCCD";
            if (namecolumn == "Địa chỉ")
                return "DiaChi";
            if (namecolumn == "Số điện thoại")
                return "SDT";
            if (namecolumn == "Diện gia đình")
                return "DienGiaDinh";
            return namecolumn;
        }
    }
}