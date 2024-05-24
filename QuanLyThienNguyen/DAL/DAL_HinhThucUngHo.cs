using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_HinhThucUngHo
    {
        private static DAL_HinhThucUngHo instance;
        public static DAL_HinhThucUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_HinhThucUngHo();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DAL_HinhThucUngHo() { }
        public List<HinhThucUngHo> GetAllHinhThucUngHo()
        {
            string query = "exec GetAllHinhThucUngHo";
            List<HinhThucUngHo> list = new List<HinhThucUngHo>();
            foreach (DataRow item in DataProvider.Instance.ExcuteQuery(query).Rows)
            {
                list.Add(new HinhThucUngHo(item));
            }
            return list;
        }

        public void Add(HinhThucUngHo htuh)
            {
            string query = "exec ThemHinhThucUngHo '" + htuh.MaHTUH + "', '" + htuh.TenHTUH + "', '" + htuh.DonViTinh + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Update(HinhThucUngHo htuh)
                {
            string query = "exec CapNhatHinhThucUngHo '" + htuh.MaHTUH + "', '" + htuh.TenHTUH + "', '" + htuh.DonViTinh + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
            }
        public void Delete(string ma)
        {
            string query = "exec XoaHinhThucUngHo " + ma;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
