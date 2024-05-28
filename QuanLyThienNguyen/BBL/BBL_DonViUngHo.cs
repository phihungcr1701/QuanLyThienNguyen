using System.Collections.Generic;
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
        public BBL_DonViUngHo() { }
        public List<DTODonViUngHo> GetAllDonViUngHo(string text, string namecolumn)
        {
            List<DTODonViUngHo> view = new List<DTODonViUngHo>();

            foreach (DTODonViUngHo item in Sort(DAL_DonViUngHo.Instance.GetAllDonViUngHo(), namecolumn))
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
        public List<DTODonViUngHo> Sort(List<DTODonViUngHo> list, string namecolumn)
        {
            List<DTODonViUngHo> sort = list;
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
            foreach (DonViUngHo item in DAL_DonViUngHo.Instance.GetAll())
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
                DAL_DonViUngHo.Instance.Delete(dvuh);
            }
        }
    }
}
