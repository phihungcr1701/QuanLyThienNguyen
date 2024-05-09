using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThienNguyen.DTO
{
    public class DotUngHo
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
        public static DotUngHo TransferDataGridViewRowToObject(DataGridViewRow row)
        {
            DotUngHo duh = new DotUngHo();
            duh.MaDUH = Int32.Parse(row.Cells["Mã Đợt Ủng Hộ"].Value.ToString());
            duh.NgayBatDau = DateTime.Parse(row.Cells["Ngày Bắt Đầu"].Value.ToString());
            duh.NgayKetThuc = DateTime.Parse(row.Cells["Ngày Kết Thúc"].Value.ToString());
            return duh;
        }
    }
}
