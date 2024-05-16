using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
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
        public List<HinhThucUngHo> GetAllHinhThucUngHo(string text, string namecolumn)
        {
            List<HinhThucUngHo> list = Sort(DAL_HinhThucUngHo.Instance.GetAllHinhThucUngHo(), namecolumn);
            List<HinhThucUngHo> view = new List<HinhThucUngHo>();

            foreach (HinhThucUngHo item in list)
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

        public List<HinhThucUngHo> Sort(List<HinhThucUngHo> list, string namecolumn)
        {
            List<HinhThucUngHo> sort = list;
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
            List<HinhThucUngHo> list = DAL_HinhThucUngHo.Instance.GetAllHinhThucUngHo();
            HinhThucUngHo htuh = new HinhThucUngHo();

            foreach (HinhThucUngHo item in list)
            {
                if (item.MaHTUH.ToString().Equals(ma))
                {
                    htuh = item;
                }
            }
            return htuh;
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
            if (System.Windows.Forms.MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + htuh.MaHTUH + " | " + htuh.TenHTUH + " | " + htuh.DonViTinh, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_HinhThucUngHo.Instance.Delete(ma);
            }
            return hinhthucungho;
        }
    }
}
