using QuanLyThienNguyen.DTO;
using System.Data;

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
