using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace QuanLyThienNguyen.DTO
{
    public class DonViUngHo
    {
        private int _MaDVUH;
        private string _TenDonVi;
        private string _DiaChiDonVi;
        private string _SDTDonVi;

        public DonViUngHo() { }
        public DonViUngHo(int ma, string ten, string dc, string sdt)
        {
            this.MaDVUH = ma;
            this.TenDonVi = ten;
            this.DiaChiDonVi = dc;
            this.SDTDonVi = sdt;
        }
        public int MaDVUH { get => _MaDVUH; set => _MaDVUH = value; }
        public string TenDonVi { get => _TenDonVi; set => _TenDonVi = value; }
        public string DiaChiDonVi { get => _DiaChiDonVi; set => _DiaChiDonVi = value; }
        public string SDTDonVi { get => _SDTDonVi; set => _SDTDonVi = value; }

        public static List<string> items = new List<string>(new string[]
        {
            "Mã đơn vị ủng hộ", "Tên đơn vị", "Địa chỉ đơn vị", "Số điện thoại đơn vị"
        });

        public static DataTable RenameNameTable_FromSqlToDataGridView(DataTable datatable)
        {
            datatable.Columns["MaDVUH"].ColumnName = "Mã đơn vị ủng hộ";
            datatable.Columns["TenDonVi"].ColumnName = "Tên đơn vị";
            datatable.Columns["DiaChiDonVi"].ColumnName = "Địa chỉ đơn vị";
            datatable.Columns["SDTDonVi"].ColumnName = "Số điện thoại đơn vị";
            return datatable;
        }

        public static string RenameNameTable_FromDataGridViewToSql(string namecolumn)
        {
            if (namecolumn == "Mã đơn vị ủng hộ")
                return "MaDVUH";
            if (namecolumn == "Tên đơn vị")
                return "TenDonVi";
            if (namecolumn == "Địa chỉ đơn vị")
                return "DiaChiDonVi";
            if (namecolumn == "Số điện thoại đơn vị")
                return "SDTDonVi";
            return namecolumn;
        }
    }
}
