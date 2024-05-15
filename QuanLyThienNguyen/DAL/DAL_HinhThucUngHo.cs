using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_HinhThucUngHo
    {
        private static DAL_HinhThucUngHo instance;

        internal static DAL_HinhThucUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_HinhThucUngHo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<HinhThucUngHo> GetAllHinhThucUngHo()
        {
            List<HinhThucUngHo> list = new List<HinhThucUngHo>();
            string query = "SELECT * FROM HinhThucUngHo";
            foreach (DataRow row in DataProvider.Instance.ExcuteQuery(query).Rows)
            {
                list.Add(new HinhThucUngHo
                {
                    MaHTUH = Convert.ToInt32(row["MaHTUH"].ToString()),
                    TenHTUH = row["TenHTUH"].ToString(),
                    DonViTinh = row["DonViTinh"].ToString()
                });
            }
            return list;
        }
    }
}
