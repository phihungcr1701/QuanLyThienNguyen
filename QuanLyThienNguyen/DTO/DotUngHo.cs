using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DTO
{
    internal class DotUngHo
    {
        private int _MaDUH;
        private DateTime _NgayBatDau;
        private DateTime _NgayKetThuc;

        public DotUngHo() { }
        public DotUngHo(int ma, DateTime ngaybatdau, DateTime ngayketthuc) 
        {
            this.MaDUH = ma;
            this.NgayBatDau = ngaybatdau;
            this.NgayKetThuc = ngayketthuc;
        }
        public int MaDUH { get => _MaDUH; set => _MaDUH = value; }
        public DateTime NgayBatDau { get => _NgayBatDau; set => _NgayBatDau = value;}
        public DateTime NgayKetThuc { get => _NgayKetThuc; set => _NgayKetThuc = value;}

        public List<string> items = new List<string>(new string[]
        {
            "MaDUH", "NgayBatDau", "NgayKetThuc"
        });
    }
}
