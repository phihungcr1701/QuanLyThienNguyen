using QuanLyThienNguyen.DAL;
using QuanLyThienNguyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.BBL
{
    internal class BBL_Information
    {
        private static BBL_Information instance;

        public static BBL_Information Instance
        {
            get
            {
                if (instance == null)
                    instance = new BBL_Information();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public BBL_Information() { }
        public string ConvertToNameTable(string nametable)
        {
            if (nametable == "Đơn vị ủng hộ")
                return "DonViUngHo";
            if (nametable == "Thành viên đơn vị ủng hộ")
                return "ThanhVienDVUH";
            if (nametable == "Hộ dân")
                return "HoDan";
            if (nametable == "Đợt ủng hộ")
                return "DotUngHo";
            if (nametable == "Hình thức ủng hộ")
                return "HinhThucUngHo";
            return "";
        }
        public DataTable BBL_InformationView(string nametable, string text, string namerow) 
        {
            nametable = ConvertToNameTable (nametable);
            return DAL_Information.Instance.DAL_InformationView(nametable, text, namerow);
        }

        /// Đơn vị ủng hộ
        public void BBL_Add_DVUH(DonViUngHo dvuh)
        {
            DAL_Information.Instance.DAL_Add_DVUH(dvuh);
        }
        public void BBL_Update_DVUH(DonViUngHo dvuh)
        {
            DAL_Information.Instance.DAL_Update_DVUH(dvuh);
        }
        public void BBL_Delete_DVUH(DonViUngHo dvuh)
        {
            DAL_Information.Instance.DAL_Delete_DVUH(dvuh);
        }

        /// Thành viên đơn vị ủng hộ
        public void BBL_Add_TVDVUH(ThanhVienDonViUngHo tvdvuh)
        {
            DAL_Information.Instance.DAL_Add_TVDVUH(tvdvuh);
        }
        public void BBL_Update_TVDVUH(ThanhVienDonViUngHo tvdvuh, ThanhVienDonViUngHo tvdvuhchange)
        {
            DAL_Information.Instance.DAL_Update_TVDVUH(tvdvuh, tvdvuhchange);
        }
        public void BBL_Delete_TVDVUH(ThanhVienDonViUngHo tvdvuh)
        {
            DAL_Information.Instance.DAL_Delete_TVDVUH(tvdvuh);
        }
        public int BBL_Check_TVDVUH(ThanhVienDonViUngHo tvdvuh)
        {
            return DAL_Information.Instance.DAL_Check_TVDVUH(tvdvuh);
        }
    }
}
