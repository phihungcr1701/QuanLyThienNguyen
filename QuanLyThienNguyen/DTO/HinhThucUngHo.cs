using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DTO
{
    internal class HinhThucUngHo
    {
        private int _MaHTUH;
        private string _TenHTUH;
        private string _DonViTinh;

        public HinhThucUngHo() { }
        public HinhThucUngHo(int ma, string ten, string donvitinh) 
        {
            this.MaHTUH = ma;
            this.TenHTUH = ten;
            this.DonViTinh = donvitinh;
        }
        public int MaHTUH { get => _MaHTUH; set => _MaHTUH = value; }
        public string TenHTUH { get => _TenHTUH; set => _TenHTUH = value; }
        public string DonViTinh { get => _DonViTinh; set => _DonViTinh = value;}

        public List<string> items = new List<string>(new string[]
        {
            "MaHTUH", "TenHTUH", "DonViTinh"
        });
    }
}
