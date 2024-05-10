using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.DAL;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_Activity
    {
        private static BBL_Activity instance;

        public static BBL_Activity Instance 
        {
            get
            {
                if (instance == null)
                    instance = new BBL_Activity();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BBL_Activity() { }
        public DataTable Show()
        {
            DataTable dataTable = DAL_Activity.Instance.show();
            return dataTable;
        }
    }
}
