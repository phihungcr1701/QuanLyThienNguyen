using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_ThongKe
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
        public DAL_ThongKe() { }
        public List<string> GetAllTenHTUH()
        {
            DataContext context = new DataContext();
            List<string> list = new List<string>();
            foreach (string item in context.ChiTietUngHoes.Select(p => p.HinhThucUngHo.TenHTUH).Distinct())
            {
                list.Add(item);
            }
            return list;
        }
        public List<string> GetAllMaDVUH()
        {
            DataContext context = new DataContext();
            List<string> list = new List<string>();
            foreach (string item in context.ChiTietUngHoes.Select(p => p.MaDVUH).Distinct())
            {
                list.Add(item);
            }
            return list;
        }
        public List<string> GetAllMaHTUH()
        {
            DataContext context = new DataContext();
            List<string> list = new List<string>();
            foreach (string item in context.ChiTietUngHoes.Select(p => p.MaHTUH).Distinct())
            {
                list.Add(item);
            }
            return list;
        }
        public List<ThongKeView> GetAllThongKe(string ten)
        {
            DataContext context = new DataContext();
            List<ThongKeView> list = new List<ThongKeView>();
            foreach (var item in context.ThongKes)
            {
                list.Add(new ThongKeView(item.DonViUngHo.TenDonVi, item.HinhThucUngHo.TenHTUH, (double)item.TongSoLuongUH, (double)item.SoDuUH, item.HinhThucUngHo.DonViTinh));
            }
            return list;
        }
        public void Add(ThongKe tk)
        {
            DataContext context = new DataContext();
            context.ThongKes.Add(tk);
            context.SaveChanges();
        }
        public void Delete()
        {
            DataContext context = new DataContext();
            context.ThongKes.RemoveRange(context.ThongKes);
            context.SaveChanges();
        }
    }
}
