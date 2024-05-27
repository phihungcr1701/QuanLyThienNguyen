using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_HoDan
    {
        private static DAL_HoDan instance;
        public static DAL_HoDan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_HoDan();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public List<HoDanView> GetAllHoDan()
        {
            DataContext context = new DataContext();
            List<HoDanView> list = new List<HoDanView>();
            foreach (var item in context.HoDans)
            {
                list.Add(new HoDanView(item.MaHD, item.HoTenChuHo, item.GioiTinh, item.CCCD, item.DiaChi, item.SDT, item.DienGiaDinh));
            }
            return list;
        }

        public void Add(HoDan hd)
        {
            DataContext context = new DataContext();
            context.HoDans.Add(hd);
            context.SaveChanges();
        }
        public void Update(HoDan hd)
        {
            DataContext context = new DataContext();
            var obj = context.HoDans.Find(hd.MaHD);
            obj.HoTenChuHo = hd.HoTenChuHo;
            obj.GioiTinh = hd.GioiTinh;
            obj.CCCD = hd.CCCD;
            obj.DiaChi = hd.DiaChi;
            obj.SDT = hd.SDT;
            obj.DienGiaDinh = hd.DienGiaDinh;
            context.SaveChanges();
        }
        public void Delete(string ma)
        {
            DataContext context = new DataContext();
            context.HoDans.Remove(context.HoDans.Find(ma));
            context.SaveChanges();
        }
    }
}