using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThienNguyen.DTO
{
    public class ThongKe
    {
        private int _MaDVUH;
        private int _MaHTUH;
        private string _TenDVUH;
        private string _TenHTUH;
        private double _TongSoLuongUH;
        private double _SoDuUH;
        private string _DonViTinh;

        public ThongKe() { }
        public ThongKe(int madvuh, int mahtuh, string tendvuh, string tenhtuh, double tongsoluong, double sodu, string donvitinh)
        {
            this.MaDVUH = madvuh;
            this.MaHTUH = mahtuh;
            this.TenDVUH = tendvuh;
            this.TenHTUH = tenhtuh;
            this.TongSoLuongUH = tongsoluong;
            this.SoDuUH = sodu;
            this.DonViTinh = donvitinh;
        }
        public int MaDVUH { get => _MaDVUH; set => _MaDVUH = value; }
        public int MaHTUH { get => _MaHTUH; set => _MaHTUH = value; }
        public string TenDVUH { get => _TenDVUH; set => _TenDVUH = value; }
        public string TenHTUH { get => _TenHTUH; set => _TenHTUH = value; }
        public double TongSoLuongUH { get => _TongSoLuongUH; set => _TongSoLuongUH = value; }
        public double SoDuUH { get => _SoDuUH; set => _SoDuUH = value; }
        public string DonViTinh { get => _DonViTinh; set => _DonViTinh = value; }
    }
}
