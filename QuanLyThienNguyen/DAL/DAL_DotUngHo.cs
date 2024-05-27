using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_DotUngHo
    {
        private static DAL_DotUngHo instance;
        public static DAL_DotUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_DotUngHo();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public List<DotUngHoView> GetAllDotUngHo()
        {
            DataContext context = new DataContext();
            List<DotUngHoView> list = new List<DotUngHoView>();
            foreach (var item in context.DotUngHoes)
            {
                list.Add(new DotUngHoView(item.MaDUH, item.NgayBatDau, item.NgayKetThuc));
            }
            return list;
        }
        public void Add(DotUngHo duh)
        {
            DataContext context = new DataContext();
            context.DotUngHoes.Add(duh);
            context.SaveChanges();
        }
        public void Update(DotUngHo duh)
        {
            DataContext context = new DataContext();
            var obj = context.DotUngHoes.Find(duh.MaDUH);
            obj.NgayBatDau = duh.NgayBatDau;
            obj.NgayKetThuc = duh.NgayKetThuc;
            context.SaveChanges();
        }
        public void Delete(string ma)
        {
            DataContext context = new DataContext();
            context.DotUngHoes.Remove(context.DotUngHoes.Find(ma));
            context.SaveChanges();
        }
    }
}
