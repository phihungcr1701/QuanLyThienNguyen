using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_DonViUngHo
    {
        private static DAL_DonViUngHo instance;
        public static DAL_DonViUngHo Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_DonViUngHo();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public List<DonViUngHoView> GetAllDonViUngHo()
        {
            DataContext context = new DataContext();
            List<DonViUngHoView> list = new List<DonViUngHoView>();
            foreach (var item in context.DonViUngHoes)
            {
                list.Add(new DonViUngHoView(item.MaDVUH, item.TenDonVi, item.DiaChiDonVi, item.SDTDonVi));
            }
            return list;
        }
        public void Add(DonViUngHo dvuh)
        {
            DataContext context = new DataContext();
            context.DonViUngHoes.Add(dvuh);
            context.SaveChanges();
        }
        public void Update(DonViUngHo dvuh)
        {
            DataContext context = new DataContext();
            var obj = context.DonViUngHoes.Find(dvuh.MaDVUH);
            obj.TenDonVi = dvuh.TenDonVi;
            obj.DiaChiDonVi = dvuh.DiaChiDonVi;
            obj.SDTDonVi = dvuh.SDTDonVi;
            context.SaveChanges();
        }
        public void Delete(string ma)
        {
            DataContext context = new DataContext();
            context.DonViUngHoes.Remove(context.DonViUngHoes.Find(ma));
            context.SaveChanges();
        }
    }
}
