using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_ThongKe
    {
        private static DAL_ThongKe instance;

        public static DAL_ThongKe Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_ThongKe();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DAL_ThongKe() { }
        public List<string> GetAllTenHTUH()
        {
            List<string> list = new List<string>();
            string sql = "SELECT DISTINCT HinhThucUngHo.TenHTUH FROM HinhThucUngHo INNER JOIN ChiTietUngHo ON HinhThucUngHo.MaHTUH = ChiTietUngHo.MaHTUH;";

            foreach (DataRow row in DataProvider.Instance.ExcuteQuery(sql).Rows)
            {
                list.Add(row["TenHTUH"].ToString());
            }

            return list;
        }
        public List<string> GetAllMa(string ma)
        {
            List<string> list = new List<string>();
            string sql = "SELECT DISTINCT "+ ma +" FROM ChiTietUngHo;";

            foreach (DataRow row in DataProvider.Instance.ExcuteQuery(sql).Rows)
            {
                list.Add(row[ma].ToString());
            }

            return list;
        }
        public List<ThongKeShow> GetAllThongKe(string ten)
        {
            List<ThongKeShow> list = new List<ThongKeShow>();
            string sql =
                "SELECT DonViUngHo.TenDonVi, HinhThucUngHo.TenHTUH, ThongKe.TongSoLuongUH, ThongKe.SoDuUH, HinhThucUngHo.DonViTinh " +
                "FROM (ThongKe INNER JOIN HinhThucUngHo ON ThongKe.MaHTUH = HinhThucUngHo.MaHTUH) INNER JOIN DonViUngHo ON ThongKe.MaDVUH = DonViUngHo.MaDVUH " +
                "WHERE HinhThucUngHo.TenHTUH = '" + ten + "';";

            foreach (DataRow row in DataProvider.Instance.ExcuteQuery(sql).Rows)
            {
                list.Add(new ThongKeShow(row));
            }
            return list;
        }
        public void Add(ThongKe tk)
        {
            string query = "exec ThemThongKe " + tk.MaDVUH + ", " + tk.MaHTUH + ", " + tk.TongSoLuongUH + ", " + tk.SoDuUH;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Delete()
        {
            string query = "exec XoaThongKe";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
