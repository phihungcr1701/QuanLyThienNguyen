using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThienNguyen.DTO
{
    public class HinhThucUngHo
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
        public static HinhThucUngHo TransferDataGridViewRowToObject(DataGridViewRow row)
        {
            HinhThucUngHo htuh = new HinhThucUngHo();
            htuh.MaHTUH = Int32.Parse(row.Cells["Mã Hình Thức Ủng Hộ"].Value.ToString());
            htuh.TenHTUH = row.Cells["Tên Hình Thức Ủng Hộ"].Value.ToString();
            htuh.DonViTinh = row.Cells["Đơn Vị Tính"].Value.ToString();
            return htuh;
        }
    }
}
