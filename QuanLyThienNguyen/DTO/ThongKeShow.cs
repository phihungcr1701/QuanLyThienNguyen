using System;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class ThongKeShow
    {
        private string _TenDVUH;
        private string _TenHTUH;
        private double _TongSoLuongUH;
        private double _SoDuUH;
        private string _DonViTinh;
        public string TenDVUH { get => _TenDVUH; set => _TenDVUH = value; }
        public string TenHTUH { get => _TenHTUH; set => _TenHTUH = value; }
        public double TongSoLuongUH { get => _TongSoLuongUH; set => _TongSoLuongUH = value; }
        public double SoDuUH { get => _SoDuUH; set => _SoDuUH = value; }
        public string DonViTinh { get => _DonViTinh; set => _DonViTinh = value; }
        public ThongKeShow() { }
        public ThongKeShow(string tendvuh, string tenhtuh, double tongsoluong, double sodu, string donvitinh)
        {
            this.TenDVUH = tendvuh;
            this.TenHTUH = tenhtuh;
            this.TongSoLuongUH = tongsoluong;
            this.SoDuUH = sodu;
            this.DonViTinh = donvitinh;
        }
        public ThongKeShow(DataRow row)
        {
            this.TenDVUH = row["TenDonVi"].ToString();
            this.TenHTUH = row["TenHTUH"].ToString();
            this.TongSoLuongUH = Convert.ToDouble(row["TongSoLuongUH"].ToString());
            this.SoDuUH = Convert.ToDouble(row["SoDuUH"].ToString());
            this.DonViTinh = row["DonViTinh"].ToString();
        }
        
    }

}
