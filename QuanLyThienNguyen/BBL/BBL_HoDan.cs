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
        public List<HoDanView> GetAllHoDan(string text, string namecolumn)
        {
            List<HoDanView> view = new List<HoDanView>();
        
            foreach (HoDanView item in Sort(DAL_HoDan.Instance.GetAllHoDan(), namecolumn))
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

        public List<HoDanView> Sort(List<HoDanView> list, string namecolumn)
        {
            List<HoDanView> sort = list;
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
        public HoDanView GetHoDan(string ma)
        {
            foreach (HoDanView item in DAL_HoDan.Instance.GetAllHoDan())
                if (item.MaHD.Equals(ma))
                    return item;
            return null;
        }
        public void Add(HoDanView hd)
        {
            DAL_HoDan.Instance.Add(HoDanView.ToChange(hd));
        }
        public void Update(HoDanView hd)
        {
            DAL_HoDan.Instance.Update(HoDanView.ToChange(hd));
        }
        public void Delete(string ma)
        {
            HoDanView hd = GetHoDan(ma);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + hd.MaHD + " | " + hd.HoTenChuHo + " | " + hd.GioiTinh + " | " + hd.CCCD + " | " + hd.DiaChi + " | " + hd.SDT, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
        {
                DAL_HoDan.Instance.Delete(ma);
            }
        }
    }
}
