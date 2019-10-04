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
    public static class HocSinhServices
    {
        static IHocSinhRepository HocSinhRepo;
        static ILopDangKyRepository LopDangKyRepo;
        static IDangKyHocRepository DKHocRepo;
        static ICLBRepository CLBRepo;
        static IHoaDonRepository HDRepo;
        static HocSinhServices()
        {
            HocSinhRepo = new HocSinhRepository();
            LopDangKyRepo = new LopDangKyRepository();
            DKHocRepo = new DangKyHocRepository();
            HDRepo = new HoaDonRepository();
            CLBRepo = new CLBRepository();
        }
        public static DataTable LayHocSinhTheoLopDangKy(string TenLop, string MaCLB, int LichHoc)
        {
            List<HocSinh> dsHS = HocSinhRepo.GetAlls();
            List<HoaDon> dsHD = HDRepo.GetAlls();
            List<DangKyHoc> dsDKH = DKHocRepo.GetAlls();
            List<LopDangKy> dsLDK = LopDangKyRepo.LayDanhSachLopDangKy();
            List<CLB> dsCLB = CLBRepo.GetAlls();
            var DsHSDuDieuKienDK = from hs in dsHS
                                   where !(from hd in dsHD
                                           join dkh in dsDKH on hd.MaHD equals dkh.HoaDon
                                           join ldk in dsLDK on dkh.LopDangKy equals ldk.MaLopDangKy
                                           join clb in dsCLB on ldk.CLB equals clb.MaCLB
                                           where ((ldk.LichHoc == LichHoc || (ldk.TenLopDangKy == TenLop && clb.MaCLB == MaCLB)) && (hd.NgayTao.Value.Month == DateTime.Now.Month && hd.NgayTao.Value.Year == DateTime.Now.Year))
                                           select hd.HocSinh).Contains(hs.MaHS)
                                   select new
                                   {
                                       hs.MaHS,
                                       hs.TenHS,
                                       hs.NgaySinh,
                                       hs.LopHanhChinh.TenLopHC,
                                       hs.NgayNhapHoc,
                                       hs.DiaChi,
                                       hs.TenChaMe,
                                       hs.SDTChaMe
                                   };
            return GenericServices.ToDataTable(DsHSDuDieuKienDK.ToList());

        }
        public static DataTable LayHocSinhDaDangKyTheoMaLopDangKy(string MaLopDangKy)
        {
            List<HoaDon> dsHD = HDRepo.GetAlls();
            List<HocSinh> dsHS = HocSinhRepo.GetAlls();
            List<DangKyHoc> dsDK = DKHocRepo.GetAlls();
            var dsHSDaDK = (from hs in dsHS
                           join hd in dsHD on hs.MaHS equals hd.HocSinh
                           join dk in dsDK on hd.MaHD equals dk.HoaDon
                           where (hd.NgayTao.Value.Month == DateTime.Now.Month && hd.NgayTao.Value.Year == DateTime.Now.Year && MaLopDangKy == dk.LopDangKy)
                           select new
                           {
                               hs.MaHS,
                               hs.TenHS,
                               hs.NgaySinh,
                               hs.LopHanhChinh.TenLopHC,
                               hs.NgayNhapHoc,
                               hs.DiaChi,
                               hs.TenChaMe,
                               hs.SDTChaMe
                           }).Distinct();
            return GenericServices.ToDataTable(dsHSDaDK.ToList());
        }
    }
}
