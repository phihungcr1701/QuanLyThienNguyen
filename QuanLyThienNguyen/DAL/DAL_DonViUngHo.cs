using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_DonViUngHo
    {
        private static DAL_DonViUngHo instance;
        public static DAL_DonViUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_DonViUngHo();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DAL_DonViUngHo() { }
        public List<DonViUngHo> GetAllDonViUngHo()
        {
            string query = "exec GetAllDonViUngHo";
            List<DonViUngHo> list = new List<DonViUngHo>();
            foreach (DataRow item in DataProvider.Instance.ExcuteQuery(query).Rows)
            {
                list.Add(new DonViUngHo(item));
            }
            return list;
        }
        public void Add(DonViUngHo dvuh)
        {
            string query = "exec ThemDonViUngHo '" + dvuh.TenDonVi + "', '" + dvuh.DiaChiDonVi + "', '" + dvuh.SDTDonVi + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Update(DonViUngHo dvuh)
        {
            string query = "exec CapNhatDonViUngHo '" + dvuh.MaDVUH + "','" + dvuh.TenDonVi + "', '" + dvuh.DiaChiDonVi + "', '" + dvuh.SDTDonVi + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Delete(string ma)
        {
            string query = "exec XoaDonViUngHo '" + ma + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
