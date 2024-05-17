using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System.Collections.Generic;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_ComboBox
    {
        private static BBL_ComboBox instance;

        public static BBL_ComboBox Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_ComboBox();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BBL_ComboBox() { }
        public List<string> Combobox_DVUH()
        {
            List<string> list = new List<string>();
            foreach (DonViUngHo item in DAL_DonViUngHo.Instance.GetAllDonViUngHo())
            {
                list.Add(item.MaDVUH.ToString());
            }
            return list;
        }
        public List<string> Combobox_DUH()
        {
            List<string> list = new List<string>();
            foreach (DotUngHo item in DAL_DotUngHo.Instance.GetAllDotUngHo())
            {
                list.Add(item.MaDUH.ToString());
            }
            return list;
        }
        public List<string> Combobox_HoDan()
        {
            List<string> list = new List<string>();
            foreach (HoDan item in DAL_HoDan.Instance.GetAllHoDan())
            {
                list.Add(item.MaHD.ToString());
            }
            return list;
        }
        public List<string> Combobox_HTUH()
        {
            List<string> list = new List<string>();
            foreach (HinhThucUngHo item in DAL_HinhThucUngHo.Instance.GetAllHinhThucUngHo())
            {
                list.Add(item.MaHTUH.ToString());
            }
            return list;
        }
        public List<string> Combobox_TK()
        {
            List<string> list = new List<string>();
            foreach (string item in DAL_ThongKe.Instance.GetAllTenHTUH())
            {
                list.Add(item.ToString());
            }
            return list;
        }
    }
}