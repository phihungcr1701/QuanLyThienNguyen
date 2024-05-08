using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_DVUH
    {
        private static DAL_DVUH instance;

        public static DAL_DVUH Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_DVUH();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DAL_DVUH() { }
        public void DAL_Add_DVUH(string hoten, int gioitinh, string cccd, string diachi, string sdt)
        {
            string query = "exec ThemDonViUngHo '"+ hoten +"',"+ gioitinh +", '"+ cccd +"', '"+ diachi +"', '"+ sdt +"'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void DAL_Update_DVUH(int ma, string hoten, int gioitinh, string cccd, string diachi, string sdt)
        {
            string query = "exec CapNhatDonViUngHo '"+ ma +"','" + hoten + "'," + gioitinh + ", '" + cccd + "', '" + diachi + "', '" + sdt + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void DAL_Delete_DVUH(int ma)
        {
            string query = "exec XoaDonViUngHo '" + ma + "'";
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
