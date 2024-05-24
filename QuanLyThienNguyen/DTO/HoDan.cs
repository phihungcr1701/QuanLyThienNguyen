using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class HoDan
    {
        private string _MaHD;
        private string _HoTenChuHo;
        private bool _GioiTinh;
        private string _CCCD;
        private string _DiaChi;
        private string _SDT;
        private string _DienGiaDinh;
        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string HoTenChuHo { get => _HoTenChuHo; set => _HoTenChuHo = value; }
        public bool GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string CCCD { get => _CCCD; set => _CCCD = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string DienGiaDinh { get => _DienGiaDinh; set => _DienGiaDinh = value; }
        

        public HoDan() { }
        public HoDan(string ma, string ten, bool gt, string cccd, string dc, string sdt, string diengiadinh)
        {
            this.MaHD = ma;
            this.HoTenChuHo = ten;
            this.GioiTinh = gt;
            this.CCCD = cccd;
            this.DiaChi = dc;
            this.SDT = sdt;
            this.DienGiaDinh = diengiadinh;
        }
        public HoDan(DataRow row)
        {
            this.MaHD = row["MaHD"].ToString();
            this.HoTenChuHo = row["HoTenChuHo"].ToString();
            this.GioiTinh = Convert.ToBoolean(row["GioiTinh"].ToString());
            this.CCCD = row["CCCD"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
            this.DienGiaDinh = row["DienGiaDinh"].ToString();
        }

        public static List<string> items = new List<string>(new string[]
        {
            "Mã hộ dân", "Họ tên chủ hộ", "Giới tính", "Căn cước công dân", "Địa chỉ", "Số điện thoại", "Diện gia đình"
        });
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