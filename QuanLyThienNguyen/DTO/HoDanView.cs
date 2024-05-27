using QuanLyThienNguyen.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class HoDanView
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

        public HoDanView() { }
        public HoDanView(string ma, string ten, bool gt, string cccd, string dc, string sdt, string diengiadinh)
        {
            this.MaHD = ma;
            this.HoTenChuHo = ten;
            this.GioiTinh = gt;
            this.CCCD = cccd;
            this.DiaChi = dc;
            this.SDT = sdt;
            this.DienGiaDinh = diengiadinh;
        }

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
        public static HoDan ToChange(HoDanView item)
        {
            return new HoDan
            {
                MaHD = item.MaHD,
                HoTenChuHo = item.HoTenChuHo,
                GioiTinh = item.GioiTinh,
                CCCD = item.CCCD,
                DiaChi = item.DiaChi,
                SDT = item.SDT,
                DienGiaDinh = item.DienGiaDinh
            };
        }
    }
}