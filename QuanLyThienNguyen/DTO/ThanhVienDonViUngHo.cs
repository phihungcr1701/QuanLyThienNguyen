using System;
using System.Collections.Generic;
using System.Data;
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

        public static List<string> items = new List<string>(new string[]
        {
            "Mã đơn vị ủng hộ", "Họ tên", "Giới tính", "Căn cước công dân", "Địa chỉ", "Số điện thoại"
        });

        public static DataTable RenameNameTable_FromSqlToDataGridView(DataTable datatable)
        {
            datatable.Columns["MaDVUH"].ColumnName = "Mã đơn vị ủng hộ";
            datatable.Columns["HoTen"].ColumnName = "Họ tên";
            datatable.Columns["GioiTinh"].ColumnName = "Giới tính";
            datatable.Columns["CCCD"].ColumnName = "Căn cước công dân";
            datatable.Columns["DiaChi"].ColumnName = "Địa chỉ";
            datatable.Columns["SDT"].ColumnName = "Số điện thoại";
            return datatable;
        }

        public static string RenameNameTable_FromDataGridViewToSql(string namecolumn)
        {
            if (namecolumn == "Mã đơn vị ủng hộ")
                return "MaDVUH";
            if (namecolumn == "Họ tên")
                return "HoTen";
            if (namecolumn == "Giới tính")
                return "GioiTinh";
            if (namecolumn == "Căn cước công dân")
                return "CCCD";
            if (namecolumn == "Địa chỉ")
                return "DiaChi";
            if (namecolumn == "Số điện thoại")
                return "SDT";
            return namecolumn;
        }

        public static ThanhVienDonViUngHo ConvertFromDataGridViewToObj(DataGridViewRow row)
        {
            ThanhVienDonViUngHo tvdvuh = new ThanhVienDonViUngHo();
            tvdvuh.MaDVUH = Convert.ToInt32(row.Cells["Mã đơn vị ủng hộ"].Value.ToString());
            tvdvuh.HoTen = row.Cells["Họ tên"].Value.ToString();
            tvdvuh.GioiTinh = Convert.ToInt32(row.Cells["Giới tính"].Value.ToString());
            tvdvuh.CCCD = row.Cells["Căn cước công dân"].Value.ToString();
            tvdvuh.DiaChi = row.Cells["Địa chỉ"].Value.ToString();
            tvdvuh.SDT = row.Cells["Số điện thoại"].Value.ToString();
            return tvdvuh;
        }
    }
}
