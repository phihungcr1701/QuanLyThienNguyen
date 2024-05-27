using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_HinhThucUngHo
    {
        private static DAL_HinhThucUngHo instance;
        public static DAL_HinhThucUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_HinhThucUngHo();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public List<HinhThucUngHoView> GetAllHinhThucUngHo()
        {
            DataContext context = new DataContext();
            List<HinhThucUngHoView> list = new List<HinhThucUngHoView>();
            foreach (var item in context.HinhThucUngHoes)
            {
                list.Add(new HinhThucUngHoView(item.MaHTUH, item.TenHTUH, item.DonViTinh));
            }
            return list;
        }

        public void Add(HinhThucUngHo htuh)
        {
            DataContext context = new DataContext();
            context.HinhThucUngHoes.Add(htuh);
            context.SaveChanges();
        }
        public void Update(HinhThucUngHo htuh)
        {
            DataContext context = new DataContext();
            var obj = context.HinhThucUngHoes.Find(htuh.MaHTUH);
            obj.TenHTUH = htuh.TenHTUH;
            obj.DonViTinh = htuh.DonViTinh;
            context.SaveChanges();
        }
        public void Delete(string ma)
        {
            DataContext context = new DataContext();
            context.HinhThucUngHoes.Remove(context.HinhThucUngHoes.Find(ma));
            context.SaveChanges();
        }
    }
}
