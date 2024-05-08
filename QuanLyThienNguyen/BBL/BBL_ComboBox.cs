using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_ComboBox
    {
        private static BBL_ComboBox instance;

        public static BBL_ComboBox Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_ComboBox();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BBL_ComboBox() { }
        public List<string> BBL_ComboboxList(string nametable, string namecolumn)
        {
            DataTable data = DAL_Information.Instance.DAL_InformationView(nametable, "", namecolumn);
            List<string> list = new List<string>();
            foreach (DataRow row in data.Rows) 
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
    }
}
