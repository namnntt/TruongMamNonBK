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
        static IDangKyHocRepository dkhocRepo;
        static LopDangKyServices()
        {
            LopDangKyRepo = new LopDangKyRepository();
            dkhocRepo = new DangKyHocRepository();
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
        public static DataTable cacLopcoHocSinhdangKy()
        {
            List<DangKyHoc> dsdkHoc = dkhocRepo.GetAlls();
            List<LopDangKy> dslDK = LopDangKyRepo.LayDanhSachLopDangKy();
            var IDlopVaCount = from Dk in dsdkHoc
                              group Dk by new
                              {
                                  ID = Dk.LopDangKy,
                                  Thang = Dk.NgayDangKy.Month,
                                  Nam = Dk.NgayDangKy.Year
                              }
                              into g
                              where (g.Key.Thang == DateTime.Now.Month && g.Key.Nam == DateTime.Now.Year) 
                              select new
                              {
                                  ID = g.Key.ID,
                                  Count = g.Count()
                              };
            var dsLop = from IDLop in IDlopVaCount.ToList()
                        join Lop in dslDK on IDLop.ID equals Lop.MaLopDangKy
                        select new
                        {
                            IDLop.ID,
                            Lop.TenLopDangKy,
                            Lop.CLB1.TenCLB,
                            Lop.LichHoc,
                            Lop.NamHoc,
                            IDLop.Count,

                        };
            return GenericServices.ToDataTable(dsLop.ToList());
        }
    }
}
