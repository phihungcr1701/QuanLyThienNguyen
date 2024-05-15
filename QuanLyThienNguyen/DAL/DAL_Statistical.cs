using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_Statistical
    {
        private static DAL_Statistical instance;

        public static DAL_Statistical Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_Statistical();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DAL_Statistical() { }
        public DataTable TruyVan_TenHTUH()
        {
            //string sql = "SELECT DISTINCT HinhThucUngHo.TenHTUH FROM ThongKe INNER JOIN HinhThucUngHo ON ThongKe.MaHTUH = HinhThucUngHo.MaHTUH";
            string sql = "SELECT DISTINCT TenHTUH FROM Test";
            return DataProvider.Instance.ExcuteQuery(sql);
        }
        public DataTable TruyVan_Ma(string ma)
        {
            string sql = "SELECT DISTINCT "+ ma +" FROM ChiTietUngHo";
            return DataProvider.Instance.ExcuteQuery(sql);
        }
        public DataTable View(string ten)
        {
            //string sql = "SELECT DonViUngHo.TenDVUH AS 'Tên đơn vị ủng hộ', HinhThucUngHo.TenHTUH AS 'Tên hình thức ủng hộ', ThongKe.TongSoLuongUH AS 'Tổng số lượng ủng hộ', ThongKe.SoDuUH AS 'Số dư ủng hộ', HinhThucUngHo.DonViTinh AS 'Đơn vị tính'" +
            //    "FROM (ThongKe INNER JOIN HinhThucUngHo ON ThongKe.MaHTUH = HinhThucUngHo.MaHTUH) INNER JOIN DonViUngHo ON ThongKe.MaDVUH = DonViUngHo.MaDVUH"
            //    "WHERE TenHTUH = "+ ten +";";
            string sql = "SELECT * FROM Test WHERE TenHTUH = " + ten;
            return DataProvider.Instance.ExcuteQuery(sql);
        }
        public void Add_TK(ThongKe tk)
        {
            string query = "exec ThemThongKe " + tk.MaDVUH + ", " + tk.MaHTUH + ", " + tk.TongSoLuongUH + ", " + tk.SoDuUH;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Delete_TK()
        {
            string query = "exec XoaDonViUngHo";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
