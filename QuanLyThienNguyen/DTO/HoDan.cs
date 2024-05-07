﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DTO
{
    internal class HoDan
    {
        private int _MaHD;
        private string _HoTenChuHo;
        private int _GioiTinh;
        private int _CCCD;
        private string _DiaChi;
        private int _SDT;
        private string _DienGiaDinh;

        public HoDan() { }
        public HoDan(int ma, string ten, int gt, int cccd, string dc, int sdt, string diengiadinh)
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
        public int CCCD { get => _CCCD; set => _CCCD = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public int SDT { get => _SDT; set => _SDT = value; }
        public string DienGiaDinh { get => _DienGiaDinh; set => _DienGiaDinh = value; }

        public List<string> items = new List<string>(new string[]
        {
            "MaHD", "HoTenChuHo", "GioiTinh", "CCCD", "DiaChi", "SDT", "DienGiaDinh"
        });
    }
}
