using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DTO
{
    internal class ChiTietUngHo
    {
        private int _MaCTUH;
        private int _MaDVUH;
        private int _MaDUH;
        private int _MaHD;
        private int _MaHTUH;
        private double _SoLuongUH;
        private double _SoLuongNUH;
        public int MaDVUH { get => _MaDVUH; set => _MaDVUH = value; }
        public int MaDUH { get => _MaDUH; set => _MaDUH = value; }
        public int MaHD { get => _MaHD; set => _MaHD = value; }
        public int MaHTUH { get => _MaHTUH; set => _MaHTUH = value; }
        public double SoLuongUH { get => _SoLuongUH; set => _SoLuongUH = value; }
        public double SoLuongNUH { get => _SoLuongNUH; set => _SoLuongNUH = value; }
        public int MaCTUH { get => _MaCTUH; set => _MaCTUH = value; }

        public ChiTietUngHo(int maCTUH, int maDVUH, int maDUH, int maHD, int maHTUH, double soLuongUH, double soLuongNUH)
        {
            MaCTUH = maCTUH;
            MaDVUH = maDVUH;
            MaDUH = maDUH;
            MaHD = maHD;
            MaHTUH = maHTUH;
            SoLuongUH = soLuongUH;
            SoLuongNUH = soLuongNUH;
        }
        public ChiTietUngHo(DataRow row)
        {
            MaCTUH = Convert.ToInt32(row["MaCTUH"].ToString());
            MaDVUH = Convert.ToInt32(row["MaDVUH"].ToString());
            MaDUH = Convert.ToInt32(row["MaDUH"].ToString());
            MaHD = Convert.ToInt32(row["MaHD"].ToString());
            MaHTUH = Convert.ToInt32(row["MaHTUH"].ToString());
            SoLuongUH = Convert.ToDouble(row["SoLuongUH"].ToString());
            SoLuongNUH = Convert.ToDouble(row["SoLuongNUH"].ToString());
        }
    }
}