using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_HoDan
    {
        private static DAL_HoDan instance;
        public static DAL_HoDan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_HoDan();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DAL_HoDan() { }
        public List<HoDan> GetAllHoDan()
        {
            string query = "exec GetAllHoDan";
            List<HoDan> list = new List<HoDan>();
            foreach (DataRow item in DataProvider.Instance.ExcuteQuery(query).Rows)
            {
                list.Add(new HoDan(item));
            }
            return list;
        }

        public void Add(HoDan hd)
            {
            string query = "exec ThemHoDan '" + hd.HoTenChuHo + "'," + hd.GioiTinh + ", '" + hd.CCCD + "', '" + hd.DiaChi + "', '" + hd.SDT + "', '" + hd.DienGiaDinh + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Update(HoDan hd)
                {
            string query = "exec CapNhatHoDan '" + hd.MaHD + "','" + hd.HoTenChuHo + "'," + hd.GioiTinh + ", '" + hd.CCCD + "', '" + hd.DiaChi + "', '" + hd.SDT + "', '" + hd.DienGiaDinh + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
            }
        public void Delete(int ma)
        {
            string query = "exec XoaHoDan " + ma;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
