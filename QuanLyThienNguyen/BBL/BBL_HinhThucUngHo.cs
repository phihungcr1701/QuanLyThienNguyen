using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_HinhThucUngHo
    {
        private static BBL_HinhThucUngHo instance;

        public static BBL_HinhThucUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_HinhThucUngHo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BBL_HinhThucUngHo() { }
        public HinhThucUngHo GetHinhThucUngHo(int ma)
        {
            foreach (HinhThucUngHo item in DAL_HinhThucUngHo.Instance.GetAllHinhThucUngHo())
            {
                if (item.MaHTUH == ma)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
