using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DTO
{
    internal class Activity
    {
        public string TenDonVi { get; set; }
        public string HoTenChuHo { get; set; }
        public string TenHTUH { get; set; }
        public double SoLuongUH { get; set; }
        public double SoLuongNUH { get; set; }
        public string DonViTinh { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
    }
}
