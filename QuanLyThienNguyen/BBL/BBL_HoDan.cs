using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_HoDan
    {
        private static BBL_HoDan instance;

        public static BBL_HoDan Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_HoDan();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BBL_HoDan() { }
        
        public HoDan GetHoDan(int ma)
        {
            HoDan hodan = new HoDan();
            foreach (HoDan item in DAL_HoDan.Instance.GetAllHoDan())
            {
                if (item.MaHD == ma)
                {
                    return hodan;
                    break;
                }
            }
            return hodan;
        }
        public List<HoDan> getallHD()
        {
            return DAL_HoDan.Instance.GetAllHoDan();
        }
    }
}
