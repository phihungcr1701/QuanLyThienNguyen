using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public List<ActivityView> GetAllActivity()
        {
            List<ActivityView> result = new List<ActivityView>();

            foreach (ChiTietUngHoView item in DAL_ChiTietUngHo.Instance.GetAllChiTietUngHo())
            {
                result.Add(new ActivityView(item.MaCTUH, item.MaDUH, item.MaDVUH, item.MaHD, item.MaHTUH, item.SoLuongUH, item.SoLuongNUH));
            }

            return result;
        }
        public List<ActivityView> GetActiviting()
        {
            List<ActivityView> result = new List<ActivityView>();

            foreach (ChiTietUngHoView item in DAL_ChiTietUngHo.Instance.GetAllChiTietUngHo())
            {
                ActivityView activity = new ActivityView(item.MaCTUH, item.MaDUH,
                    item.MaDVUH, item.MaHD, item.MaHTUH, item.SoLuongUH, item.SoLuongNUH);
                if (activity.NgayKetThuc >= DateTime.Now && activity.NgayBatDau < DateTime.Now)
                {
                    result.Add(activity);
                }
            }

            return result;
        }
        public List<ActivityView> GetActivited()
        {
            List<ActivityView> result = new List<ActivityView>();

            foreach (ChiTietUngHoView item in DAL_ChiTietUngHo.Instance.GetAllChiTietUngHo())
            {
                ActivityView activity = new ActivityView(item.MaCTUH, item.MaDUH,
                    item.MaDVUH, item.MaHD, item.MaHTUH, item.SoLuongUH, item.SoLuongNUH);
                if (activity.NgayKetThuc < DateTime.Now)
                {
                    result.Add(activity);
                }
            }

            return result;
        }
        public List<ActivityView> GetWillActivity()
        {
            List<ActivityView> result = new List<ActivityView>();

            foreach (ChiTietUngHoView item in DAL_ChiTietUngHo.Instance.GetAllChiTietUngHo())
            {
                ActivityView activity = new ActivityView(item.MaCTUH, item.MaDUH,
                    item.MaDVUH, item.MaHD, item.MaHTUH, item.SoLuongUH, item.SoLuongNUH);
                if (activity.NgayBatDau > DateTime.Now)
                {
                    result.Add(activity);
                }
            }

            return result;
        }
        public List<ActivityView> Display(int index, string timkiem, int indexSort)
        {
            List<ActivityView> result;

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
        public List<ActivityView> Search(string timkiem, List<ActivityView> list)
        {
            List<ActivityView> result = new List<ActivityView>();
            foreach (ActivityView activity in list)
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
        public List<ActivityView> Sort(int IndexSort, List<ActivityView> list)
        {
            Comparison<ActivityView> comparison = null;
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
        public void EditActivity(ChiTietUngHoView item)
        {
            ChiTietUngHoView itemOld = GetChiTietUngHoByMaCTUH(item.MaCTUH);
            double sodu = SoDu(item.MaDVUH, item.MaHTUH) + item.SoLuongUH; // - SLUH cu + SLNUH cu + SLUH moi
            if (GetChiTietUngHoByMaCTUH(item.MaCTUH) != null)
            {
                sodu = sodu - itemOld.SoLuongUH + itemOld.SoLuongNUH;
                if (sodu >= item.SoLuongNUH)
                    DAL_ChiTietUngHo.Instance.UpdateActivity(new ChiTietUngHo
                    {
                        STT = item.MaCTUH,
                        MaDVUH = item.MaDVUH,
                        MaDUH = item.MaDUH,
                        MaHD = item.MaHD,
                        MaHTUH = item.MaHTUH,
                        SoLuongUH = item.SoLuongUH,
                        SoLuongNUH = item.SoLuongNUH,
                    });
                else
                    MessageBox.Show("Số lượng nhận ủng hộ vượt quá số lượng ủng hộ");
            }

        }
        public void AddActivity(ChiTietUngHoView item)
        {
            double sodu = SoDu(item.MaDVUH, item.MaHTUH) + item.SoLuongUH;
            if (GetChiTietUngHoByMaCTUH(item.MaCTUH) == null)
            {
                if (CheckChiTietUngHo(item))
                {
                    if (sodu >= item.SoLuongNUH)
                        DAL_ChiTietUngHo.Instance.Combine(new ChiTietUngHo
                        {
                            STT = item.MaCTUH,
                            MaDVUH = item.MaDVUH,
                            MaDUH = item.MaDUH,
                            MaHD = item.MaHD,
                            MaHTUH = item.MaHTUH,
                            SoLuongUH = item.SoLuongUH,
                            SoLuongNUH = item.SoLuongNUH,
                        });
                    else
                        MessageBox.Show("Số lượng nhận ủng hộ vượt quá số lượng ủng hộ");
                }
                else
                {
                    if (sodu >= item.SoLuongNUH)
                        DAL_ChiTietUngHo.Instance.AddActivity(new ChiTietUngHo
                        {
                            STT = item.MaCTUH,
                            MaDVUH = item.MaDVUH,
                            MaDUH = item.MaDUH,
                            MaHD = item.MaHD,
                            MaHTUH = item.MaHTUH,
                            SoLuongUH = item.SoLuongUH,
                            SoLuongNUH = item.SoLuongNUH,
                        });
                    else
                        MessageBox.Show("Số lượng nhận ủng hộ vượt quá số lượng ủng hộ");
                }
            }
            else
            {
                MessageBox.Show("MaCTUH đã tồn tại!");
            }
        }
        public bool CheckChiTietUngHo(ChiTietUngHoView item)
        {
            bool check = false;
            foreach (ChiTietUngHoView i in DAL_ChiTietUngHo.Instance.GetAllChiTietUngHo())
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
        public ChiTietUngHoView GetChiTietUngHoByMaCTUH(string maCTUH)
        {
            ChiTietUngHoView item = null;
            foreach (ChiTietUngHoView i in DAL_ChiTietUngHo.Instance.GetAllChiTietUngHo())
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
            foreach (ChiTietUngHoView i in DAL_ChiTietUngHo.Instance.GetAllChiTietUngHo())
            {
                if (i.MaDVUH.Equals(madvuh) && i.MaHTUH.Equals(mahtuh))
                {
                    sumUH = sumUH + i.SoLuongUH;
                    sumNUH = sumNUH + i.SoLuongNUH;
                }
            }
            return sumUH - sumNUH;
        }
        public void DeleteActivity(string maCTUH)
        {
            ChiTietUngHoView obj = GetChiTietUngHoByMaCTUH(maCTUH);
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hàng dữ liệu này: \n " + obj.MaCTUH + " | " + obj.MaDVUH + " | " + obj.MaDUH + " | " + obj.MaHD + " | " + obj.MaHTUH + " | " + obj.SoLuongUH + " | " + obj.SoLuongNUH, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                DAL_ChiTietUngHo.Instance.DeleteActivity(maCTUH);
            }
            
        }
    }
}