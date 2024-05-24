using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DTO
{
    public class DonViUngHo
    {
        private string _MaDVUH;
        private string _TenDonVi;
        private string _DiaChiDonVi;
        private string _SDTDonVi;
        
        public string TenDonVi { get => _TenDonVi; set => _TenDonVi = value; }
        public string DiaChiDonVi { get => _DiaChiDonVi; set => _DiaChiDonVi = value; }
        public string SDTDonVi { get => _SDTDonVi; set => _SDTDonVi = value; }
        public string MaDVUH { get => _MaDVUH; set => _MaDVUH = value; }

        public DonViUngHo() { }
        public DonViUngHo(string ma, string ten, string dc, string sdt)
        {
            this.MaDVUH = ma;
            this.TenDonVi = ten;
            this.DiaChiDonVi = dc;
            this.SDTDonVi = sdt;
        }
        public DonViUngHo(DataRow row)
        {
            this.MaDVUH = row["MaDVUH"].ToString();
            this.TenDonVi = row["TenDonVi"].ToString();
            this.DiaChiDonVi = row["DiaChiDonVi"].ToString();
            this.SDTDonVi = row["SDTDonVi"].ToString();
        }

        public static List<string> items = new List<string>(new string[]
        {
            "Mã đơn vị ủng hộ", "Tên đơn vị", "Địa chỉ đơn vị", "Số điện thoại đơn vị"
        });
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