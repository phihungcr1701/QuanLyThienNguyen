using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Documents;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_ThanhVienDVUH
    {
        private static DAL_ThanhVienDVUH instance;
        public static DAL_ThanhVienDVUH Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_ThanhVienDVUH();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DAL_ThanhVienDVUH() { }
        public List<ThanhVienDVUHView> GetAllThanhVienDVUH()
        {
            DataContext context = new DataContext();
            List<ThanhVienDVUHView> list = new List<ThanhVienDVUHView>();
            foreach (var item in context.ThanhVienDVUHs)
            {
                list.Add(new ThanhVienDVUHView(item.MaDVUH, item.HoTen, item.GioiTinh, item.CCCD, item.DiaChi, item.SDT));
            }
            return list;
        }
        public void Add(ThanhVienDVUH tvdvuh)
        {
            DataContext context = new DataContext();
            context.ThanhVienDVUHs.Add(tvdvuh); 
            context.SaveChanges();
        }
        public void Update(ThanhVienDVUH tvdvuh, ThanhVienDVUH tvdvuhchange)
        {
            DataContext context = new DataContext();
            var obj = context.ThanhVienDVUHs.Find(tvdvuh);
            obj.MaDVUH = tvdvuhchange.MaDVUH;
            obj.HoTen = tvdvuhchange.HoTen;
            obj.GioiTinh = tvdvuhchange.GioiTinh;
            obj.CCCD = tvdvuhchange.CCCD;
            obj.DiaChi = tvdvuhchange.DiaChi;
            obj.SDT = tvdvuhchange.SDT;
        }
        public void Delete(ThanhVienDVUH tvdvuh)
        {
            DataContext context = new DataContext();
            var list = context.ThanhVienDVUHs
                            .FirstOrDefault(p => p.MaDVUH == tvdvuh.MaDVUH &&
                                                 p.HoTen == tvdvuh.HoTen &&
                                                 p.GioiTinh == tvdvuh.GioiTinh &&
                                                 p.CCCD == tvdvuh.CCCD &&
                                                 p.DiaChi == tvdvuh.DiaChi &&
                                                 p.SDT == tvdvuh.SDT);
            context.ThanhVienDVUHs.Remove(list);
            context.SaveChanges();
        }
        public int Check(ThanhVienDVUH tvdvuh)
        {
            DataContext context = new DataContext();
            return context.ThanhVienDVUHs.Where(p => p.MaDVUH == tvdvuh.MaDVUH &&
                                                     p.HoTen == tvdvuh.HoTen &&
                                                     p.GioiTinh == tvdvuh.GioiTinh &&
                                                     p.CCCD == tvdvuh.CCCD &&
                                                     p.DiaChi == tvdvuh.DiaChi &&
                                                     p.SDT == tvdvuh.SDT).Count();
        }
    }
}
