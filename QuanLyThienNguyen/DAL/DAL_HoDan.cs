using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_HoDan
    {
        private static DAL_HoDan instance;

        internal static DAL_HoDan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_HoDan();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<HoDan> GetAllHoDan()
        {
            List<HoDan> list = new List<HoDan>();
            string query = "SELECT * FROM HoDan";
            foreach (DataRow row in DataProvider.Instance.ExcuteQuery(query).Rows)
            {
                list.Add(new HoDan
                {
                    MaHD = Convert.ToInt32(row["MaHD"].ToString()),
                    HoTenChuHo = row["HoTenChuHo"].ToString(),
                    GioiTinh = Convert.ToInt32(row["GioiTinh"].ToString()),
                    CCCD = row["CCCD"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    SDT = row["SDT"].ToString(),
                    DienGiaDinh = row["DienGiaDinh"].ToString()
                });
            }
            return list;
        }
    }
}
