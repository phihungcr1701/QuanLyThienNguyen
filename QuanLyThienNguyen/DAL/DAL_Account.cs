using QuanLyThienNguyen.DTO;
using System.Data;
using System.Linq;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_Account : DALBase<Account>
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

            var acc = from p in GetAll()
                      where user == p.Username && pass == p.Password
                      select p;
            return acc.Any();
        }

        protected override object GetEntityKey(Account entity)
        {
            return entity.Id;
        }
    }
}
