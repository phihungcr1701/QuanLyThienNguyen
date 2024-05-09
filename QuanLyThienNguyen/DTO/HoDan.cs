using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThienNguyen.DTO
{
    public class HoDan
    {
        private int _MaHD;
        private string _HoTenChuHo;
        private int _GioiTinh;
        private string _CCCD;
        private string _DiaChi;
        private string _SDT;
        private string _DienGiaDinh;

        public HoDan() { }
        public HoDan(int ma, string ten, int gt, string cccd, string dc, string sdt, string diengiadinh)
        {
            this.MaHD = ma;
            this.HoTenChuHo = ten;
            this.GioiTinh = gt;
            this.CCCD = cccd;
            this.DiaChi = dc;
            this.SDT = sdt;
            this.DienGiaDinh = diengiadinh;
        }
        public int MaHD { get => _MaHD; set => _MaHD = value; }
        public string HoTenChuHo { get => _HoTenChuHo; set => _HoTenChuHo = value; }
        public int GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string CCCD { get => _CCCD; set => _CCCD = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string DienGiaDinh { get => _DienGiaDinh; set => _DienGiaDinh = value; }

        public List<string> items = new List<string>(new string[]
        {
            "MaHD", "HoTenChuHo", "GioiTinh", "CCCD", "DiaChi", "SDT", "DienGiaDinh"
        });
        public static HoDan TransferDataGridViewRowToObject(DataGridViewRow row)
        {
            HoDan hd = new HoDan();
            hd.MaHD = Int32.Parse(row.Cells["Mã Hộ Dân"].Value.ToString());
            hd.HoTenChuHo = row.Cells["Họ Tên Chủ Hộ"].Value.ToString();
            hd.GioiTinh = row.Cells["Giới Tính"].Value.ToString() == "Nam" ? 0 : 1;
            hd.CCCD = row.Cells["CCCD"].Value.ToString();
            hd.DiaChi = row.Cells["Địa Chỉ"].Value.ToString();
            hd.SDT = row.Cells["Số Điện Thoại"].Value.ToString();
            hd.DienGiaDinh = row.Cells["Diện Gia Đình"].Value.ToString();
            return hd;
        }
    }
}
