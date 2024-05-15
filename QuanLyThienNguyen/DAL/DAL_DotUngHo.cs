using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_DotUngHo
    {
        private static DAL_DotUngHo instance;

        internal static DAL_DotUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_DotUngHo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<DotUngHo> GetAllDotUngHo()
        {
            List<DotUngHo> list = new List<DotUngHo>();
            string query = "SELECT * FROM DotUngHo";
            foreach (DataRow row in DataProvider.Instance.ExcuteQuery(query).Rows)
            {
                list.Add(new DotUngHo
                {
                    MaDUH = Convert.ToInt32(row["MaDUH"].ToString()),
                    NgayBatDau = Convert.ToDateTime(row["NgayBatDau"].ToString()),
                    NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"].ToString())
                });
            }
            return list;
        }
    }
}
