using QuanLyThienNguyen.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_DVUH
    {
        private static BBL_DVUH instance;

        public static BBL_DVUH Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_DVUH();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public BBL_DVUH() { }
        public void BBL_Add_DVUH(string hoten, int gioitinh, string cccd, string diachi, string sdt)
        {
            DAL_DVUH.Instance.DAL_Add_DVUH(hoten, gioitinh, cccd, diachi, sdt);
        }
        public void BBL_Update_DVUH(int ma, string hoten, int gioitinh, string cccd, string diachi, string sdt)
        {
            DAL_DVUH.Instance.DAL_Update_DVUH(ma, hoten, gioitinh, cccd, diachi, sdt);
        }
        public void BBL_Delete_DVUH(int ma)
        {
            DAL_DVUH.Instance.DAL_Delete_DVUH(ma);
        }
    }
}
