using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_ThanhVienDVUH
    {
        private static DAL_ThanhVienDVUH instance;
        public static DAL_ThanhVienDVUH Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_ThanhVienDVUH();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DAL_ThanhVienDVUH() { }
        public List<ThanhVienDVUH> GetAllThanhVienDVUH()
        {
            string query = "exec GetAllThanhVienDVUH";
            List<ThanhVienDVUH> list = new List<ThanhVienDVUH>();
            foreach (DataRow item in DataProvider.Instance.ExcuteQuery(query).Rows)
            {
                list.Add(new ThanhVienDVUH(item));
            }
            return list;
        }
        public void Add(ThanhVienDVUH tvdvuh)
        {
            string query = "exec ThemThanhVienDVUH '" + tvdvuh.MaDVUH + "', '" + tvdvuh.HoTen + "'," + tvdvuh.GioiTinh + ", '" + tvdvuh.CCCD + "', '" + tvdvuh.DiaChi + "', '" + tvdvuh.SDT + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Update(ThanhVienDVUH tvdvuh, ThanhVienDVUH tvdvuhchange)
        {
            string query = "exec CapNhatThanhVienDVUH '" + tvdvuh.MaDVUH + "', '" + tvdvuh.HoTen + "'," + tvdvuh.GioiTinh + ", '" + tvdvuh.CCCD + "', '" + tvdvuh.DiaChi + "', '" + tvdvuh.SDT +
                                        "', '" + tvdvuhchange.MaDVUH + "', '" + tvdvuhchange.HoTen + "'," + tvdvuhchange.GioiTinh + ", '" + tvdvuhchange.CCCD + "', '" + tvdvuhchange.DiaChi + "', '" + tvdvuhchange.SDT + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Delete(ThanhVienDVUH tvdvuh)
        {
            string query = "exec XoaThanhVienDVUH '" + tvdvuh.MaDVUH + "', '" + tvdvuh.HoTen + "'," + tvdvuh.GioiTinh + ", '" + tvdvuh.CCCD + "', '" + tvdvuh.DiaChi + "', '" + tvdvuh.SDT + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public int Check(ThanhVienDVUH tvdvuh)
        {
            string query = "SELECT COUNT(*) FROM ThanhVienDVUH WHERE MaDVUH = "+ tvdvuh.MaDVUH +" AND HoTen = '"+ tvdvuh.HoTen +"' AND GioiTinh = "+ Convert.ToByte(tvdvuh.GioiTinh) +" AND CCCD = '"+ tvdvuh.CCCD +"' AND DiaChi = '"+ tvdvuh.DiaChi +"' AND SDT = '"+ tvdvuh.SDT +"'";
            return (int)DataProvider.Instance.ExcuteScalar(query);
        }
    }
}
