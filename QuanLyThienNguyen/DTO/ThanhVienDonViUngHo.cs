using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DTO
{
    internal class ThanhVienDonViUngHo
    {
        private int _MaDVUH;
        private string _HoTen;
        private int _GioiTinh;
        private int _CCCD;
        private string _DiaChi;
        private int _SDT;

        public ThanhVienDonViUngHo() { }
        public ThanhVienDonViUngHo(int ma, string ten, int gt, int cccd, string dc, int sdt)
        {
            this.MaDVUH = ma;
            this.HoTen = ten;
            this.GioiTinh = gt;
            this.CCCD = cccd;
            this.DiaChi = dc;
            this.SDT = sdt;
        }
        public int MaDVUH { get => _MaDVUH; set => _MaDVUH = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public int GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public int CCCD { get => _CCCD; set => _CCCD = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public int SDT { get => _SDT; set => _SDT = value; }

        public List<string> items = new List<string>(new string[]
        {
            "MaDVUH", "HoTen", "GioiTinh", "CCCD", "DiaChi", "SDT"
        });
    }
}
