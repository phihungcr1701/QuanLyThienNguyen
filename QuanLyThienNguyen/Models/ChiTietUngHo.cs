using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyThienNguyen.Models
{
    public partial class ChiTietUngHo
    {
        public string MaCtuh { get; set; }
        public string TênHoatDong { get; set; }
        public string MaDvuh { get; set; }
        public string MaDuh { get; set; }
        public string MaHd { get; set; }
        public string MaHtuh { get; set; }
        public double? SoLuongUh { get; set; }
        public double? SoLuongNuh { get; set; }
        public string MoTa { get; set; }
        public byte[] AnhHoatDong { get; set; }

        public virtual DotUngHo MaDuhNavigation { get; set; }
        public virtual DonViUngHo MaDvuhNavigation { get; set; }
        public virtual HoDan MaHdNavigation { get; set; }
        public virtual HinhThucUngHo MaHtuhNavigation { get; set; }
    }
}
