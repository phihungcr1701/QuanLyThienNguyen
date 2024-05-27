using QuanLyThienNguyen.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class HinhThucUngHoView
    {
        private string _MaHTUH;
        private string _TenHTUH;
        private string _DonViTinh;
        public string MaHTUH { get => _MaHTUH; set => _MaHTUH = value; }
        public string TenHTUH { get => _TenHTUH; set => _TenHTUH = value; }
        public string DonViTinh { get => _DonViTinh; set => _DonViTinh = value; }

        public HinhThucUngHoView() { }
        public HinhThucUngHoView(string ma = null, string ten = null, string donvitinh = null) 
        {
            this.MaHTUH = ma;
            this.TenHTUH = ten;
            this.DonViTinh = donvitinh;
        }
        
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
        public static HinhThucUngHo ToChange(HinhThucUngHoView item)
        {
            return new HinhThucUngHo
            {
                MaHTUH = item.MaHTUH,
                TenHTUH = item.TenHTUH,
                DonViTinh = item.DonViTinh
            };
        }
    }
}