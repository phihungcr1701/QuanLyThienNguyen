using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyThienNguyen.Models
{
    public partial class HoDan
    {
        public HoDan()
        {
            ChiTietUngHo = new HashSet<ChiTietUngHo>();
        }

        public string MaHd { get; set; }
        public string HoTenChuHo { get; set; }
        public bool GioiTinh { get; set; }
        public string Cccd { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string DienGiaDinh { get; set; }

        public virtual ICollection<ChiTietUngHo> ChiTietUngHo { get; set; }
    }
}
