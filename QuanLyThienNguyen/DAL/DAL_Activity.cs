using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_Activity
    {
        private static DAL_Activity instance;

        internal static DAL_Activity Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_Activity();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<Activity> GetAllActivity()
        {
            List<Activity> list = new List<Activity>();
            string query = "EXEC GetAllActivity";
            foreach (DataRow row in DataProvider.Instance.ExcuteQuery(query).Rows)
            {
                list.Add(GetActivity(row));
            }
            return list;
        }
        public Activity GetActivity(DataRow row)
        {
            return new Activity
            {
                TenDonVi = row["TenDonVi"].ToString(),
                HoTenChuHo = row["HoTenChuHo"].ToString(),
                TenHTUH = row["TenHTUH"].ToString(),
                SoLuongUH = Convert.ToDouble(row["SoLuongUH"].ToString()),
                SoLuongNUH = Convert.ToDouble(row["SoLuongNUH"].ToString()),
                DonViTinh = row["DonViTinh"].ToString(),
                NgayBatDau = Convert.ToDateTime(row["NgayBatDau"].ToString()),
                NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"].ToString())
            };
        }
        public List<string> GetCBB(string FieldName, string TableName)
        {
            List<string> list = new List<string>();
            string query = "SELECT * FROM " + TableName;
            foreach(DataRow row in DataProvider.Instance.ExcuteQuery(query).Rows)
            {
                list.Add(row[FieldName].ToString());
            }
            return list;
        }
        public void AddActivity(Activity activity)
        {
            string query = "INSERT";
        }
    }
}
