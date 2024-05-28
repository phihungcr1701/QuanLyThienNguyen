using QuanLyThienNguyen.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class DTO_HinhThucUngHo
    {
        public string MaHTUH { get; set; }
        public string TenHTUH { get; set; }
        public string DonViTinh { get; set; }

        public static List<string> items = new List<string>(new string[]
        {
            "Mã hình thức ủng hộ", "Tên hình thức ủng hộ", "Đơn vị tính"
        });
        public static string RenameNameTable_FromDataGridViewToSql(string namecolumn)
        {
            if (namecolumn == "Mã hình thức ủng hộ")
                return "MaHTUH";
            if (namecolumn == "Tên hình thức ủng hộ")
                return "TenHTUH";
            if (namecolumn == "Đơn vị tính")
                return "DonViTinh";
            return namecolumn;
        }
    }
}