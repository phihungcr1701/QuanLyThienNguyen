using System;
using System.Collections.Generic;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System.Reflection;
using System.Windows.Forms;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_DotUngHo
    {
        private static BBL_DotUngHo instance;

        public static BBL_DotUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_DotUngHo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<DotUngHoView> GetAllDotUngHo(string text, string namecolumn)
        {
            List<DotUngHoView> view = new List<DotUngHoView>();

            foreach (DotUngHoView item in Sort(DAL_DotUngHo.Instance.GetAllDotUngHo(), namecolumn))
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

        public List<DotUngHoView> Sort(List<DotUngHoView> list, string namecolumn)
        {
            List<DotUngHoView> sort = list;
            switch (namecolumn)
            {
                case "MaDUH":
                    sort.Sort((x, y) => x.MaDUH.CompareTo(y.MaDUH));
                    break;
                case "NgayBatDau":
                    sort.Sort((x, y) => x.NgayBatDau.CompareTo(y.NgayBatDau));
                    break;
                case "NgayKetThuc":
                    sort.Sort((x, y) => x.NgayKetThuc.CompareTo(y.NgayKetThuc));
                    break;
            }
            return sort;
        }
        public DotUngHoView GetDotUngHo(string ma)
        {
            foreach (DotUngHoView item in DAL_DotUngHo.Instance.GetAllDotUngHo())
                if (item.MaDUH.Equals(ma))
                    return item;
            return null;
        }
        public void Add(DotUngHoView duh)
        {
            DAL_DotUngHo.Instance.Add(DotUngHoView.ToChange(duh));
        }
        public void Update(DotUngHoView duh)
        {
            DAL_DotUngHo.Instance.Update(DotUngHoView.ToChange(duh));
        }
        public void Delete(string ma)
        {
            DotUngHoView duh = GetDotUngHo(ma);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + duh.MaDUH + " | " + duh.NgayBatDau + " | " + duh.NgayKetThuc, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_DotUngHo.Instance.Delete(ma);
            }
        }
    }
}
