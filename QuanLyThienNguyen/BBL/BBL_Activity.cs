using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;

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
        public List<Activity> GetAllActivity()
        {
            return DAL_Activity.Instance.GetAllActivity();
        }
        public List<Activity> GetActiviting()
        {
            List<Activity> list = new List<Activity>();
            foreach (Activity activity in DAL_Activity.Instance.GetAllActivity())
            {
                if (activity.NgayKetThuc >= DateTime.Now && activity.NgayBatDau <= DateTime.Now)
                {
                    list.Add(activity);
                }
            }
            return list;
        }
        public List<Activity> GetActivited()
        {
            List<Activity> list = new List<Activity>();
            foreach (Activity activity in DAL_Activity.Instance.GetAllActivity())
            {
                if (activity.NgayKetThuc < DateTime.Now)
                {
                    list.Add(activity);
                }
            }
            return list;
        }
        public List<Activity> Search(string timkiem, List<Activity> list)
        {
            List<Activity> result = new List<Activity>();
            foreach (Activity activity in list)
            {
                if (activity.TenDonVi.ToLower().Contains(timkiem) 
                    || activity.HoTenChuHo.ToLower().Contains(timkiem) 
                    || activity.TenHTUH.ToLower().Contains(timkiem) 
                    || activity.SoLuongUH.ToString().ToLower().Contains(timkiem)
                    || activity.SoLuongNUH.ToString().ToLower().Contains(timkiem) 
                    || activity.DonViTinh.ToString().ToLower().Contains(timkiem)
                    || activity.NgayBatDau.ToString().Contains(timkiem)
                    || activity.NgayBatDau.ToString().Contains(timkiem))
                {
                    result.Add(activity);
                    break;
                }    
            }
            return result;
        }
        public List<Activity> View(int index, string timkiem, int indexSort)
        {
            List<Activity> result;

            if (index == 0)
            {
                result = GetAllActivity();
            }
            else if (index == 1)
            {
                result = GetActiviting();
            }
            else
            {
                result = GetActivited();
            }

            if (!string.IsNullOrEmpty(timkiem))
            {
                result = Search(timkiem, result);
            }
            result = Sort(indexSort, result);
            return result;
        }
        
        public List<Activity> Sort(int IndexSort, List<Activity> list)
        {
            Comparison<Activity> comparison = null;
            switch (IndexSort)
            {
                case 0:
                   
                    comparison = (a1, a2) => a1.TenDonVi.CompareTo(a2.TenDonVi);
                    break;
                case 1:
                    comparison = (a1, a2) => a1.HoTenChuHo.CompareTo(a2.HoTenChuHo);
                    break;
                case 2:
                    comparison = (a1, a2) => a1.TenHTUH.CompareTo(a2.TenHTUH);
                    break;
                case 3:
                    comparison = (a1, a2) => a1.SoLuongUH.CompareTo(a2.SoLuongUH);
                    break;
                case 4:
                    comparison = (a1, a2) => a1.SoLuongNUH.CompareTo(a2.SoLuongNUH);
                    break;
                case 5:
                    comparison = (a1, a2) => a1.DonViTinh.CompareTo(a2.DonViTinh);
                    break;
                case 6:
                    comparison = (a1, a2) => a1.NgayBatDau.CompareTo(a2.NgayBatDau);
                    break;
                case 7:
                    comparison = (a1, a2) => a1.NgayKetThuc.CompareTo(a2.NgayKetThuc);
                    break;
                default:
                    return list;
            }
            list.Sort(comparison); 
            return list;
        }
        public List<string> GetCBB(string FieldName, string TableName)
        {
            return DAL_Activity.Instance.GetCBB(FieldName, TableName);
        }
        public List<Activity> AddActivity(Activity activity)
        {
            List<Activity> list = GetAllActivity();
            
            list.Add(activity);
            return list;
        }
        public bool CheckMaDUH(int ma)
        {
            return true;
        }
        public bool CheckMaDVUH(int ma)
        {
            return true;
        }
        public bool CheckMaHD(int ma)
        {
            return true;
        }
        public bool CheckMaHTUH(int ma)
        {
            return true;
        }
    }
}
