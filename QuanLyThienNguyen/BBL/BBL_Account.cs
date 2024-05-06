using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_Account
    {
        private static BBL_Account instance;

        public static BBL_Account Instance 
        {
            get
            {
                if (instance == null)
                    instance = new BBL_Account();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BBL_Account() { }
        public bool PhanQuyen(string user, string pass)
        {
            Account account = new Account(user, pass);
            string query = "Select count(*) from Account where Username = '" + account.Username + "' and Password = '" + account.Password + "'";
            int count = (int)DataProvider.Instance.ExcuteScalar(query);
            if (count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
