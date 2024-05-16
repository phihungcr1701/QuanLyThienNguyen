using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class DotUngHo
    {
        private int _MaDUH;
        private DateTime _NgayBatDau;
        private DateTime _NgayKetThuc;
        public int MaDUH { get => _MaDUH; set => _MaDUH = value; }
        public DateTime NgayBatDau { get => _NgayBatDau; set => _NgayBatDau = value; }
        public DateTime NgayKetThuc { get => _NgayKetThuc; set => _NgayKetThuc = value; }

        public DotUngHo() { }
        public DotUngHo(int ma, DateTime ngaybatdau, DateTime ngayketthuc) 
        {
            this.MaDUH = ma;
            this.NgayBatDau = ngaybatdau;
            this.NgayKetThuc = ngayketthuc;
        }
        public DotUngHo(DataRow row)
        {
            this.MaDUH = Convert.ToInt32(row["MaDUH"].ToString());
            this.NgayBatDau = Convert.ToDateTime(row["NgayBatDau"].ToString());
            this.NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"].ToString());
        }

        public static List<string> items = new List<string>(new string[]
        {
            "Mã đợt ủng hộ", "Ngày bắt đầu", "Ngày kết thúc"
        });
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
    }
}