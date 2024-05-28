using QuanLyThienNguyen.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyThienNguyen.DAL
{
    internal class DAL_DotUngHo : DALBase<DotUngHo>
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
        public DAL_DotUngHo() { }
        public List<DTODotUngHo> GetAllDotUngHo()
        {
            List<DTODotUngHo> list = new List<DTODotUngHo>();
            var duh = from p in GetAll()
                      select new DTODotUngHo
                      {
                          MaDUH = p.MaDUH,
                          NgayBatDau = p.NgayBatDau,
                          NgayKetThuc = p.NgayKetThuc,
                      };
            return duh.ToList();
        }

        protected override object GetEntityKey(DotUngHo entity)
        {
            return entity.MaDUH;
        }
    }
}
