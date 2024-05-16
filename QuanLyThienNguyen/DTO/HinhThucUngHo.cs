using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class HinhThucUngHo
    {
        private int _MaHTUH;
        private string _TenHTUH;
        private string _DonViTinh;
        public int MaHTUH { get => _MaHTUH; set => _MaHTUH = value; }
        public string TenHTUH { get => _TenHTUH; set => _TenHTUH = value; }
        public string DonViTinh { get => _DonViTinh; set => _DonViTinh = value; }
        public HinhThucUngHo() { }
        public HinhThucUngHo(int ma = 0, string ten = null, string donvitinh = null) 
        {
            this.MaHTUH = ma;
            this.TenHTUH = ten;
            this.DonViTinh = donvitinh;
        }
        public HinhThucUngHo(DataRow row)
        {
            this.MaHTUH = Convert.ToInt32(row["MaHTUH"].ToString());
            this.TenHTUH = row["TenHTUH"].ToString();
            this.DonViTinh = row["DonViTinh"].ToString();
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

        public static HinhThucUngHo TransferDataGridViewRowToObject(DataGridViewRow row)
        {
            HinhThucUngHo htuh = new HinhThucUngHo();
            htuh.MaHTUH = Int32.Parse(row.Cells["Mã Hình Thức Ủng Hộ"].Value.ToString());
            htuh.TenHTUH = row.Cells["Tên Hình Thức Ủng Hộ"].Value.ToString();
            htuh.DonViTinh = row.Cells["Đơn Vị Tính"].Value.ToString();
            return htuh;
        }
    }
}