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
        public List<DTO_ThanhVienDVUH> GetAllThanhVienDVUH(string text, string namecolumn)
        {
            List<DTO_ThanhVienDVUH> view = new List<DTO_ThanhVienDVUH>();

            foreach (DTO_ThanhVienDVUH item in Sort(DAL_ThanhVienDVUH.Instance.GetAllThanhVienDVUH(), namecolumn))
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
        public List<DTO_ThanhVienDVUH> Sort(List<DTO_ThanhVienDVUH> list, string namecolumn)
        {
            List<DTO_ThanhVienDVUH> sort = list;
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
        public ThanhVienDVUH GetThanhVienDVUH(string ma)
        {
            foreach (ThanhVienDVUH item in DAL_ThanhVienDVUH.Instance.GetAll())
                if (item.MaTVDVUH == ma)
                    return item;
            return null;
        }
        public void Add(ThanhVienDVUH tvdvuh)
        {
            DAL_ThanhVienDVUH.Instance.Add(tvdvuh);
        }
        public void Update(ThanhVienDVUH tvdvuh)
        {
            DAL_ThanhVienDVUH.Instance.Update(tvdvuh);
        }
        public void Delete(string ma)
        {
            ThanhVienDVUH tvdvuh = GetThanhVienDVUH(ma);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + tvdvuh.MaDVUH + " | " + tvdvuh.HoTen + " | " + tvdvuh.GioiTinh + " | " + tvdvuh.CCCD + " | " + tvdvuh.DiaChi + " | " + tvdvuh.SDT, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_ThanhVienDVUH.Instance.Delete(tvdvuh);
            }
        }
    }
}
