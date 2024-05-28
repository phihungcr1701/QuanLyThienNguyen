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
        public BBL_HinhThucUngHo() { }
        public List<DTOHinhThucUngHo> GetAllHinhThucUngHo(string text, string namecolumn)
        {
            List<DTOHinhThucUngHo> view = new List<DTOHinhThucUngHo>();

            foreach (DTOHinhThucUngHo item in Sort(DAL_HinhThucUngHo.Instance.GetAllHinhThucUngHo(), namecolumn))
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

        public List<DTOHinhThucUngHo> Sort(List<DTOHinhThucUngHo> list, string namecolumn)
        {
            List<DTOHinhThucUngHo> sort = list;
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
        public HinhThucUngHo GetHinhThucUngHo(string ma)
        {
            foreach (HinhThucUngHo item in DAL_HinhThucUngHo.Instance.GetAll())
                if (item.MaHTUH.Equals(ma))
                    return item;
            return null;
        }
        public void Add(HinhThucUngHo htuh)
        {
            DAL_HinhThucUngHo.Instance.Add(htuh);
        }
        public void Update(HinhThucUngHo htuh)
        {
            DAL_HinhThucUngHo.Instance.Update(htuh);
        }
        public void Delete(string ma)
        {
            HinhThucUngHo htuh = GetHinhThucUngHo(ma);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + htuh.MaHTUH + " | " + htuh.TenHTUH + " | " + htuh.DonViTinh, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_HinhThucUngHo.Instance.Delete(htuh);
            }
        }
    }
}
