using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
        public List<string> Combobox_Information(string nametable)
        {
            DataTable data = DAL_Information.Instance.View(nametable);
            List<string> list = new List<string>();
            foreach (DataRow row in data.Rows) 
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        public List<string> Combobox_Statistical_TenHTUH()
        {
            List<string> list = new List<string>();
            foreach (DataRow row in DAL_Statistical.Instance.TruyVan_TenHTUH().Rows)
            {
                list.Add(row["TenHTUH"].ToString());
            }
            return list;
        }
        public List<string> Combobox_Statistical_MaDVUH()
        {
            List<string> list = new List<string>();
            foreach (DataRow row in DAL_Statistical.Instance.TruyVan_Ma("MaDVUH").Rows)
            {
                list.Add(row["MaDVUH"].ToString());
            }
            return list;
        }
        public List<string> Combobox_Statistical_MaHTUH()
        {
            List<string> list = new List<string>();
            foreach (DataRow row in DAL_Statistical.Instance.TruyVan_Ma("MaHTUH").Rows)
            {
                list.Add(row["MaHTUH"].ToString());
            }
            return list;
        }
    }
}
