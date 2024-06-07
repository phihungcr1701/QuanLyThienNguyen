using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyThienNguyen.Models
{
    public partial class HinhThucUngHo
    {
        public HinhThucUngHo()
        {
            ChiTietUngHo = new HashSet<ChiTietUngHo>();
            ThongKe = new HashSet<ThongKe>();
        }

        public string MaHtuh { get; set; }
        public string TenHtuh { get; set; }
        public string DonViTinh { get; set; }

        public virtual ICollection<ChiTietUngHo> ChiTietUngHo { get; set; }
        public virtual ICollection<ThongKe> ThongKe { get; set; }
    }
}
