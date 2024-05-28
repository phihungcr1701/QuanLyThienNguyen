using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_DonViUngHo : DALBase<DonViUngHo>
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
        public DAL_DonViUngHo() { }
        public List<DTODonViUngHo> GetAllDonViUngHo()
        {
            var dvuh = from p in GetAll()
                       select new DTODonViUngHo
                       {
                           MaDVUH = p.MaDVUH,
                           TenDonVi = p.TenDonVi,
                           DiaChiDonVi = p.DiaChiDonVi,
                           SDTDonVi = p.SDTDonVi
                       };
            return dvuh.ToList();
        }

        protected override object GetEntityKey(DonViUngHo entity)
        {
            return entity.MaDVUH;
        }

    }
}
