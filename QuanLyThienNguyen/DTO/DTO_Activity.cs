using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using QuanLyThienNguyen.BBL;

namespace QuanLyThienNguyen.DTO
{
    internal class DTO_Activity
    {
        public string MaCTUH { get; set; }
        public string TenDonVi { get; set; }
        public string HoTenChuHo { get; set; }
        public string TenHTUH { get; set; }
        public double SoLuongUH { get; set; }
        public double SoLuongNUH { get; set; }
        public string DonViTinh { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public DTO_Activity(string maCTUH, string MaDUH, string MaDVUH, string MaHoDan, string MaHTUH, double SLUH, double SLNUH)
        {
            MaCTUH = maCTUH;
            TenDonVi = BBL_DonViUngHo.Instance.GetDonViUngHo(MaDVUH).TenDonVi;
            HoTenChuHo = BBL_HoDan.Instance.GetHoDan(MaHoDan).HoTenChuHo;
            TenHTUH = BBL_HinhThucUngHo.Instance.GetHinhThucUngHo(MaHTUH).TenHTUH;
            SoLuongUH = SLUH;
            SoLuongNUH = SLNUH;
            DonViTinh = BBL.BBL_HinhThucUngHo.Instance.GetHinhThucUngHo(MaHTUH).DonViTinh;
            NgayBatDau = BBL_DotUngHo.Instance.GetDotUngHo(MaDUH).NgayBatDau;
            NgayKetThuc = BBL_DotUngHo.Instance.GetDotUngHo(MaDUH).NgayKetThuc;
        }
    }
}