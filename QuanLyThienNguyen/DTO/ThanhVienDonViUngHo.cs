using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThienNguyen.DTO
{
    public class ThanhVienDonViUngHo
    {
        private int _MaDVUH;
        private string _HoTen;
        private int _GioiTinh;
        private string _CCCD;
        private string _DiaChi;
        private string _SDT;

        public ThanhVienDonViUngHo() { }
        public ThanhVienDonViUngHo(int ma, string ten, int gt, string cccd, string dc, string sdt)
        {
            this.MaDVUH = ma;
            this.HoTen = ten;
            this.GioiTinh = gt;
            this.CCCD = cccd;
            this.DiaChi = dc;
            this.SDT = sdt;
        }
        public int MaDVUH { get => _MaDVUH; set => _MaDVUH = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public int GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string CCCD { get => _CCCD; set => _CCCD = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }

        public List<string> items = new List<string>(new string[]
        {
            "MaDVUH", "HoTen", "GioiTinh", "CCCD", "DiaChi", "SDT"
        });

        public static ThanhVienDonViUngHo TransferDataGridViewRowToObject(DataGridViewRow row)
        {
            ThanhVienDonViUngHo tvdvuh = new ThanhVienDonViUngHo();
            tvdvuh.MaDVUH = Int32.Parse(row.Cells["Mã Đơn Vị Ủng Hộ"].Value.ToString());
            tvdvuh.HoTen = row.Cells["Họ Tên"].Value.ToString();
            tvdvuh.GioiTinh = row.Cells["Giới Tính"].Value.ToString() == "Nam" ? 0 : 1;
            tvdvuh.CCCD = row.Cells["CCCD"].Value.ToString();
            tvdvuh.DiaChi = row.Cells["Địa Chỉ"].Value.ToString();
            tvdvuh.SDT = row.Cells["Số Điện Thoại"].Value.ToString();
            return tvdvuh;
        }
    }
}
