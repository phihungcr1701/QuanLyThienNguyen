using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_DotUngHo
    {
        private static BBL_DotUngHo instance;

        public static BBL_DotUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_DotUngHo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BBL_DotUngHo() { }
        public DotUngHo GetDotUngHo(int ma)
        {
            DotUngHo dotUngHo = new DotUngHo();
            foreach (DotUngHo item in DAL_DotUngHo.Instance.GetAllDotUngHo())
            {
                if (item.MaDUH == ma)
                {
                    return dotUngHo;
                    break;
                }
            }
            return dotUngHo;
        }
    }
}
