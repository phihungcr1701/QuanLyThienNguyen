using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DTO
{
    public class ChiTietUngHoView
    {
        private string _MaCTUH;
        private string _MaDVUH;
        private string _MaDUH;
        private string _MaHD;
        private string _MaHTUH;
        private double _SoLuongUH;
        private double _SoLuongNUH;

        public ChiTietUngHoView(string maDVUH, string maDUH, string maHD, string maHTUH,
            double soLuongUH, double soLuongNUH)
        {
            MaDVUH = maDVUH;
            MaDUH = maDUH;
            MaHD = maHD;
            MaHTUH = maHTUH;
            SoLuongUH = soLuongUH;
            SoLuongNUH = soLuongNUH;
        }

        public ChiTietUngHoView(string maCTUH, string maDVUH, string maDUH, string maHD, string maHTUH,
            double soLuongUH, double soLuongNUH)
        {
            this.MaCTUH = maCTUH;
            MaDVUH = maDVUH;
            MaDUH = maDUH;
            MaHD = maHD;
            MaHTUH = maHTUH;
            SoLuongUH = soLuongUH;
            SoLuongNUH = soLuongNUH;
        }

        public string MaCTUH { get => _MaCTUH; set => _MaCTUH = value; }
        public string MaDVUH { get => _MaDVUH; set => _MaDVUH = value; }
        public string MaDUH { get => _MaDUH; set => _MaDUH = value; }
        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaHTUH { get => _MaHTUH; set => _MaHTUH = value; }
        public double SoLuongUH { get => _SoLuongUH; set => _SoLuongUH = value; }
        public double SoLuongNUH { get => _SoLuongNUH; set => _SoLuongNUH = value; }
    }
}