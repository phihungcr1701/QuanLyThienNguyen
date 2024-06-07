using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyThienNguyen.Models
{
    public partial class ThanhVienDvuh
    {
        public string MaTvdvuh { get; set; }
        public string MaDvuh { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public string Cccd { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }

        public virtual DonViUngHo MaDvuhNavigation { get; set; }
    }
}
