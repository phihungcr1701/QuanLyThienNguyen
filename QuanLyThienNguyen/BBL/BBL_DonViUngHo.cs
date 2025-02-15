﻿using System.Collections.Generic;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System.Reflection;
using System.Windows.Forms;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_DonViUngHo
    {
        private static BBL_DonViUngHo instance;

        public static BBL_DonViUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_DonViUngHo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<DTO_DonViUngHo> GetAllDonViUngHo(string text, string namecolumn)
        {
            List<DTO_DonViUngHo> view = new List<DTO_DonViUngHo>();

            foreach (DTO_DonViUngHo item in Sort(DAL_DonViUngHo.Instance.GetAllDonViUngHo(), namecolumn))
            {
                foreach (PropertyInfo property in item.GetType().GetProperties())
                {
                    if (property.GetValue(item).ToString().ToLower().Contains(text.ToLower()))
                    {
                        view.Add(item);
                    break;
                    }
                }
            }

            return view;
        }
        public List<DTO_DonViUngHo> Sort(List<DTO_DonViUngHo> list, string namecolumn)
        {
            List<DTO_DonViUngHo> sort = list;
            switch (namecolumn)
            {
                case "MaDVUH":
                    sort.Sort((x, y) => x.MaDVUH.CompareTo(y.MaDVUH));
                    break;
                case "TenDonVi":
                    sort.Sort((x, y) => x.TenDonVi.CompareTo(y.TenDonVi));
                    break;
                case "DiaChiDonVi":
                    sort.Sort((x, y) => x.DiaChiDonVi.CompareTo(y.DiaChiDonVi));
                    break;
                case "SDTDonVi":
                    sort.Sort((x, y) => x.SDTDonVi.CompareTo(y.SDTDonVi));
                    break;
            }
            return sort;
        }
        public DonViUngHo GetDonViUngHo(string ma)
        {
            foreach (var item in DAL_DonViUngHo.Instance.GetAll())
                if (item.MaDVUH.Equals(ma))
                    return item;
            return null;
        }
        public void Add(DonViUngHo dvuh)
        {
            DAL_DonViUngHo.Instance.Add(dvuh);
        }
        public void Update(DonViUngHo dvuh)
        {
            DAL_DonViUngHo.Instance.Update(dvuh);
        }
        public void Delete(string ma)
        {
            DonViUngHo dvuh = GetDonViUngHo(ma);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + dvuh.MaDVUH + " | " + dvuh.TenDonVi + " | " + dvuh.DiaChiDonVi + " | " + dvuh.SDTDonVi, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                if (!IsDVUHInChiTietUngHo(GetDonViUngHo(ma)))
                    DAL_DonViUngHo.Instance.Delete(dvuh);
                else
                {
                    MessageBox.Show("Đơn vị ủng hộ này tồn tại trong chi tiết ủng hộ, bạn cần xóa chi tiết" +
                        " ủng hộ chứa đơn vị ủng hộ này trước khi thực hiện thao tác này!!", "Thông báo");
                }
            }
        }
        public bool IsDVUHInChiTietUngHo(DonViUngHo dvuh)
        {
            bool check = false;
            foreach (ChiTietUngHo i in DAL_ChiTietUngHo.Instance.GetAll())
            {
                if (i.MaDVUH == dvuh.MaDVUH)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
    }
}
