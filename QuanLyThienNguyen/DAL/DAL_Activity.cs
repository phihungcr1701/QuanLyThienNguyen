using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using QuanLyThienNguyen.BBL;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_Activity
    {
        private static DAL_Activity instance;

        internal static DAL_Activity Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_Activity();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DataTable show()
        {
            string query = "EXEC InformationTableDonViUngHo";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }
    }
}
