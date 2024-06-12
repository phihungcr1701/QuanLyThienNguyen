using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using MessageBox = System.Windows.MessageBox;

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

        public List<DTO_Activity> GetAllActivity()
        {
            List<DTO_Activity> result = new List<DTO_Activity>();
            foreach (ChiTietUngHo item in DAL_ChiTietUngHo.Instance.GetAll())
            {
                DTO_Activity activity = new DTO_Activity(item.MaCTUH, item.MaDUH,
                    item.MaDVUH, item.MaHD, item.MaHTUH, item.SoLuongUH.Value, item.SoLuongNUH.Value,
                    item.TenHoatDong, item.MoTa, item.AnhHoatDong);
                result.Add(activity);
            }
            return result;
        }
        public List<DTO_Activity> GetActiviting()
        {
            List<DTO_Activity> result = new List<DTO_Activity>();
            foreach (ChiTietUngHo item in DAL_ChiTietUngHo.Instance.GetAll())
            {
                DTO_Activity activity = new DTO_Activity(item.MaCTUH, item.MaDUH,
                    item.MaDVUH, item.MaHD, item.MaHTUH, item.SoLuongUH.Value, item.SoLuongNUH.Value,
                    item.TenHoatDong, item.MoTa, item.AnhHoatDong);
                if (activity.NgayKetThuc >= DateTime.Now && activity.NgayBatDau < DateTime.Now)
                {
                    result.Add(activity);
                }
            }
            return result;
        }
        public List<DTO_Activity> GetActivited()
        {
            List<DTO_Activity> result = new List<DTO_Activity>();

            foreach (ChiTietUngHo item in DAL_ChiTietUngHo.Instance.GetAll())
            {
                DTO_Activity activity = new DTO_Activity(item.MaCTUH, item.MaDUH,
                    item.MaDVUH, item.MaHD, item.MaHTUH, item.SoLuongUH.Value, item.SoLuongNUH.Value,
                    item.TenHoatDong, item.MoTa, item.AnhHoatDong);
                if (activity.NgayKetThuc < DateTime.Now)
                {
                    result.Add(activity);
                }
            }

            return result;
        }
        public List<DTO_Activity> GetWillActivity()
        {
            List<DTO_Activity> result = new List<DTO_Activity>();

            foreach (ChiTietUngHo item in DAL_ChiTietUngHo.Instance.GetAll())
            {
                DTO_Activity activity = new DTO_Activity(item.MaCTUH, item.MaDUH,
                     item.MaDVUH, item.MaHD, item.MaHTUH, item.SoLuongUH.Value, item.SoLuongNUH.Value,
                     item.TenHoatDong, item.MoTa, item.AnhHoatDong);
                if (activity.NgayBatDau > DateTime.Now)
                {
                    result.Add(activity);
                }
            }

            return result;
        }
        public List<DTO_Activity> Display(int index, string timkiem, int indexSort)
        {
            List<DTO_Activity> result;

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
        public List<DTO_Activity> Search(string timkiem, List<DTO_Activity> list)
        {
            timkiem.ToLower();
            List<DTO_Activity> result = new List<DTO_Activity>();
            foreach (DTO_Activity activity in list)
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
        public List<DTO_Activity> Sort(int IndexSort, List<DTO_Activity> list)
        {
            Comparison<DTO_Activity> comparison = null;
            switch (IndexSort)
            {
                case 0:
                    comparison = (a1, a2) => a1.MaCTUH.CompareTo(a2.MaCTUH);
                    break;
                case 1:
                    comparison = (a1, a2) => a1.TenDonVi.CompareTo(a2.TenDonVi);
                    break;
                case 2:
                    comparison = (a1, a2) => a1.HoTenChuHo.CompareTo(a2.HoTenChuHo);
                    break;
                case 3:
                    comparison = (a1, a2) => a1.TenHTUH.CompareTo(a2.TenHTUH);
                    break;
                case 4:
                    comparison = (a1, a2) => a1.SoLuongUH.CompareTo(a2.SoLuongUH);
                    break;
                case 5:
                    comparison = (a1, a2) => a1.SoLuongNUH.CompareTo(a2.SoLuongNUH);
                    break;
                case 6:
                    comparison = (a1, a2) => a1.DonViTinh.CompareTo(a2.DonViTinh);
                    break;
                case 7:
                    comparison = (a1, a2) => a1.NgayBatDau.CompareTo(a2.NgayBatDau);
                    break;
                case 8:
                    comparison = (a1, a2) => a1.NgayKetThuc.CompareTo(a2.NgayKetThuc);
                    break;
                default:
                    return list;
            }
            list.Sort(comparison);
            return list;
        }
        public void EditActivity(ChiTietUngHo item, out bool formClose)
        {
            formClose = false;
            ChiTietUngHo itemOld = GetChiTietUngHoByMaCTUH(item.MaCTUH);
            double sodu = SoDu(item.MaDVUH, item.MaHTUH) + item.SoLuongUH.Value - item.SoLuongNUH.Value; // - SLUH cu + SLNUH cu + SLUH moi
            if (GetChiTietUngHoByMaCTUH(item.MaCTUH) != null)
            {
                sodu = sodu - itemOld.SoLuongUH.Value + itemOld.SoLuongNUH.Value;
                if (CheckChiTietUngHo(item))
                {
                    DialogResult result = System.Windows.Forms.MessageBox.Show("Các trường MaDVUH, MaHD, MaHTUH, MaDUH đã tồn tại. Bạn có muốn" +
                    " cộng SoLuongUH, SoLuongNUH vào record đã có và xóa record này không?", "Thông báo", (MessageBoxButtons)MessageBoxButton.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (sodu >= 0)
                        {
                            DAL_ChiTietUngHo.Instance.AddCombine(item);
                            DAL_ChiTietUngHo.Instance.Delete(itemOld);
                            formClose = true;
                        }
                        else
                            System.Windows.MessageBox.Show("Số lượng nhận ủng hộ vượt quá số lượng ủng hộ");
                    }
                }
                else
                {
                    if (sodu >= 0)
                    {
                        DAL_ChiTietUngHo.Instance.Update(item);
                        formClose = true;
                    }    
                    else
                        System.Windows.MessageBox.Show("Số lượng nhận ủng hộ vượt quá số lượng ủng hộ");
                }
            }

        }
        public void AddActivity(ChiTietUngHo item, out bool formClose)
        {
            formClose = false;
            double sodu = SoDu(item.MaDVUH, item.MaHTUH) + item.SoLuongUH.Value;
            if (GetChiTietUngHoByMaCTUH(item.MaCTUH) == null)
            {
                if (CheckChiTietUngHo(item))
                {
                    DialogResult result = System.Windows.Forms.MessageBox.Show("Các trường MaDVUH, MaHD, MaHTUH, MaDUH đã tồn tại. Bạn có muốn" +
                    " cộng SoLuongUH, SoLuongNUH vào record đã có không?", "Thông báo", (MessageBoxButtons)MessageBoxButton.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (sodu >= item.SoLuongNUH)
                        {
                            DAL_ChiTietUngHo.Instance.AddCombine(item);
                            formClose = true;
                        }    
                        else
                            System.Windows.MessageBox.Show("Số lượng nhận ủng hộ vượt quá số lượng ủng hộ");
                    }
                }
                else
                {
                    DialogResult rs = (DialogResult)System.Windows.MessageBox.Show("Bạn có chắc chắn thêm không", "Thông báo", MessageBoxButton.YesNo);

                    if (rs == DialogResult.Yes)
                    {
                        if (sodu >= item.SoLuongNUH)
                        {
                            DAL_ChiTietUngHo.Instance.Add(item);
                            formClose = true;
                        }    
                        else
                            System.Windows.MessageBox.Show("Số lượng nhận ủng hộ vượt quá số lượng ủng hộ");
                    }    
                }
            }
            else
            {
                MessageBox.Show("MaCTUH đã tồn tại", "Thông báo", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
        }
        public bool CheckChiTietUngHo(ChiTietUngHo item)
        {
            bool check = false;
            foreach (ChiTietUngHo i in DAL_ChiTietUngHo.Instance.GetAll())
            {
                if (item.MaDVUH == i.MaDVUH && item.MaDUH == i.MaDUH && item.MaHD == i.MaHD
                    && item.MaHTUH == i.MaHTUH && item.MaCTUH != i.MaCTUH)
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
        public double TongSoLuong(string madvuh, string mahtuh)
        {
            double sumUH = 0;
            foreach (ChiTietUngHo i in DAL_ChiTietUngHo.Instance.GetAll())
            {
                if (i.MaDVUH.Equals(madvuh) && i.MaHTUH.Equals(mahtuh))
                {
                    sumUH = sumUH + i.SoLuongUH.Value;
                }
            }
            return sumUH;
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
            DialogResult result = (DialogResult)MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == DialogResult.Yes)
                DAL_ChiTietUngHo.Instance.Delete(GetChiTietUngHoByMaCTUH(maCTUH));
        }

        public byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        // chuyen tu byte sang img
        public Image ByteArrayToImage(byte[] b)
        {
            if (b == null || b.Length == 0)
            {
                throw new ArgumentException("Dữ liệu byte không hợp lệ.");
            }

            using (MemoryStream m = new MemoryStream(b))
            {
                return Image.FromStream(m);
            }
        }
    }
}