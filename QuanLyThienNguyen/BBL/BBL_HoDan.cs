using System;
using System.Collections.Generic;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System.Reflection;
using System.Windows.Forms;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_HoDan
    {
        private static BBL_HoDan instance;

        public static BBL_HoDan Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_HoDan();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public BBL_HoDan() { }
        public List<DTO_HoDan> GetAllHoDan(string text, string namecolumn)
        {
            List<DTO_HoDan> view = new List<DTO_HoDan>();

            foreach (DTO_HoDan item in Sort(DAL_HoDan.Instance.GetAllHoDan(), namecolumn))
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

        public List<DTO_HoDan> Sort(List<DTO_HoDan> list, string namecolumn)
        {
            List<DTO_HoDan> sort = list;
            switch (namecolumn)
            {
                case "MaHD":
                    sort.Sort((x, y) => x.MaHD.CompareTo(y.MaHD));
                    break;
                case "HoTenChuHo":
                    sort.Sort((x, y) => x.HoTenChuHo.CompareTo(y.HoTenChuHo));
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
                case "DienGiaDinh":
                    sort.Sort((x, y) => x.DienGiaDinh.CompareTo(y.DienGiaDinh));
                    break;
            }
            return sort;
        }
        public HoDan GetHoDan(string ma)
        {
            foreach (HoDan item in DAL_HoDan.Instance.GetAll())
                if (item.MaHD.Equals(ma))
                    return item;
            return null;
        }
        public void Add(HoDan hd)
        {
            DAL_HoDan.Instance.Add(hd);
        }
        public void Update(HoDan hd)
        {
            DAL_HoDan.Instance.Update(hd);
        }
        public void Delete(string ma)
        {
            HoDan hd = GetHoDan(ma);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + hd.MaHD + " | " + hd.HoTenChuHo + " | " + hd.GioiTinh + " | " + hd.CCCD + " | " + hd.DiaChi + " | " + hd.SDT, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_HoDan.Instance.Delete(hd);
            }
        }
    }
}