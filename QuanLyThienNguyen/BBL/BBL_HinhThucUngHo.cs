using System;
using System.Collections.Generic;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System.Reflection;
using System.Windows.Forms;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_HinhThucUngHo
    {
        private static BBL_HinhThucUngHo instance;

        public static BBL_HinhThucUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_HinhThucUngHo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<HinhThucUngHoView> GetAllHinhThucUngHo(string text, string namecolumn)
        {
            List<HinhThucUngHoView> view = new List<HinhThucUngHoView>();

            foreach (HinhThucUngHoView item in Sort(DAL_HinhThucUngHo.Instance.GetAllHinhThucUngHo(), namecolumn))
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

        public List<HinhThucUngHoView> Sort(List<HinhThucUngHoView> list, string namecolumn)
        {
            List<HinhThucUngHoView> sort = list;
            switch (namecolumn)
            {
                case "MaHTUH":
                    sort.Sort((x, y) => x.MaHTUH.CompareTo(y.MaHTUH));
                    break;
                case "TenHTUH":
                    sort.Sort((x, y) => x.TenHTUH.CompareTo(y.TenHTUH));
                    break;
                case "DonViTinh":
                    sort.Sort((x, y) => x.DonViTinh.CompareTo(y.DonViTinh));
                    break;
                }
            return sort;
        }
        public HinhThucUngHoView GetHinhThucUngHo(string ma)
        {
            foreach (HinhThucUngHoView item in DAL_HinhThucUngHo.Instance.GetAllHinhThucUngHo())
                if (item.MaHTUH.Equals(ma))
                    return item;
            return null;
        }
        public void Add(HinhThucUngHoView htuh)
        {
            DAL_HinhThucUngHo.Instance.Add(HinhThucUngHoView.ToChange(htuh));
        }
        public void Update(HinhThucUngHoView htuh)
        {
            DAL_HinhThucUngHo.Instance.Update(HinhThucUngHoView.ToChange(htuh));
        }
        public void Delete(string ma)
        {
            HinhThucUngHoView htuh = GetHinhThucUngHo(ma);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + htuh.MaHTUH + " | " + htuh.TenHTUH + " | " + htuh.DonViTinh, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_HinhThucUngHo.Instance.Delete(ma);
            }
        }
    }
}
