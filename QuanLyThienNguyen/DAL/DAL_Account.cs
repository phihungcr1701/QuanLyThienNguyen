using QuanLyThienNguyen.DTO;
using System.Data;
using System.Linq;

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
        public bool PhanQuyen(string user, string pass)
        {
            DataContext context = new DataContext();
            int count = context.Accounts.Where(p => p.Username == user && p.Password == pass).Count();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
