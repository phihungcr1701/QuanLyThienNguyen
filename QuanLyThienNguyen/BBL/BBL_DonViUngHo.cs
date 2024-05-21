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
        public List<DonViUngHo> GetAllDonViUngHo(string text, string namecolumn)
        {
            List<DonViUngHo> view = new List<DonViUngHo>();

            foreach (DonViUngHo item in Sort(DAL_DonViUngHo.Instance.GetAllDonViUngHo(), namecolumn))
            {
                foreach (PropertyInfo property in item.GetType().GetProperties())
                {
                    if (property.GetValue(item).ToString().ToLower().Contains(text.ToLower()) )
                    {
                        view.Add(item);
                    break;
                    }
                }
            }

            return view;
        }
        public List<DonViUngHo> Sort(List<DonViUngHo> list, string namecolumn)
        {
            List<DonViUngHo> sort = list;
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
        public DonViUngHo GetDonViUngHo(int ma)
        {
            DonViUngHo dvuh = new DonViUngHo();
    
            foreach (DonViUngHo item in DAL_DonViUngHo.Instance.GetAllDonViUngHo())
            {
                if (item.MaDVUH.ToString().Equals(ma.ToString()))
                {
                    dvuh = item; 
                    break;
                }
            }
            return dvuh;
        }
        public void Add(DonViUngHo dvuh)
        {
            DAL_DonViUngHo.Instance.Add(dvuh);
        }
        public void Update(DonViUngHo dvuh)
        {
            DAL_DonViUngHo.Instance.Update(dvuh);
        }
        public void Delete(int ma)
        {
            DonViUngHo dvuh = GetDonViUngHo(ma);
            if (System.Windows.Forms.MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + dvuh.MaDVUH + " | " + dvuh.TenDonVi + " | " + dvuh.DiaChiDonVi + " | " + dvuh.SDTDonVi, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_DonViUngHo.Instance.Delete(ma);
            }
        }
    }
}
