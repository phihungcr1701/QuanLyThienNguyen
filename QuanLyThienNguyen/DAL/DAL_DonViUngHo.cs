using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_DonViUngHo
    {
        private static DAL_DonViUngHo instance;

        internal static DAL_DonViUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_DonViUngHo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<DonViUngHo> GetAllDonViUngHo()
        {
            List<DonViUngHo> list = new List<DonViUngHo>();
            string query = "SELECT * FROM DonViUngHo";
            foreach (DataRow row in DataProvider.Instance.ExcuteQuery(query).Rows)
            {
                list.Add(new DonViUngHo
                {
                    MaDVUH = Convert.ToInt32(row["MaDVUH"].ToString()),
                    TenDonVi = row["TenDonVi"].ToString(),
                    DiaChiDonVi = row["DiaChiDonVi"].ToString(),
                    SDTDonVi = row["SDTDonVi"].ToString()
                });
            }
            return list;
        }
    }
}
