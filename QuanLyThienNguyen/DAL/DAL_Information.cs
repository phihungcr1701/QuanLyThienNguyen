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
        public DataTable View(string nametable)
        {
            string query = "exec InformationTable" + nametable;
            return DataProvider.Instance.ExcuteQuery(query);
        }

        /// Đơn vị ủng hộ
        public void Add_DVUH(DonViUngHo dvuh)
        {
            string query = "exec ThemDonViUngHo '" + dvuh.TenDonVi + "', '" + dvuh.DiaChiDonVi + "', '" + dvuh.SDTDonVi + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Update_DVUH(DonViUngHo dvuh)
        {
            string query = "exec CapNhatDonViUngHo '" + dvuh.MaDVUH + "','" + dvuh.TenDonVi+ "', '" + dvuh.DiaChiDonVi + "', '" + dvuh.SDTDonVi + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Delete_DVUH(String ma)
        {
            string query = "exec XoaDonViUngHo '" + ma + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        /// Thành viên đơn vị ủng hộ
        public void Add_TVDVUH(ThanhVienDonViUngHo tvdvuh)
        {
            string query = "exec ThemThanhVienDVUH '" + tvdvuh.MaDVUH + "', '" + tvdvuh.HoTen + "'," + tvdvuh.GioiTinh + ", '" + tvdvuh.CCCD + "', '" + tvdvuh.DiaChi + "', '" + tvdvuh.SDT + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Update_TVDVUH(ThanhVienDonViUngHo tvdvuh, ThanhVienDonViUngHo tvdvuhchange)
        {
            string query = "exec CapNhatThanhVienDVUH '" + tvdvuh.MaDVUH + "', '" + tvdvuh.HoTen + "'," + tvdvuh.GioiTinh + ", '" + tvdvuh.CCCD + "', '" + tvdvuh.DiaChi + "', '" + tvdvuh.SDT + 
                                        "', '" + tvdvuhchange.MaDVUH + "', '" + tvdvuhchange.HoTen + "'," + tvdvuhchange.GioiTinh + ", '" + tvdvuhchange.CCCD + "', '" + tvdvuhchange.DiaChi + "', '" + tvdvuhchange.SDT + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Delete_TVDVUH(ThanhVienDonViUngHo tvdvuh)
        {
            string query = "exec XoaThanhVienDVUH '" + tvdvuh.MaDVUH + "', '" + tvdvuh.HoTen + "'," + tvdvuh.GioiTinh + ", '" + tvdvuh.CCCD + "', '" + tvdvuh.DiaChi + "', '" + tvdvuh.SDT + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public int Check_TVDVUH(ThanhVienDonViUngHo tvdvuh)
        {
            string query = "exec CheckTVDVUH '" + tvdvuh.MaDVUH + "', '" + tvdvuh.HoTen + "'," + tvdvuh.GioiTinh + ", '" + tvdvuh.CCCD + "', '" + tvdvuh.DiaChi + "', '" + tvdvuh.SDT + "'";
            return (int)DataProvider.Instance.ExcuteScalar(query);
        }
        
        /// Hộ dân
        public void Add_HD(HoDan hd)
        {
            string query = "exec ThemHoDan '" + hd.HoTenChuHo + "'," + hd.GioiTinh + ", '" + hd.CCCD + "', '" + hd.DiaChi + "', '" + hd.SDT + "', '" + hd.DienGiaDinh + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Update_HD(HoDan hd)
        {
            string query = "exec CapNhatHoDan '" + hd.MaHD + "','" + hd.HoTenChuHo + "'," + hd.GioiTinh + ", '" + hd.CCCD + "', '" + hd.DiaChi + "', '" + hd.SDT + "', '" + hd.DienGiaDinh + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Delete_HD(string ma)
        {
            string query = "exec XoaHoDan '" + ma + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        /// Đợt ủng hộ
        public void Add_DUH(DotUngHo duh)
        {
            string query = "exec ThemDotUngHo '" + duh.NgayBatDau.ToString("yyyy-MM-dd") + "', '" + duh.NgayKetThuc.ToString("yyyy-MM-dd") + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Update_DUH(DotUngHo duh)
        {
            string query = "exec CapNhatDotUngHo '" + duh.MaDUH + "', '" + duh.NgayBatDau.ToString("yyyy-MM-dd") + "', '" + duh.NgayKetThuc.ToString("yyyy-MM-dd") + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Delete_DUH(string ma)
        {
            string query = "exec XoaDotUngHo '" + ma + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        /// Hình thức ủng hộ
        public void Add_HTUH(HinhThucUngHo htuh)
        {
            string query = "exec ThemHinhThucUngHo '" + htuh.TenHTUH + "', '" + htuh.DonViTinh + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Update_HTUH(HinhThucUngHo htuh)
        {
            string query = "exec CapNhatHinhThucUngHo '" + htuh.MaHTUH + "', '" + htuh.TenHTUH + "', '" + htuh.DonViTinh + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Delete_HTUH(string ma)
        {
            string query = "exec XoaHinhThucUngHo '" + ma + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
