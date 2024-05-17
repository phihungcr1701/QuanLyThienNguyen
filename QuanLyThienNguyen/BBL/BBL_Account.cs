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
            return DAL_Account.Instance.PhanQuyen(user, pass);
        }
    }
}
