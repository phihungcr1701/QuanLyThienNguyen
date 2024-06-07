using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyThienNguyen.Models
{
    public partial class DotUngHo
    {
        public DotUngHo()
        {
            ChiTietUngHo = new HashSet<ChiTietUngHo>();
        }

        public string MaDuh { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public bool? DaKetThuc { get; set; }

        public virtual ICollection<ChiTietUngHo> ChiTietUngHo { get; set; }
    }
}
