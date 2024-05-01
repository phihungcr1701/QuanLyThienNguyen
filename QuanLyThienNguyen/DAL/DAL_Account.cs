using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_Account
    {
        private static DAL_Account instance;

        public static DAL_Account Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_Account();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private DAL_Account() { }
        //public int PhanQuyen()
    }
}
