using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_ThongKe : DALBase<ThongKe>
    {
        private static DAL_ThongKe instance;

        public static DAL_ThongKe Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_ThongKe();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<string> GetAllTenHTUH()
        {
            return DAL_ChiTietUngHo.Instance.GetAll().Select(p => p.HinhThucUngHo.TenHTUH.ToString()).Distinct().ToList();
        }
        public List<string> GetAllMaDVUH()
        {
            return DAL_ChiTietUngHo.Instance.GetAll().Select(p => p.MaDVUH.ToString()).Distinct().ToList();
        }
        public List<string> GetAllMaHTUH()
        {
            return DAL_ChiTietUngHo.Instance.GetAll().Select(p => p.MaHTUH.ToString()).Distinct().ToList();
        }
        public List<DTO_ThongKe> GetThongKeByTenHTUH(string ten)
        {
            return GetAll().Where(p => p.HinhThucUngHo.TenHTUH.ToString() == ten).Select(p => new DTO_ThongKe
            {
                TenDVUH = p.DonViUngHo.TenDonVi,
                TenHTUH = p.HinhThucUngHo.TenHTUH,
                TongSoLuongUH = (double)p.TongSoLuongUH,
                SoDuUH = (double)p.SoDuUH,
                DonViTinh = p.HinhThucUngHo.DonViTinh
            }).ToList();
        }
        public void DeleteAll()
        {
            foreach (var item in GetAll())
            {
                Delete(item);
            }
        }
        protected override object GetEntityKey(ThongKe entity)
        {
            return entity.MaTK;
        }
    }
}
