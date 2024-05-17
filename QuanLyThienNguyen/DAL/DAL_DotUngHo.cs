using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_DotUngHo
    {
        private static DAL_DotUngHo instance;
        public static DAL_DotUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_DotUngHo();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DAL_DotUngHo() { }
        public List<DotUngHo> GetAllDotUngHo()
        {
            string query = "exec GetAllDotUngHo";
            List<DotUngHo> list = new List<DotUngHo>();
            foreach (DataRow item in DataProvider.Instance.ExcuteQuery(query).Rows)
            {
                list.Add(new DotUngHo(item));
            }
            return list;
        }
        public void Add(DotUngHo duh)
            {
            string query = "exec ThemDotUngHo '" + duh.NgayBatDau.ToString("yyyy-MM-dd") + "', '" + duh.NgayKetThuc.ToString("yyyy-MM-dd") + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Update(DotUngHo duh)
                {
            string query = "exec CapNhatDotUngHo '" + duh.MaDUH + "', '" + duh.NgayBatDau.ToString("yyyy-MM-dd") + "', '" + duh.NgayKetThuc.ToString("yyyy-MM-dd") + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
            }
        public void Delete(string ma)
        {
            string query = "exec XoaDotUngHo '" + ma + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
