using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThienNguyen.BBL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_ChiTietUngHo
    {
        private static DAL_ChiTietUngHo instance;

        internal static DAL_ChiTietUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_ChiTietUngHo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<ChiTietUngHo> GetAllChiTietUngHo()
        {
            List<ChiTietUngHo> list = new List<ChiTietUngHo>();
            string query = "SELECT * FROM ChiTietUngHo";
            foreach (DataRow row in DataProvider.Instance.ExcuteQuery(query).Rows)
            {
                list.Add(new ChiTietUngHo(row));
            }
            return list;
        }
        public void UpdateActivity(ChiTietUngHo item)
        {
            string query = "EXEC CapNhatActivity " + item.MaCTUH + ", " + item.MaDVUH + ", " + item.MaDUH
                + ", " + item.MaHD
                + ", " + item.MaHTUH + ", " + item.SoLuongUH + ", " + item.SoLuongNUH;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void AddActivity(ChiTietUngHo item)
        {

            string query = "EXEC ThemChiTietUngHo " + item.MaDVUH + ", " + item.MaDUH + ", " + item.MaHD
                + ", " + item.MaHTUH + ", " + item.SoLuongUH + ", " + item.SoLuongNUH;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void DeleteActivity(int maCTUH)
        {
            string query = "DELETE FROM ChiTietUngHo WHERE MaCTUH = " + maCTUH;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Combine(ChiTietUngHo item)
        {
            string query = "EXEC Combine " + item.MaDVUH + ", " + item.MaDUH + ", " + item.MaHD
                + ", " + item.MaHTUH + ", " + item.SoLuongUH + ", " + item.SoLuongNUH;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}