using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_ThanhVienDVUH
    {
        private static BBL_ThanhVienDVUH instance;
        public static BBL_ThanhVienDVUH Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_ThanhVienDVUH();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public BBL_ThanhVienDVUH() { }
        public List<ThanhVienDVUH> GetAllThanhVienDVUH(string text, string namecolumn)
        {
            List<ThanhVienDVUH> view = new List<ThanhVienDVUH>();

            foreach (ThanhVienDVUH item in Sort(DAL_ThanhVienDVUH.Instance.GetAllThanhVienDVUH(), namecolumn))
            {
                Type type = item.GetType();
                foreach (PropertyInfo property in type.GetProperties())
                    if (property.GetValue(item).ToString().ToLower().Contains(text.ToLower()))
                    {
                        view.Add(item);
                        break;
                    }
            }

            return view;
        }
        public List<ThanhVienDVUH> Sort(List<ThanhVienDVUH> list, string namecolumn)
        {
            List<ThanhVienDVUH> sort = list;
            switch (namecolumn)
            {
                case "MaDVUH":
                    sort.Sort((x, y) => x.MaDVUH.CompareTo(y.MaDVUH));
                    break;
                case "HoTen":
                    sort.Sort((x, y) => x.HoTen.CompareTo(y.HoTen));
                    break;
                case "GioiTinh":
                    sort.Sort((x, y) => x.GioiTinh.CompareTo(y.GioiTinh));
                    break;
                case "CCCD":
                    sort.Sort((x, y) => x.CCCD.CompareTo(y.CCCD));
                    break;
                case "DiaChi":
                    sort.Sort((x, y) => x.DiaChi.CompareTo(y.DiaChi));
                    break;
                case "SDT":
                    sort.Sort((x, y) => x.SDT.CompareTo(y.SDT));
                    break;
            }
            return sort;
        }
        public bool Check(ThanhVienDVUH tvdvuh)
        {
            if (DAL_ThanhVienDVUH.Instance.Check(tvdvuh) != 0)
                return false;
            return true;
        }
        public void Add(ThanhVienDVUH tvdvuh)
        {
            DAL_ThanhVienDVUH.Instance.Add(tvdvuh);
        }
        public void Update(ThanhVienDVUH tvdvuh, ThanhVienDVUH tvdvuhchange)
        {
            DAL_ThanhVienDVUH.Instance.Update(tvdvuh, tvdvuhchange);
        }
        public void Delete(ThanhVienDVUH tvdvuh)
        {
            if (System.Windows.Forms.MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + tvdvuh.MaDVUH + " | " + tvdvuh.HoTen + " | " + tvdvuh.GioiTinh + " | " + tvdvuh.CCCD + " | " + tvdvuh.DiaChi + " | " + tvdvuh.SDT, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_ThanhVienDVUH.Instance.Delete(tvdvuh);
            }
        }
        public ThanhVienDVUH ConvertFromDataGridViewToObj(DataGridViewRow row)
        {
            ThanhVienDVUH tvdvuh = new ThanhVienDVUH();
            tvdvuh.MaDVUH = Convert.ToInt32(row.Cells["MaDVUH"].Value.ToString());
            tvdvuh.HoTen = row.Cells["HoTen"].Value.ToString();
            tvdvuh.GioiTinh = Convert.ToBoolean(row.Cells["GioiTinh"].Value.ToString());
            tvdvuh.CCCD = row.Cells["CCCD"].Value.ToString();
            tvdvuh.DiaChi = row.Cells["DiaChi"].Value.ToString();
            tvdvuh.SDT = row.Cells["SDT"].Value.ToString();
            return tvdvuh;
        }
    }
}
