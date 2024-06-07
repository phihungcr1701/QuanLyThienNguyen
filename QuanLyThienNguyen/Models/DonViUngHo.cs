using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyThienNguyen.Models
{
    public partial class DonViUngHo
    {
        public DonViUngHo()
        {
            ChiTietUngHo = new HashSet<ChiTietUngHo>();
            ThanhVienDvuh = new HashSet<ThanhVienDvuh>();
            ThongKe = new HashSet<ThongKe>();
        }

        public string MaDvuh { get; set; }
        public string TenDonVi { get; set; }
        public string DiaChiDonVi { get; set; }
        public string SdtdonVi { get; set; }

        public virtual ICollection<ChiTietUngHo> ChiTietUngHo { get; set; }
        public virtual ICollection<ThanhVienDvuh> ThanhVienDvuh { get; set; }
        public virtual ICollection<ThongKe> ThongKe { get; set; }
    }
}
