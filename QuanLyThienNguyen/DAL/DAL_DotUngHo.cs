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
        public List<DTO_DotUngHo> GetAllDotUngHo()
        {
            return GetAll().Select(p => new DTO_DotUngHo
            {
                MaDUH = p.MaDUH,
                NgayBatDau = p.NgayBatDau,
                NgayKetThuc = p.NgayKetThuc,
            }).ToList();
        }
        protected override object GetEntityKey(DotUngHo entity)
        {
            return entity.MaDUH;
        }
    }
}