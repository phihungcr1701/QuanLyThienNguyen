using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_ChiTietUngHo
    {
        private static BBL_ChiTietUngHo instance;

        public static BBL_ChiTietUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_ChiTietUngHo();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BBL_ChiTietUngHo() { }

        public List<DTOActivity> GetAllActivity()
        {
            List<DTOActivity> result = new List<DTOActivity>();
            foreach (ChiTietUngHo item in DAL_ChiTietUngHo.Instance.GetAll())
            {
                DTOActivity activity = new DTOActivity(item.MaCTUH, item.MaDUH,
                    item.MaDVUH, item.MaHD, item.MaHTUH, item.SoLuongUH.Value, item.SoLuongNUH.Value);
                result.Add(activity);
            }
            return result;
        }
        public List<DTOActivity> GetActiviting()
        {
            List<DTOActivity> result = new List<DTOActivity>();
            foreach (ChiTietUngHo item in DAL_ChiTietUngHo.Instance.GetAll())
            {
                DTOActivity activity = new DTOActivity(item.MaCTUH, item.MaDUH,
                    item.MaDVUH, item.MaHD, item.MaHTUH, item.SoLuongUH.Value, item.SoLuongNUH.Value);
                if (activity.NgayKetThuc >= DateTime.Now && activity.NgayBatDau < DateTime.Now)
                {
                    result.Add(activity);
                }
            }
            return result;
        }
        public List<DTOActivity> GetActivited()
        {
            List<DTOActivity> result = new List<DTOActivity>();

            foreach (ChiTietUngHo item in DAL_ChiTietUngHo.Instance.GetAll())
            {
                DTOActivity activity = new DTOActivity(item.MaCTUH, item.MaDUH,
                    item.MaDVUH, item.MaHD, item.MaHTUH, item.SoLuongUH.Value, item.SoLuongNUH.Value);
                if (activity.NgayKetThuc < DateTime.Now)
                {
                    result.Add(activity);
                }
            }

            return result;
        }
        public List<DTOActivity> GetWillActivity()
        {
            List<DTOActivity> result = new List<DTOActivity>();

            foreach (ChiTietUngHo item in DAL_ChiTietUngHo.Instance.GetAll())
            {
                DTOActivity activity = new DTOActivity(item.MaCTUH, item.MaDUH,
                    item.MaDVUH, item.MaHD, item.MaHTUH, item.SoLuongUH.Value, item.SoLuongNUH.Value);
                if (activity.NgayBatDau > DateTime.Now)
                {
                    result.Add(activity);
                }
            }

            return result;
        }
        public List<DTOActivity> Display(int index, string timkiem, int indexSort)
        {
            List<DTOActivity> result;

            if (index == 0)
            {
                result = GetAllActivity();
            }
            else if (index == 1)
            {
                result = GetActiviting();
            }
            else if (index == 2)
            {
                result = GetActivited();
            }
            else
            {
                result = GetWillActivity();
            }

            if (!string.IsNullOrEmpty(timkiem))
            {
                result = Search(timkiem, result);
            }
            result = Sort(indexSort, result);
            return result;

        }
        public List<DTOActivity> Search(string timkiem, List<DTOActivity> list)
        {
            List<DTOActivity> result = new List<DTOActivity>();
            foreach (DTOActivity activity in list)
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

                }
            }
            return result;
        }
        public List<DTOActivity> Sort(int IndexSort, List<DTOActivity> list)
        {
            Comparison<DTOActivity> comparison = null;
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
        public void EditActivity(ChiTietUngHo item)
        {
            ChiTietUngHo itemOld = GetChiTietUngHoByMaCTUH(item.MaCTUH);
            double sodu = SoDu(item.MaCTUH, item.MaHTUH) + item.SoLuongUH.Value; // - SLUH cu + SLNUH cu + SLUH moi
            if (GetChiTietUngHoByMaCTUH(item.MaCTUH) != null)
            {
                sodu = sodu - itemOld.SoLuongUH.Value + itemOld.SoLuongNUH.Value;
                if (sodu >= item.SoLuongNUH)
                    DAL_ChiTietUngHo.Instance.Update(item);
                else
                    MessageBox.Show("Số lượng nhận ủng hộ vượt quá số lượng ủng hộ");
            }

        }
        public void AddActivity(ChiTietUngHo item)
        {
            double sodu = SoDu(item.MaCTUH, item.MaHTUH) + item.SoLuongUH.Value;
            if (GetChiTietUngHoByMaCTUH(item.MaCTUH) == null)
            {
                if (CheckChiTietUngHo(item))
                {
                    if (sodu >= item.SoLuongNUH)
                        DAL_ChiTietUngHo.Instance.AddCombine(item);
                    else
                        MessageBox.Show("Số lượng nhận ủng hộ vượt quá số lượng ủng hộ");
                }
                else
                {
                    if (sodu >= item.SoLuongNUH)
                        DAL_ChiTietUngHo.Instance.Add(item);
                    else
                        MessageBox.Show("Số lượng nhận ủng hộ vượt quá số lượng ủng hộ");
                }
            }
            else
            {
                MessageBox.Show("MaCTUH đã tồn tại!");
            }
        }
        public bool CheckChiTietUngHo(ChiTietUngHo item)
        {
            bool check = false;
            foreach (ChiTietUngHo i in DAL_ChiTietUngHo.Instance.GetAll())
            {
                if (item.MaDVUH == i.MaDVUH && item.MaDUH == i.MaDUH && item.MaHD == i.MaHD
                    && item.MaHTUH == i.MaHTUH)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public ChiTietUngHo GetChiTietUngHoByMaCTUH(string maCTUH)
        {
            ChiTietUngHo item = null;
            foreach (ChiTietUngHo i in DAL_ChiTietUngHo.Instance.GetAll())
            {
                if (i.MaCTUH.Equals(maCTUH))
                {
                    item = i;
                    break;
                }
            }
            return item;
        }
        public double SoDu(string madvuh, string mahtuh)
        {
            double sumUH = 0;
            double sumNUH = 0;
            foreach (ChiTietUngHo i in DAL_ChiTietUngHo.Instance.GetAll())
            {
                if (i.MaDVUH.Equals(madvuh) && i.MaHTUH.Equals(mahtuh))
                {
                    sumUH = sumUH + i.SoLuongUH.Value;
                    sumNUH = sumNUH + i.SoLuongNUH.Value;
                }
            }
            return sumUH - sumNUH;
        }
        public void DeleteActivity(string maCTUH)
        {
            DAL_ChiTietUngHo.Instance.Delete(GetChiTietUngHoByMaCTUH(maCTUH));
        }
    }
}