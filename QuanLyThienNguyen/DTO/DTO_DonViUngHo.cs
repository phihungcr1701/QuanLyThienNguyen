using QuanLyThienNguyen.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class DTO_DonViUngHo
    {
        public string MaDVUH { get; set; }
        public string TenDonVi { get; set; }
        public string DiaChiDonVi { get; set; }
        public string SDTDonVi { get; set; }

        public static List<string> items = new List<string>(new string[]
        {
            "Mã đơn vị ủng hộ", "Tên đơn vị", "Địa chỉ đơn vị", "Số điện thoại đơn vị"
        });
        public static string RenameNameTable_FromDataGridViewToSql(string namecolumn)
        {
            if (namecolumn == "Mã đơn vị ủng hộ")
                return "MaDVUH";
            if (namecolumn == "Tên đơn vị")
                return "TenDonVi";
            if (namecolumn == "Địa chỉ đơn vị")
                return "DiaChiDonVi";
            if (namecolumn == "Số điện thoại đơn vị")
                return "SDTDonVi";
            return namecolumn;
        }
    }
}