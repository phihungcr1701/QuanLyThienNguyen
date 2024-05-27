using QuanLyThienNguyen.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class DotUngHoView
    {
        private string _MaDUH;
        private DateTime _NgayBatDau;
        private DateTime _NgayKetThuc;
        public string MaDUH { get => _MaDUH; set => _MaDUH = value; }
        public DateTime NgayBatDau { get => _NgayBatDau; set => _NgayBatDau = value; }
        public DateTime NgayKetThuc { get => _NgayKetThuc; set => _NgayKetThuc = value; }

        public DotUngHoView() { }
        public DotUngHoView(string ma, DateTime ngaybatdau, DateTime ngayketthuc)
        {
            this.MaDUH = ma;
            this.NgayBatDau = ngaybatdau;
            this.NgayKetThuc = ngayketthuc;
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
        public static DotUngHo ToChange(DotUngHoView item)
        {
            return new DotUngHo
            {
                MaDUH = item.MaDUH,
                NgayBatDau = item.NgayBatDau,
                NgayKetThuc = item.NgayKetThuc
            };
        }
    }
}