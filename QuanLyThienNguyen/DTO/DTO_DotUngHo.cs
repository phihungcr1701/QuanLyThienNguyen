using QuanLyThienNguyen.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class DTO_DotUngHo
    {
        public string MaDUH { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public static List<string> items = new List<string>(new string[]
        {
            "Mã đợt ủng hộ", "Ngày bắt đầu", "Ngày kết thúc"
        });
        public static string RenameNameTable_FromDataGridViewToSql(string namecolumn)
        {
            if (namecolumn == "Mã đợt ủng hộ")
                return "MaDVUH";
            if (namecolumn == "Ngày bắt đầu")
                return "NgayBatDau";
            if (namecolumn == "Ngày kết thúc")
                return "NgayKetThuc";
            return namecolumn;
        }
    }
}