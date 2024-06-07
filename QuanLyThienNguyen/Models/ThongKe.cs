using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyThienNguyen.Models
{
    public partial class ThongKe
    {
        public int MaTk { get; set; }
        public string MaDvuh { get; set; }
        public string MaHtuh { get; set; }
        public double? TongSoLuongUh { get; set; }
        public double? SoDuUh { get; set; }

        public virtual DonViUngHo MaDvuhNavigation { get; set; }
        public virtual HinhThucUngHo MaHtuhNavigation { get; set; }
    }
}
