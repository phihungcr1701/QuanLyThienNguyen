using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Linq;

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
        public List<string> Combobox_DVUH()
        {
            List<string> list = new List<string>();
            foreach (DTO_DonViUngHo item in DAL_DonViUngHo.Instance.GetAllDonViUngHo())
            {
                list.Add(item.MaDVUH.ToString());
            }
            return list;
        }
        public List<string> Combobox_DUH()
        {
            List<string> list = new List<string>();
            foreach (DTO_DotUngHo item in DAL_DotUngHo.Instance.GetAllDotUngHo())
            {
                list.Add(item.MaDUH.ToString());
            }
            return list;
        }
        public List<string> Combobox_HoDan()
        {
            List<string> list = new List<string>();
            foreach (DTO_HoDan item in DAL_HoDan.Instance.GetAllHoDan())
            {
                list.Add(item.MaHD.ToString());
            }
            return list;
        }
        public List<string> Combobox_HTUH()
        {
            List<string> list = new List<string>();
            foreach (DTO_HinhThucUngHo item in DAL_HinhThucUngHo.Instance.GetAllHinhThucUngHo())
            {
                list.Add(item.MaHTUH.ToString());
            }
            return list;
        }
        public List<string> Combobox_TK()
        {
            return DAL_ThongKe.Instance.GetAllTenHTUH();
        }
    }
}