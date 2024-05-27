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
        public List<ThanhVienDVUHView> GetAllThanhVienDVUH(string text, string namecolumn)
        {
            List<ThanhVienDVUHView> view = new List<ThanhVienDVUHView>();

            foreach (ThanhVienDVUHView item in Sort(DAL_ThanhVienDVUH.Instance.GetAllThanhVienDVUH(), namecolumn))
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
        public List<ThanhVienDVUHView> Sort(List<ThanhVienDVUHView> list, string namecolumn)
        {
            List<ThanhVienDVUHView> sort = list;
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
        public bool Check(ThanhVienDVUHView tvdvuh)
        {
            if (DAL_ThanhVienDVUH.Instance.Check(ThanhVienDVUHView.ToChange(tvdvuh)) != 0)
                return false;
            return true;
        }
        public void Add(ThanhVienDVUHView tvdvuh)
        {
            DAL_ThanhVienDVUH.Instance.Add(ThanhVienDVUHView.ToChange(tvdvuh));
        }
        public void Update(ThanhVienDVUHView tvdvuh, ThanhVienDVUHView tvdvuhchange)
        {
            DAL_ThanhVienDVUH.Instance.Update(ThanhVienDVUHView.ToChange(tvdvuh), ThanhVienDVUHView.ToChange(tvdvuhchange));
        }
        public void Delete(ThanhVienDVUHView tvdvuh)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + tvdvuh.MaDVUH + " | " + tvdvuh.HoTen + " | " + tvdvuh.GioiTinh + " | " + tvdvuh.CCCD + " | " + tvdvuh.DiaChi + " | " + tvdvuh.SDT, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_ThanhVienDVUH.Instance.Delete(ThanhVienDVUHView.ToChange(tvdvuh));
            }
        }
        public ThanhVienDVUHView ConvertFromDataGridViewToObj(DataGridViewRow row)
        {
            return new ThanhVienDVUHView
            {
                MaDVUH = row.Cells["MaDVUH"].Value.ToString(),
                HoTen = row.Cells["HoTen"].Value.ToString(),
                GioiTinh = Convert.ToBoolean(row.Cells["GioiTinh"].Value.ToString()),
                CCCD = row.Cells["CCCD"].Value.ToString(),
                DiaChi = row.Cells["DiaChi"].Value.ToString(),
                SDT = row.Cells["SDT"].Value.ToString()
            };
        }
    }
}
