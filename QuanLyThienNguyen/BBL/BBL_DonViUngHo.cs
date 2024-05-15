using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_DonViUngHo
    {
        private static BBL_DonViUngHo instance;

        public static BBL_DonViUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_DonViUngHo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BBL_DonViUngHo() { }
        public DonViUngHo GetDonViUngHo(int ma)
        {
            DonViUngHo donviungho = new DonViUngHo();
            foreach (DonViUngHo item in DAL_DonViUngHo.Instance.GetAllDonViUngHo())
            {
                if (item.MaDVUH == ma)
                {
                    return donviungho;
                    break;
                }
            }
            return donviungho;
        }

    
    }
}
