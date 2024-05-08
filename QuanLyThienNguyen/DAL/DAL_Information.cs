using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_Information
    {
        private static DAL_Information instance;
        public static DAL_Information Instance 
        {  
            get 
            {
                if (instance == null)
                    instance = new DAL_Information();
                return instance; 
            } 
            set
            {
                instance = value;
            }
        }
        public DAL_Information() { }
        public DataTable DAL_InformationView(string nametable, string text, string namerow)
        {
            string query = "exec InformationTable" + nametable + " '" + text + "', '" + namerow + "'";
            return DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
