using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using QuanLyThienNguyen.GUI.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_Information
    {
        private static BBL_Information instance;

        public static BBL_Information Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_Information();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public BBL_Information() { }
        public string RenameNameTable_FromDataGridViewToSQL(string nametable)
        {
            if (nametable == "Đơn vị ủng hộ")
                return "DonViUngHo";
            if (nametable == "Thành viên đơn vị ủng hộ")
                return "ThanhVienDVUH";
            if (nametable == "Hộ dân")
                return "HoDan";
            if (nametable == "Đợt ủng hộ")
                return "DotUngHo";
            if (nametable == "Hình thức ủng hộ")
                return "HinhThucUngHo";
            return nametable;
        }
        public DataTable View(string nametable) 
        {
            nametable = RenameNameTable_FromDataGridViewToSQL(nametable);
            if (nametable == "DonViUngHo")
                return DonViUngHo.RenameNameTable_FromSqlToDataGridView(DAL_Information.Instance.View(nametable));
            if (nametable == "ThanhVienDVUH")
                return ThanhVienDonViUngHo.RenameNameTable_FromSqlToDataGridView(DAL_Information.Instance.View(nametable));
            if (nametable == "HoDan")
                return HoDan.RenameNameTable_FromSqlToDataGridView(DAL_Information.Instance.View(nametable));
            if (nametable == "DotUngHo")
                return DotUngHo.RenameNameTable_FromSqlToDataGridView(DAL_Information.Instance.View(nametable));
            if (nametable == "HinhThucUngHo")
                return HinhThucUngHo.RenameNameTable_FromSqlToDataGridView(DAL_Information.Instance.View(nametable));
            return DAL_Information.Instance.View(nametable);
        }

        public DataTable TimKiem_SapXep(string nametable, string text, string namecolumn)
        {
            DataTable table = View(nametable);
            List<DataRow> rows = new List<DataRow>();

            foreach (DataRow row in table.Rows)
            {
                bool kt = false;
                foreach (DataColumn column in table.Columns)
                {
                    if (row[column].ToString().Contains(text))
                    {
                        kt = true;
                        break;
                    }
                }
                if (kt == false)
                    rows.Add(row);
            }

            foreach (DataRow row in rows)
                table.Rows.Remove(row);

            return Sort(table, nametable, namecolumn);
        }

        public DataTable Sort(DataTable datarow, string nametable, string namecolumn)
        {
            return datarow.AsEnumerable().OrderBy(row => row.Field<object>(namecolumn)).CopyToDataTable();
        }

        /// Đơn vị ủng hộ
        public DonViUngHo TruyVan_DVUH(string ma)
        {
            DataTable datatable = DAL_Information.Instance.View("DonViUngHo");
            DonViUngHo obj = new DonViUngHo();
            
            foreach (DataRow row in datatable.Rows)
            {
                if (row["MaDVUH"].ToString().Equals(ma))
                {
                    obj.MaDVUH = Convert.ToInt32(row["MaDVUH"].ToString());
                    obj.TenDonVi = row["TenDonVi"].ToString();
                    obj.DiaChiDonVi = row["DiaChiDonVi"].ToString();
                    obj.SDTDonVi = row["SDTDonVi"].ToString();
                } 
            }
            return obj;
        } 
        public void Add_DVUH(DonViUngHo dvuh)
        {
            DAL_Information.Instance.Add_DVUH(dvuh);
        }
        public void Update_DVUH(DonViUngHo dvuh)
        {
            DAL_Information.Instance.Update_DVUH(dvuh);
        }
        public void Delete_DVUH(string ma)
        {
            DonViUngHo dvuh = TruyVan_DVUH(ma);
            if (System.Windows.Forms.MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + dvuh.MaDVUH + " | " + dvuh.TenDonVi + " | " + dvuh.DiaChiDonVi + " | " + dvuh.SDTDonVi, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_Information.Instance.Delete_DVUH(ma);
            }
        }

        /// Thành viên đơn vị ủng hộ
        public void Add_TVDVUH(ThanhVienDonViUngHo tvdvuh)
        {
            DAL_Information.Instance.Add_TVDVUH(tvdvuh);
        }
        public void Update_TVDVUH(ThanhVienDonViUngHo tvdvuh, ThanhVienDonViUngHo tvdvuhchange)
        {
            DAL_Information.Instance.Update_TVDVUH(tvdvuh, tvdvuhchange);
        }
        public void Delete_TVDVUH(ThanhVienDonViUngHo tvdvuh)
        {
            if (System.Windows.Forms.MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + tvdvuh.MaDVUH + " | " + tvdvuh.HoTen + " | " + tvdvuh.GioiTinh + " | " + tvdvuh.CCCD + " | " + tvdvuh.DiaChi + " | " + tvdvuh.SDT, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_Information.Instance.Delete_TVDVUH(tvdvuh);
            }
        }
        public bool Check_TVDVUH(ThanhVienDonViUngHo tvdvuh)
        {
            if (DAL_Information.Instance.Check_TVDVUH(tvdvuh) == 0)
                return true;
            return false;
        }

        /// Hộ dân
        public HoDan TruyVan_HD(string ma)
        {
            DataTable datatable = DAL_Information.Instance.View("HoDan");
            HoDan obj = new HoDan();

            foreach (DataRow row in datatable.Rows)
            {
                if (row["MaHD"].ToString().Equals(ma))
                {
                    obj.MaHD = Convert.ToInt32(row["MaHD"].ToString());
                    obj.HoTenChuHo = row["HoTenChuHo"].ToString();
                    obj.CCCD = row["CCCD"].ToString();
                    obj.GioiTinh = Convert.ToInt32(row["GioiTinh"].ToString());
                    obj.DiaChi = row["DiaChi"].ToString();
                    obj.SDT = row["SDT"].ToString();
                    obj.DienGiaDinh = row["DienGiaDinh"].ToString();
                }
            }
            return obj;
        }
        public void Add_HD(HoDan hd)
        {
            DAL_Information.Instance.Add_HD(hd);
        }
        public void Update_HD(HoDan hd)
        {
            DAL_Information.Instance.Update_HD(hd);
        }
        public void Delete_HD(string ma)
        {
            HoDan hd = TruyVan_HD(ma);
            if (System.Windows.Forms.MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + hd.MaHD + " | " + hd.HoTenChuHo + " | " + hd.GioiTinh + " | " + hd.CCCD + " | " + hd.DiaChi + " | " + hd.SDT, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_Information.Instance.Delete_HD(ma);
            }
        }

        /// Đợt ủng hộ
        public DotUngHo TruyVan_DUH(string ma)
        {
            DataTable datatable = DAL_Information.Instance.View("DotUngHo");
            DotUngHo obj = new DotUngHo();

            foreach (DataRow row in datatable.Rows)
            {
                if (row["MaDUH"].ToString().Equals(ma))
                {
                    obj.MaDUH = Convert.ToInt32(row["MaDUH"].ToString());
                    obj.NgayBatDau = Convert.ToDateTime(row["NgayBatDau"].ToString());
                    obj.NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"].ToString());
                }
            }
            return obj;
        }
        public void Add_DUH(DotUngHo duh)
        {
            DAL_Information.Instance.Add_DUH(duh);
        }
        public void Update_DUH(DotUngHo duh)
        {
            DAL_Information.Instance.Update_DUH(duh);
        }
        public void Delete_DUH(string ma)
        {
            DotUngHo duh = TruyVan_DUH(ma);
            if (System.Windows.Forms.MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + duh.MaDUH + " | " + duh.NgayBatDau + " | " + duh.NgayKetThuc, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_Information.Instance.Delete_DUH(ma);
            }
        }

        /// Hình thức ủng hộ
        public HinhThucUngHo TruyVan_HTUH(string ma)
        {
            DataTable datatable = DAL_Information.Instance.View("HinhThucUngHo");
            HinhThucUngHo obj = new HinhThucUngHo();

            foreach (DataRow row in datatable.Rows)
            {
                if (row["MaHTUH"].ToString().Equals(ma))
                {
                    obj.MaHTUH = Convert.ToInt32(row["MaHTUH"].ToString());
                    obj.TenHTUH = row["TenHTUH"].ToString();
                    obj.DonViTinh = row["DonViTinh"].ToString();
                }
            }
            return obj;
        }
        public void Add_HTUH(HinhThucUngHo htuh)
        {
            DAL_Information.Instance.Add_HTUH(htuh);
        }
        public void Update_HTUH(HinhThucUngHo htuh)
        {
            DAL_Information.Instance.Update_HTUH(htuh);
        }
        public void Delete_HTUH(string ma)
        {
            HinhThucUngHo htuh = TruyVan_HTUH(ma);
            if (System.Windows.Forms.MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + htuh.MaHTUH + " | " + htuh.TenHTUH + " | " + htuh.DonViTinh, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_Information.Instance.Delete_HTUH(ma);
            }
        }
    }
}
