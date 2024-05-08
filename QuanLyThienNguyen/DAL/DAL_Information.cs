using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_Information
    {
        private static DAL_Information instance;
        public static DAL_Information Instance 
        {  
            get 
            {
                if (instance == null)
                    instance = new DAL_Information();
                return instance; 
            } 
            set
            {
                instance = value;
            }
        }
        public DAL_Information() { }
        public DataTable DAL_InformationView(string nametable, string text, string namerow)
        {
            string query = "exec InformationTable" + nametable + " '" + text + "', '" + namerow + "'";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        /// Đơn vị ủng hộ
        public void DAL_Add_DVUH(DonViUngHo dvuh)
        {
            string query = "exec ThemDonViUngHo '" + dvuh.HoTen + "'," + dvuh.GioiTinh + ", '" + dvuh.CCCD + "', '" + dvuh.DiaChi + "', '" + dvuh.SDT + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void DAL_Update_DVUH(DonViUngHo dvuh)
        {
            string query = "exec CapNhatDonViUngHo '" + dvuh.MaDVUH + "','" + dvuh.HoTen + "'," + dvuh.GioiTinh + ", '" + dvuh.CCCD + "', '" + dvuh.DiaChi + "', '" + dvuh.SDT + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void DAL_Delete_DVUH(DonViUngHo dvuh)
        {
            string query = "exec XoaDonViUngHo '" + dvuh.MaDVUH + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        /// Thành viên đơn vị ủng hộ
        public void DAL_Add_TVDVUH(ThanhVienDonViUngHo tvdvuh)
        {
            string query = "exec ThemThanhVienDVUH '" + tvdvuh.MaDVUH + "', '" + tvdvuh.HoTen + "'," + tvdvuh.GioiTinh + ", '" + tvdvuh.CCCD + "', '" + tvdvuh.DiaChi + "', '" + tvdvuh.SDT + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void DAL_Update_TVDVUH(ThanhVienDonViUngHo tvdvuh, ThanhVienDonViUngHo tvdvuhchange)
        {
            string query = "exec CapNhatThanhVienDVUH '" + tvdvuh.MaDVUH + "', '" + tvdvuh.HoTen + "'," + tvdvuh.GioiTinh + ", '" + tvdvuh.CCCD + "', '" + tvdvuh.DiaChi + "', '" + tvdvuh.SDT + 
                                        "', '" + tvdvuhchange.MaDVUH + "', '" + tvdvuhchange.HoTen + "'," + tvdvuhchange.GioiTinh + ", '" + tvdvuhchange.CCCD + "', '" + tvdvuhchange.DiaChi + "', '" + tvdvuhchange.SDT + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void DAL_Delete_TVDVUH(ThanhVienDonViUngHo tvdvuh)
        {
            string query = "exec XoaThanhVienDVUH '" + tvdvuh.MaDVUH + "', '" + tvdvuh.HoTen + "'," + tvdvuh.GioiTinh + ", '" + tvdvuh.CCCD + "', '" + tvdvuh.DiaChi + "', '" + tvdvuh.SDT + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public int DAL_Check_TVDVUH(ThanhVienDonViUngHo tvdvuh)
        {
            string query = "exec CheckTVDVUH '" + tvdvuh.MaDVUH + "', '" + tvdvuh.HoTen + "'," + tvdvuh.GioiTinh + ", '" + tvdvuh.CCCD + "', '" + tvdvuh.DiaChi + "', '" + tvdvuh.SDT + "'";
            return (int)DataProvider.Instance.ExcuteScalar(query);
        }
    }
}
