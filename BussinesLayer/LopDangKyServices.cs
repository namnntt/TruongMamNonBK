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
        static IHoaDonRepository dsHDRepo;
        static IHocSinhRepository hsRepo;
        static IDangKyHocRepository dkHocRepo;
        
        static LopDangKyServices()
        {
            LopDangKyRepo = new LopDangKyRepository();
            dkhocRepo = new DangKyHocRepository();
            dsHDRepo = new HoaDonRepository();
            hsRepo = new HocSinhRepository();
            dkHocRepo = new DangKyHocRepository();
            
        }

        public static DataTable LayDanhSachLopDangKy(string MaHS)
        {
            List<LopDangKy> dslopDK = LopDangKyRepo.LayDanhSachLopDangKy();
            List<HoaDon> dsHD = dsHDRepo.GetAlls();
            List<HocSinh> dsHS = hsRepo.GetAlls();
            List<DangKyHoc> dsDK = dkhocRepo.GetAlls();
            var dsLDKMaHSDaThamGiaTrongThang = from ldk in dslopDK
                                               join dk in dsDK on ldk.MaLopDangKy equals dk.LopDangKy
                                               join hd in dsHD on dk.HoaDon equals hd.MaHD
                                               join hs in dsHS on hd.HocSinh equals hs.MaHS
                                               where (hs.MaHS == MaHS && (dk.NgayDangKy.Month == DateTime.Now.Month && dk.NgayDangKy.Year == DateTime.Now.Year))
                                               select new
                                               {
                                                   ldk.CLB,
                                                   ldk.TenLopDangKy,
                                                   ldk.LichHoc,
                                                   ldk.MaLopDangKy
                                               };
            var dsLDKHSChuaDangKy = from ldk in dslopDK
                                    where !(from ldk1 in dsLDKMaHSDaThamGiaTrongThang.ToList()
                                            select ldk1.MaLopDangKy).Contains(ldk.MaLopDangKy)
                                    select ldk;
            var dsComplete = from ldk in dsLDKHSChuaDangKy.ToList()
                             where !dsLDKMaHSDaThamGiaTrongThang.ToList().Any(x => x.LichHoc == ldk.LichHoc) &&
                             !(dsLDKMaHSDaThamGiaTrongThang.ToList().Any(x => x.CLB == ldk.CLB) && dsLDKMaHSDaThamGiaTrongThang.Any(x => x.TenLopDangKy == ldk.TenLopDangKy))
                             select new
                             {
                                 ldk.MaLopDangKy,
                                 ldk.TenLopDangKy,
                                 ldk.CLB1.TenCLB,
                                 ldk.CLB,
                                 ldk.NamHoc,
                                 ldk.HocPhi,
                                 ldk.LichHoc
                             };
            return GenericServices.ToDataTable(dsComplete.ToList());
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
