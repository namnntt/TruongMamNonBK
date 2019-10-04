using DataLayer.InterFace;
using DataLayer.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public static class LopDangKyServices
    {
        static ILopDangKyRepository LopDangKyRepo;
        static LopDangKyServices()
        {
            LopDangKyRepo = new LopDangKyRepository();
        }

        public static DataTable LayDanhSachLopDangKy()
        {
            var dsLoc = from Lop in LopDangKyRepo.LayDanhSachLopDangKy()
                        select new
                        {
                            Lop.MaLopDangKy,
                            Lop.TenLopDangKy,
                            Lop.NamHoc,
                            Lop.CLB1.TenCLB,
                            Lop.LichHoc,
                            Lop.HocPhi,
                            Lop.CLB
                        };
            return GenericServices.ToDataTable(dsLoc.ToList());
        }
    }
}
