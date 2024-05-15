
using System;
using System.Collections.Generic;
using System.Data;
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

        public static List<string> items = new List<string>(new string[]
        {
            "Mã đợt ủng hộ", "Ngày bắt đầu", "Ngày kết thúc"
        });

        public static DataTable RenameNameTable_FromSqlToDataGridView(DataTable datatable)
        {
            datatable.Columns["MaDUH"].ColumnName = "Mã đợt ủng hộ";
            datatable.Columns["NgayBatDau"].ColumnName = "Ngày bắt đầu";
            datatable.Columns["NgayKetThuc"].ColumnName = "Ngày kết thúc";
            return datatable;
        }

        public static string RenameNameTable_FromDataGridViewToSql(string namecolumn)
        {
            if (namecolumn == "Mã đợt ủng hộ")
                return "MaDVUH";
            if (namecolumn == "Ngày bắt đầu")
                return "NgayBatDau";
            if (namecolumn == "Ngày kết thúc")
                return "NgayKetThuc";
            return namecolumn;
        }

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
