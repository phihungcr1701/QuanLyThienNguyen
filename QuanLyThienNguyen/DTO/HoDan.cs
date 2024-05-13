using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThienNguyen.DTO
{
    public class HoDan
    {
        private int _MaHD;
        private string _HoTenChuHo;
        private int _GioiTinh;
        private string _CCCD;
        private string _DiaChi;
        private string _SDT;
        private string _DienGiaDinh;

        public HoDan() { }
        public HoDan(int ma, string ten, int gt, string cccd, string dc, string sdt, string diengiadinh)
        {
            this.MaHD = ma;
            this.HoTenChuHo = ten;
            this.GioiTinh = gt;
            this.CCCD = cccd;
            this.DiaChi = dc;
            this.SDT = sdt;
            this.DienGiaDinh = diengiadinh;
        }
        public int MaHD { get => _MaHD; set => _MaHD = value; }
        public string HoTenChuHo { get => _HoTenChuHo; set => _HoTenChuHo = value; }
        public int GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string CCCD { get => _CCCD; set => _CCCD = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string DienGiaDinh { get => _DienGiaDinh; set => _DienGiaDinh = value; }

        public static List<string> items = new List<string>(new string[]
        {
            "Mã hộ dân", "Họ tên chủ hộ", "Giới tính", "Căn cước công dân", "Địa chỉ", "Số điện thoại", "Diện gia đình"
        });

        public static DataTable RenameNameTable_FromSqlToDataGridView(DataTable datatable)
        {
            datatable.Columns["MaHD"].ColumnName = "Mã hộ dân";
            datatable.Columns["HoTenChuHo"].ColumnName = "Họ tên chủ hộ";
            datatable.Columns["GioiTinh"].ColumnName = "Giới tính";
            datatable.Columns["CCCD"].ColumnName = "Căn cước công dân";
            datatable.Columns["DiaChi"].ColumnName = "Địa chỉ";
            datatable.Columns["SDT"].ColumnName = "Số điện thoại";
            datatable.Columns["DienGiaDinh"].ColumnName = "Diện gia đình";
            return datatable;
        }

        public static string RenameNameTable_FromDataGridViewToSql(string namecolumn)
        {
            if (namecolumn == "Mã hộ dân")
                return "MaHD";
            if (namecolumn == "Tên hình thức ủng hộ")
                return "HoTenChuHo";
            if (namecolumn == "Đơn vị tính")
                return "GioiTinh";
            if (namecolumn == "Căn cước công dân")
                return "CCCD";
            if (namecolumn == "Địa chỉ")
                return "DiaChi";
            if (namecolumn == "Số điện thoại")
                return "SoDienThoai";
            if (namecolumn == "Diện gia đình")
                return "DienGiaDinh";
            return namecolumn;
        }
    }
}
